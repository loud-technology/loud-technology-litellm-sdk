#!/usr/bin/env python3
"""Apply deterministic fixes for gaps in LiteLLM's published OpenAPI document."""

from __future__ import annotations

import json
import sys
from pathlib import Path
from typing import Any


def rerank_schemas() -> dict[str, dict[str, Any]]:
    return {
        "RerankRequest": {
            "type": "object",
            "required": ["model", "query", "documents", "top_n"],
            "properties": {
                "model": {
                    "type": "string",
                    "description": "Reranking model or LiteLLM model alias.",
                },
                "query": {
                    "type": "string",
                    "description": "Query used to rank the documents.",
                },
                "documents": {
                    "type": "array",
                    "minItems": 1,
                    "items": {"type": "string"},
                    "description": "Documents to rank against the query.",
                },
                "top_n": {
                    "type": "integer",
                    "minimum": 1,
                    "description": "Maximum number of ranked results to return.",
                },
            },
        },
        "RerankResponse": {
            "type": "object",
            "required": ["results"],
            "properties": {
                "id": {
                    "type": "string",
                    "description": "Provider request identifier, when returned.",
                },
                "results": {
                    "type": "array",
                    "items": {"$ref": "#/components/schemas/RerankResult"},
                },
            },
        },
        "RerankResult": {
            "type": "object",
            "required": ["index"],
            "properties": {
                "index": {
                    "type": "integer",
                    "description": "Zero-based index of the document in the request.",
                },
                "relevance_score": {
                    "type": "number",
                    "format": "double",
                    "description": "Cohere-compatible relevance score.",
                },
                "score": {
                    "type": "number",
                    "format": "double",
                    "description": "Provider-specific score fallback.",
                },
            },
        },
    }


def apply_overrides(spec: dict[str, Any]) -> None:
    components = spec.setdefault("components", {})
    schemas = components.setdefault("schemas", {})
    schemas.update(rerank_schemas())

    try:
        operation = spec["paths"]["/v1/rerank"]["post"]
    except KeyError as exception:
        raise RuntimeError("LiteLLM OpenAPI no longer exposes POST /v1/rerank") from exception

    operation["requestBody"] = {
        "required": True,
        "content": {
            "application/json": {
                "schema": {"$ref": "#/components/schemas/RerankRequest"}
            }
        },
    }

    success = operation.setdefault("responses", {}).setdefault(
        "200", {"description": "Successful Response"}
    )
    success["content"] = {
        "application/json": {
            "schema": {"$ref": "#/components/schemas/RerankResponse"}
        }
    }


def main() -> None:
    if len(sys.argv) != 2:
        raise SystemExit(f"usage: {Path(sys.argv[0]).name} OPENAPI_FILE")

    path = Path(sys.argv[1])
    with path.open(encoding="utf-8") as stream:
        spec = json.load(stream)

    apply_overrides(spec)

    with path.open("w", encoding="utf-8") as stream:
        json.dump(spec, stream, ensure_ascii=False, separators=(",", ":"))
        stream.write("\n")


if __name__ == "__main__":
    main()

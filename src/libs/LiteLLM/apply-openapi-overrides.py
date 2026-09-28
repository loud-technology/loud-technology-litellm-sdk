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


def typesafe_schemas() -> dict[str, dict[str, Any]]:
    # AutoSDK (verified up to 0.34.6) maps dictionaries of oneOf unions to `object`, so questions and
    # answers use one flat schema per direction, keyed by the `type` enum.
    question_type = {
        "type": "string",
        "enum": ["choice", "score", "noul"],
    }

    return {
        "TypeSafeSystemOneRequest": {
            "type": "object",
            "required": ["state", "model", "questions"],
            "properties": {
                "state": {
                    "anyOf": [
                        {"type": "string"},
                        {"type": "object", "additionalProperties": True},
                        {"type": "array", "items": {}},
                    ],
                    "description": "Content to evaluate, as plain text or structured data.",
                },
                "model": {
                    "type": "string",
                    "default": "jev-latest",
                    "description": "Jev model identifier.",
                },
                "questions": {
                    "type": "object",
                    "minProperties": 1,
                    "additionalProperties": {
                        "$ref": "#/components/schemas/TypeSafeQuestion"
                    },
                    "description": "Questions to evaluate against the state, keyed by question id.",
                },
            },
        },
        "TypeSafeQuestion": {
            "type": "object",
            "required": ["type"],
            "properties": {
                "type": {
                    **question_type,
                    "description": "Question kind: `choice`, `score`, or `noul` (yes/no).",
                },
                "instructions": {
                    "type": "string",
                    "description": "Question asked about the state.",
                },
                "criteria": {
                    "anyOf": [
                        {
                            "type": "object",
                            "additionalProperties": {"type": ["string", "null"]},
                        },
                        {
                            "type": "array",
                            "minItems": 2,
                            "maxItems": 10,
                            "items": {"type": "string"},
                        },
                    ],
                    "description": (
                        "Options mapped to descriptions for `choice` (required, up to 255) "
                        "and `noul` (optional `true`/`false` keys), or ordered levels for "
                        "`score` (required, 2-10)."
                    ),
                },
            },
        },
        "TypeSafeSystemOneResponse": {
            "type": "object",
            "required": ["answers"],
            "properties": {
                "model": {
                    "type": "string",
                    "description": "Model version used for the evaluation.",
                },
                "answers": {
                    "type": "object",
                    "additionalProperties": {
                        "$ref": "#/components/schemas/TypeSafeAnswer"
                    },
                    "description": "Answers keyed by question id.",
                },
                "usage": {"$ref": "#/components/schemas/TypeSafeUsage"},
            },
        },
        "TypeSafeAnswer": {
            "type": "object",
            "required": ["type"],
            "properties": {
                "type": {
                    **question_type,
                    "description": "Kind of the question that produced this answer.",
                },
                "choice": {
                    "type": "string",
                    "description": "Selected option for `choice` answers.",
                },
                "score": {
                    "type": "number",
                    "format": "double",
                    "description": "Continuous level index for `score` answers.",
                },
                "noul": {
                    "type": "number",
                    "format": "double",
                    "description": "Probability that the statement is true for `noul` answers.",
                },
                "legend": {
                    "type": "object",
                    "additionalProperties": {"type": "string"},
                    "description": "Level index mapped to its label for `score` answers.",
                },
                "probabilities": {
                    "type": "object",
                    "additionalProperties": {"type": "number", "format": "double"},
                    "description": "Option or level index mapped to its probability.",
                },
                "confidence": {
                    "type": "number",
                    "format": "double",
                    "description": "Confidence from 0 to 1 for `choice` and `score` answers.",
                },
            },
        },
        "TypeSafeUsage": {
            "type": "object",
            "properties": {
                "input_tokens": {"type": "integer"},
                "output_tokens": {"type": "integer"},
            },
        },
    }


def apply_typesafe_overrides(spec: dict[str, Any]) -> None:
    paths = spec["paths"]
    try:
        passthrough = paths["/typesafe/{endpoint}"]["post"]
    except KeyError as exception:
        raise RuntimeError(
            "LiteLLM OpenAPI no longer exposes POST /typesafe/{endpoint}"
        ) from exception

    paths["/typesafe/v1/systemone"] = {
        "post": {
            "summary": "TypeSafe Jev System One",
            "description": passthrough.get("description", ""),
            "operationId": "typesafe_systemone_typesafe_v1_systemone_post",
            "tags": ["TypeSafe Pass-through"],
            # Exposed as `client.TypeSafe.SystemOneAsync(...)`.
            "x-fern-sdk-group-name": "typeSafe",
            "x-fern-sdk-method-name": "systemOne",
            "security": passthrough.get("security", []),
            "requestBody": {
                "required": True,
                "content": {
                    "application/json": {
                        "schema": {"$ref": "#/components/schemas/TypeSafeSystemOneRequest"}
                    }
                },
            },
            "responses": {
                "200": {
                    "description": "Successful Response",
                    "content": {
                        "application/json": {
                            "schema": {"$ref": "#/components/schemas/TypeSafeSystemOneResponse"}
                        }
                    },
                },
                "422": passthrough["responses"]["422"],
            },
        }
    }


def normalize_pattern_properties(node: Any) -> None:
    """Rewrite single-pattern `patternProperties` maps, which AutoSDK rejects, as `additionalProperties`."""
    if isinstance(node, list):
        for item in node:
            normalize_pattern_properties(item)
        return
    if not isinstance(node, dict):
        return

    patterns = node.get("patternProperties")
    if isinstance(patterns, dict) and len(patterns) == 1 and "additionalProperties" not in node:
        node["additionalProperties"] = node.pop("patternProperties").popitem()[1]

    for value in node.values():
        normalize_pattern_properties(value)


def apply_overrides(spec: dict[str, Any]) -> None:
    normalize_pattern_properties(spec)

    components = spec.setdefault("components", {})
    schemas = components.setdefault("schemas", {})
    schemas.update(rerank_schemas())
    schemas.update(typesafe_schemas())
    apply_typesafe_overrides(spec)

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

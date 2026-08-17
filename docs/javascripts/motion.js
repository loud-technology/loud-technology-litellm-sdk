(() => {
  "use strict";

  const root = document.documentElement;
  const reducedMotion = window.matchMedia("(prefers-reduced-motion: reduce)");
  let revealObserver;

  function revealImmediately(elements) {
    elements.forEach((element) => element.classList.add("is-visible"));
  }

  function initializeReveals() {
    const elements = [...document.querySelectorAll("[data-reveal]")];

    if (revealObserver) {
      revealObserver.disconnect();
    }

    if (!elements.length || reducedMotion.matches || !("IntersectionObserver" in window)) {
      revealImmediately(elements);
      return;
    }

    revealObserver = new IntersectionObserver(
      (entries) => {
        entries.forEach((entry) => {
          if (!entry.isIntersecting) return;
          entry.target.classList.add("is-visible");
          revealObserver.unobserve(entry.target);
        });
      },
      {
        rootMargin: "0px 0px -8% 0px",
        threshold: 0.12,
      },
    );

    elements.forEach((element) => revealObserver.observe(element));
  }

  function initializeCopyButtons() {
    document.querySelectorAll("[data-copy]").forEach((button) => {
      if (button.dataset.copyBound === "true") return;
      button.dataset.copyBound = "true";

      button.addEventListener("click", async () => {
        const value = button.dataset.copy || "";
        const originalLabel = button.textContent;

        try {
          await navigator.clipboard.writeText(value);
          button.textContent = "COPIED";
          button.classList.add("is-copied");
        } catch {
          button.textContent = "SELECT";
          const range = document.createRange();
          const code = button.parentElement?.querySelector("code");
          const selection = window.getSelection();

          if (code && selection) {
            range.selectNodeContents(code);
            selection.removeAllRanges();
            selection.addRange(range);
          }
        }

        window.setTimeout(() => {
          button.textContent = originalLabel;
          button.classList.remove("is-copied");
        }, 1800);
      });
    });
  }

  function initializePage() {
    root.classList.add("motion-ready");
    initializeReveals();
    initializeCopyButtons();
  }

  reducedMotion.addEventListener("change", initializeReveals);

  if (typeof document$ !== "undefined") {
    document$.subscribe(initializePage);
  } else if (document.readyState === "loading") {
    document.addEventListener("DOMContentLoaded", initializePage, { once: true });
  } else {
    initializePage();
  }
})();

# Expand Module Workflow

## Use When
Use this workflow when extending an existing module without redesigning the whole system.

## Steps
1. Read the global `CLAUDE.md`.
2. Read the target file in `docs/systems/`.
3. Read the module-local `CLAUDE.md`.
4. Read the current task file under `tasks/in-progress/`.
5. Confirm what interfaces must stay stable.
6. Implement the smallest useful expansion first.
7. Update UI or data only where directly needed.
8. Verify the module still integrates correctly.
9. Record lasting decisions in `.claude/memory/decisions.md` if needed.

## Output
- completed scope
- stable contracts preserved
- intentionally deferred items
- suggested next task

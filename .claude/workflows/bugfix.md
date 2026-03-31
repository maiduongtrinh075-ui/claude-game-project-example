# Bugfix Workflow

## Use When
Use this workflow when investigating or fixing a bug.

## Steps
1. Reproduce or narrow the failing scenario.
2. Identify the owning module.
3. Add logs or telemetry if the issue is intermittent.
4. Fix the smallest root cause you can verify.
5. Add or update a test when practical.
6. Record recurring pitfalls in `.claude/memory/known-issues.md` if relevant.

## Output
- root cause
- fix applied
- verification performed
- residual risks or unknowns

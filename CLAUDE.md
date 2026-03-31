# Global Claude Guide

## Project Goal
This repository demonstrates how to organize a large game project so Claude can expand one module at a time without destabilizing unrelated systems.

## How To Work In This Project
1. Read this file first.
2. Read `docs/guide.zh-CN.md`.
3. Read `docs/skills.zh-CN.md` if the task matches an existing skill.
4. Read `docs/workflows.zh-CN.md` if the task matches a known workflow.
5. Open the target module doc in `docs/systems/`.
6. Open the module-local `CLAUDE.md`.
7. Execute exactly one task from `tasks/in-progress/`.

## Default Collaboration Rules
- Prefer the smallest useful change.
- Expand one module at a time.
- Preserve public interfaces unless the task explicitly allows changes.
- Do not change save contracts without documenting the change.
- Do not rewrite shared core systems unless the task is explicitly about core.
- Record lasting decisions in `.claude/memory/decisions.md`.

## Stable Areas
- boot flow
- save compatibility
- shared event patterns
- core runtime utilities

## Expandable Areas
- gameplay modules
- module-local UI
- content definitions
- task-scoped data/config additions

## File Reading Order
- `CLAUDE.md`
- `docs/guide.zh-CN.md`
- `.claude/skills/<skill>/SKILL.md` when relevant
- `.claude/workflows/<workflow>.md` when relevant
- `docs/systems/<module>.md`
- `src/<module>/CLAUDE.md` or nearest module folder guide
- `tasks/in-progress/<task>.md`

## Default Non-Goals
- broad refactors
- global renames
- save schema redesign
- rewriting multiple systems in one pass

## Multi-Agent Guidance
- Use multiple agents only when work can be split into clearly separate areas.
- Assign one owner per module or file area.
- Keep write scopes separate to avoid conflicting edits.
- Let one main agent own final integration and verification.
- Avoid multi-agent work for small tasks or tightly coupled edits.

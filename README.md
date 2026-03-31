# Claude Game Project Example

This repository is a concrete example of a large game project structure designed for Claude-style modular expansion.

[中文首页](docs/index.zh-CN.md)

It demonstrates three layers working together:
- a global `CLAUDE.md` for project-wide rules
- module-level `CLAUDE.md` files for long-running feature areas
- single-iteration task files under `tasks/in-progress/`
- reusable project skills under `.claude/skills/`
- reusable workflows under `.claude/workflows/`
- lightweight hooks under `.claude/hooks/`
- reusable commands under `.claude/commands/`

## Start Here
- Read `CLAUDE.md`
- Read `docs/guide.zh-CN.md`
- Read `docs/skills.zh-CN.md`
- Read `docs/workflows.zh-CN.md`
- Read `docs/hooks.zh-CN.md`
- Read `docs/permissions.zh-CN.md`
- Read `docs/context-window.zh-CN.md`
- Read `docs/common-pitfalls.zh-CN.md`
- Read `docs/project-lifecycle.zh-CN.md`
- Read `docs/settings.zh-CN.md`
- Read `docs/review.zh-CN.md`
- Read `docs/session-handoff.zh-CN.md`
- Pick a module under `src/gameplay/`
- Open that module's `CLAUDE.md`
- Run one task from `tasks/in-progress/`

## Example Modules
- combat
- inventory
- quests
- battle UI

## Practical Example
- `examples/unity-csharp-ugui/`

## Why This Exists
Large game projects are hard to build in one shot.
This repo shows how to let Claude continue a feature from 0 to 1, then from 1 to 10, without losing boundaries.

## Start Building
If you are starting a real project, the best order is:
- write `CLAUDE.md`
- write the first module `CLAUDE.md`
- write the first round task
- then start writing code

## How To Start Coding With AI
Once the rules and the first task are written, start the implementation with an execution-style instruction.

Suggested prompt:

```text
Read `CLAUDE.md`, the related module `CLAUDE.md`, and the current task file.
Start implementing the task.
Only modify files inside the allowed scope.
Do not change interfaces marked as stable in the task.
When finished, report:
1. what changed
2. how it was verified
3. what remains for the next round
```

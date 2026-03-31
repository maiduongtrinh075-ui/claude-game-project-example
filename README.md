# Claude Game Project Example

This repository is a concrete example of a large game project structure designed for Claude-style modular expansion.

It demonstrates three layers working together:
- a global `CLAUDE.md` for project-wide rules
- module-level `CLAUDE.md` files for long-running feature areas
- single-iteration task files under `tasks/in-progress/`
- reusable project skills under `.claude/skills/`

## Start Here
- Read `CLAUDE.md`
- Read `docs/guide.zh-CN.md`
- Read `docs/skills.zh-CN.md`
- Pick a module under `src/gameplay/`
- Open that module's `CLAUDE.md`
- Run one task from `tasks/in-progress/`

## Example Modules
- combat
- inventory
- quests
- battle UI

## Why This Exists
Large game projects are hard to build in one shot.
This repo shows how to let Claude continue a feature from 0 to 1, then from 1 to 10, without losing boundaries.

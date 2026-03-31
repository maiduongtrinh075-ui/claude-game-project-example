# Combat Module Claude Guide

## Module Goal
Grow this module from a prototype into a reusable combat system through multiple scoped iterations.

## Current Stage
Phase 0. The module has only a conceptual baseline: basic attack, HP changes, and battle start/end flow.

## Expansion Order
1. player skill selection
2. enemy automatic turn behavior
3. buffs and debuffs
4. reward resolution
5. polish and balancing

## Allowed Work
- add combat-local models
- add combat-local state and resolver logic
- add skill definitions
- add enemy action selection rules
- coordinate with battle UI when needed

## Do Not Break
- combat entry point
- combat result event name
- external stat contract

## Out Of Scope By Default
- save redesign
- global balance pass
- global event bus refactor
- unrelated UI overhauls

## Recommended Reading Order
1. root `CLAUDE.md`
2. `docs/systems/combat.md`
3. this file
4. `tasks/in-progress/combat-phase-1.md`

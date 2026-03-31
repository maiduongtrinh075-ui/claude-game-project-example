# Combat Expansion

## Purpose
Use this skill to grow the combat module in controlled phases instead of redesigning the whole battle system at once.

## When To Use
- the combat module exists but is still shallow
- you want Claude to extend battle features step by step
- you need to keep save contracts and global events stable

## Read First
- `CLAUDE.md`
- `docs/systems/combat.md`
- `src/gameplay/combat/CLAUDE.md`
- the current task file under `tasks/in-progress/`

## Steps
1. Identify the current combat phase.
2. Keep scope to one phase only.
3. Preserve combat entry, result events, and external stat contracts.
4. Prefer additive changes over broad rewrites.
5. Expand gameplay rules before visual polish.
6. Document durable combat decisions after the task.

## Recommended Phase Order
1. skill selection
2. enemy turn behavior
3. buffs and debuffs
4. rewards
5. polish and balancing

## Common Pitfalls
- mixing UI logic with combat truth
- changing combat events during feature work
- adding too many mechanics in one round
- rewriting data models too early

## Do Not Do
- do not redesign save data by default
- do not merge multiple combat phases into one task unless explicitly asked
- do not hide combat rules inside UI controllers

## Output
Produce:
- what phase was completed
- what remained intentionally out of scope
- what contracts were kept stable
- any follow-up task recommendation

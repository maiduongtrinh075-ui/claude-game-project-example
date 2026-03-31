# Module Task

## Module
combat

## Goal
Take the combat module from a basic prototype toward a real playable loop by adding player skill selection and simple enemy turn behavior.

## Allowed Scope
- `src/gameplay/combat/`
- `src/ui/battle/`
- related docs for combat or UI

## Must Keep Stable
- combat entry point
- combat result event name
- save contract
- external stat structure

## Acceptance Criteria
- player can choose one of three skills
- enemy acts automatically on its turn
- battle can still end normally
- battle UI can present available actions

## Verification Notes
- test one win flow
- test one loss flow
- verify combat exits normally

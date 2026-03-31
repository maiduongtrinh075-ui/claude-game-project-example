# Module Task

## Module
Combat + Battle UI

## Goal
Take the Unity combat prototype from a basic attack button to a first playable phase with skill selection placeholders and enemy auto-turn preparation.

## Allowed Scope
- `Assets/Scripts/Gameplay/Combat/`
- `Assets/Scripts/UI/Battle/`
- `docs/systems/combat.md`

## Must Keep Stable
- save structure
- global event names
- scene boot flow

## Acceptance Criteria
- battle UI can present multiple action choices
- combat module remains the source of battle truth
- future enemy turn behavior has a clear extension point

## Verification Notes
- test one battle entry flow
- verify UI still binds to combat controller

# Combat System

## Purpose
Own the combat loop and resolve battle outcomes.

## Current Stage
Prototype. Basic attack and health reduction exist conceptually, but the expanded system is not complete.

## Expansion Roadmap
1. player skill selection
2. enemy turn logic
3. status effects
4. reward resolution
5. battle feedback polish

## Inputs
- unit stats
- action definitions
- combat configuration

## Outputs
- combat events
- state changes
- battle result

## Do Not Break
- combat entry point
- combat end event contract
- stat input structure without explicit migration planning

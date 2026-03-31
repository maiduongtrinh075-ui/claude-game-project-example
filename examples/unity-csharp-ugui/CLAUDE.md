# Unity Project Claude Guide

## Project Goal
This example represents a Unity game organized for Claude-friendly modular iteration.

## Tech Stack
- Engine: Unity
- Language: C#
- UI: UGUI
- Scripting Backend: flexible

## Working Style
- Keep Unity assets under `Assets/`
- Keep AI collaboration docs at the repository root
- Expand one gameplay module at a time
- Keep UI presentation separate from gameplay truth

## Read Order
1. `CLAUDE.md`
2. `docs/unity.zh-CN.md`
3. `docs/systems/<module>.md`
4. `Assets/Scripts/<module>/CLAUDE.md`
5. current task file under `tasks/in-progress/`

## Stable Areas
- boot scene flow
- shared UI patterns
- save data compatibility

## High-Risk Areas
- save models
- bundle or addressable loading policies
- cross-module events

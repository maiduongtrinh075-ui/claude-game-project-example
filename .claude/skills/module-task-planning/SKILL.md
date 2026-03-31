# Module Task Planning

## Purpose
Use this skill to turn vague feature requests into one-round module tasks that Claude can execute safely.

## When To Use
- a request is too broad
- the module is not clearly named
- the task touches multiple systems and needs narrowing
- you need a reusable task file under `tasks/in-progress/`

## Read First
- `CLAUDE.md`
- `docs/guide.zh-CN.md`
- relevant module docs under `docs/systems/`

## Steps
1. Identify the owning module.
2. Split the request into one-round goals.
3. Mark what must stay stable.
4. Define allowed directories or files.
5. Write acceptance criteria that can be checked.
6. Save the result as a task file.

## Common Pitfalls
- using goals that are too broad
- forgetting to name forbidden areas
- mixing refactor goals with feature goals
- acceptance criteria that cannot be verified

## Do Not Do
- do not create a task that spans too many unrelated modules
- do not leave acceptance criteria vague
- do not skip the stability constraints

## Output
Produce a task file containing:
- module
- goal
- allowed scope
- must keep stable
- acceptance criteria
- verification notes

# Commands 中文说明

`commands` 这一层解决的是:

把常见动作变成可复用的“入口命令模板”。

## commands 是什么

如果说:
- `task` 是这次做什么
- `workflow` 是这类事按什么顺序做
- `skill` 是这类问题怎么做

那么 `command` 更像:

“现在就要做这类动作时, 直接从哪里开始”

它很像高频操作入口。

## 什么时候适合写成 command

当一类动作会反复发生, 而且每次开头都差不多时, 最适合写成 command。

例如:
- 开始一轮任务
- 结束一轮任务
- 做 review
- 调试事故

## 这份示例里包含的 commands

- `start-task.md`
- `finish-task.md`
- `review-task.md`
- `debug-incident.md`

## 怎么理解它们

### `start-task`
开始一轮任务时应该先读什么、先做什么。

### `finish-task`
收尾时该输出什么、该补哪些信息。

### `review-task`
做 review 时先看什么、怎么汇报问题。

### `debug-incident`
调试事故时怎么开始收敛。

## command 和 workflow 的区别

- `workflow` 更像完整流程
- `command` 更像高频入口

你可以把 command 理解成:

“从完整流程里，提炼出来最常用的起手式”

## 推荐用法

你可以直接这样说:

```text
按 .claude/commands/start-task.md 开始这轮任务。
```

或者:

```text
按 .claude/commands/review-task.md review 这次改动。
```

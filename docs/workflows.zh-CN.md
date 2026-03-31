# Workflows 中文说明

如果说:
- `skill` 更像“某类问题怎么做”
- `task` 更像“这一次具体做什么”

那么 `workflow` 更像:

“这类工作应该按什么顺序推进”

你可以把它理解成 SOP 或流程模板。

## 为什么要有 workflows

在项目里, 很多任务不是“不知道做什么”, 而是“不知道先做哪一步”。

例如:
- 扩模块时先读文档还是先改代码
- 修 bug 时先复现还是先补日志
- 遇到 AssetBundle 事故时先清缓存还是先收集版本信息
- 要不要先拆任务, 再让 agent 动手

这些东西如果不写出来, 每次都靠 AI 自己猜。

## workflow 和 skill 的区别

- `skill`: 偏方法和经验
- `workflow`: 偏顺序和流程

举例:
- `assetbundle-debugging` 更像 skill
- `assetbundle-incident` 更像 workflow

前者告诉你这类问题怎么查, 后者告诉你收到这类问题时先做什么、后做什么。

## 这份示例里包含哪些 workflow

- `expand-module.md`
- `add-feature.md`
- `bugfix.md`
- `assetbundle-incident.md`
- `plan-task.md`
- `multi-agent-split.md`

## 怎么使用

你可以这样说:

```text
按 .claude/workflows/expand-module.md 扩写 combat 模块。
先读模块文档和模块 CLAUDE.md, 再执行任务文件。
```

或者:

```text
按 .claude/workflows/assetbundle-incident.md 排查这次 Android 端 UI 崩溃。
先收集版本、bundle 名和缓存状态, 再补日志。
```

## 什么时候优先看 workflow

当你已经知道“做哪类事情”, 但希望过程更稳定时, 优先看 workflow。

例如:
- 已经知道要扩写模块
- 已经知道要修 bug
- 已经知道要做任务拆分

这时 workflow 比 skill 更适合作为第一入口。

## 推荐理解方式

你可以用一句话记:

- `skill` 回答: 这类事怎么做
- `workflow` 回答: 这类事按什么顺序做
- `task` 回答: 这次具体做什么

三者一起用, 才最稳。

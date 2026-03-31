# Skills 中文说明

这个目录是给“项目经验沉淀”准备的。

如果说:
- `CLAUDE.md` 是全局协作规则
- 模块 `CLAUDE.md` 是局部长期规则
- `tasks/` 是本轮要做的事

那么 `.claude/skills/` 就是:

“某位熟悉项目的人留下来的专项能力包”

也可以理解成:

“离职同事没有走, 而是以 skill 的形式留在项目里。”

## skill 是干什么的

一个 skill 主要解决“某类事情应该怎么做”。

它通常会包含:
- 什么时候用
- 先看什么
- 分几步做
- 常见坑是什么
- 不要做什么
- 最后应该输出什么

所以 skill 不是单纯文档, 更像一个可复用的做事手册。

## 什么时候该用 skill

当任务属于“重复出现的一类工作”时, 最适合写成 skill。

例如:
- AssetBundle 崩溃排查
- 战斗系统扩写
- 模块任务拆分
- 存档兼容改动
- 新手引导扩写

## 这份示例里包含哪些 skill

- `assetbundle-debugging`
- `combat-expansion`
- `module-task-planning`

## 怎么使用

你可以直接这样对 Claude 说:

```text
使用 .claude/skills/assetbundle-debugging/SKILL.md 排查这次 Android 上的 UI 预制体崩溃。
先输出可能原因, 再补充建议日志点。
```

或者:

```text
按 .claude/skills/combat-expansion/SKILL.md 扩写 combat 模块第一阶段。
只做技能选择和敌人回合, 不改存档。
```

## 一个好 skill 的判断标准

如果一个 skill 满足下面这些条件, 通常就比较有价值:

- 不止会用一次
- 有固定步骤
- 有项目特有的坑
- 有明确输入和输出

## 推荐维护方式

每次遇到“这是老同事才知道的坑”, 就把它补进 skill:

- `Common Pitfalls`
- `Do Not Do`
- `Output`

这样随着项目变大, skill 会越来越像团队知识库。

# 中文首页

这个仓库是一份“适合 Claude 协作的大项目模板示例”。

它不是单纯放几份提示词, 而是把大项目里常见的协作层都拆出来了, 方便你理解:

- 全局规则怎么写
- 模块规则怎么写
- 单轮任务怎么写
- skill 怎么沉淀
- workflow 怎么组织
- hooks 怎么做提醒
- 多 agent 怎么分工
- 权限模式怎么限制
- 上下文窗口怎么控制

如果你是第一次打开这个仓库, 推荐按下面顺序阅读。

## 推荐阅读顺序

1. [全局 CLAUDE.md](../CLAUDE.md)
2. [总说明](guide.zh-CN.md)
3. [Skills 中文说明](skills.zh-CN.md)
4. [Workflows 中文说明](workflows.zh-CN.md)
5. [Hooks 中文说明](hooks.zh-CN.md)
6. [权限模式中文说明](permissions.zh-CN.md)
7. [上下文窗口中文说明](context-window.zh-CN.md)
8. [常见陷阱与性能优化](common-pitfalls.zh-CN.md)
9. [多 Agent 中文说明](multi-agent.zh-CN.md)
10. [项目生命周期](project-lifecycle.zh-CN.md)
11. [settings.json 中文说明](settings.zh-CN.md)
12. [Review 中文说明](review.zh-CN.md)

## 这个仓库里最关键的结构

### 1. 根目录 `CLAUDE.md`

这是总规则入口。  
它告诉 Claude:
- 项目是什么
- 默认怎么协作
- 什么是高风险区域
- 权限模式是什么
- 上下文应该怎么装载

### 2. 模块级 `CLAUDE.md`

例如:
- `src/gameplay/combat/CLAUDE.md`

这种文件适合写某个功能区自己的长期规则:
- 当前做到哪一步
- 下一步怎么扩
- 哪些接口不能动

### 3. `tasks/`

这里放单轮任务。  
它的作用是把“这次到底做什么”说清楚。

### 4. `.claude/skills/`

这里放“专项能力包”。  
你可以把它理解成项目里的“老同事经验手册”。

### 5. `.claude/workflows/`

这里放“做事顺序模板”。  
它解决的是“先做什么、后做什么”的问题。

### 6. `.claude/hooks/`

这里放自动检查或自动提醒的规则。

## 如果你想直接看更像真实项目的例子

可以直接看:

[Unity + C# + UGUI 子示例](../examples/unity-csharp-ugui/README.md)

这个子示例演示了:
- 如何把这套结构映射到 Unity 项目
- `Assets/` 和协作文档如何分层
- Gameplay 和 UI 如何拆分
- 如何给 Combat 模块单独写 `CLAUDE.md`

## 如果你想看连续任务链

可以看:

[combat 连续任务链示例](../examples/task-chain-combat/README.md)

这个示例演示:
- 一个模块如何从 phase 0 连续扩写到 phase 3
- task、workflow、review 如何配合
- 什么时候该记 decisions
- 每一轮应该如何收尾

## 一句话理解这个仓库

这个仓库想演示的是:

不要把 Claude 只当成“临时聊天写代码工具”, 而是把它放进一个有规则、有任务、有技能、有流程的大项目协作结构里。

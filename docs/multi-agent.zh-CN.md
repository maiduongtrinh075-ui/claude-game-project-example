# 多 Agent 中文说明

这份说明用来回答一个常见问题:

项目里要不要写多 Agent 协作规则?

答案是:

可以写, 但建议写轻量版。

## 为什么可以写

当项目变大以后, 有些任务天然可以拆开:
- 一部分人查问题
- 一部分人补日志
- 一部分人改 UI
- 一部分人补测试

如果这时没有规则, 多个 agent 很容易:
- 重复做同样的事
- 改到同一批文件
- 各自做得都对, 但最后拼不起来

所以多 Agent 规则真正的作用不是“显得高级”, 而是:

让并行开发不打架。

## 最重要的原则

### 1. 只有能拆开的任务才用多 Agent

适合:
- gameplay 和 UI 可以拆开
- bug 排查和日志补充可以拆开
- 文档和测试可以拆开

不适合:
- 任务太小
- 大量改同一文件
- 模块强耦合
- 需求还不清楚

### 2. 每个 Agent 要有明确所有权

例如:
- Agent A 负责 `src/gameplay/combat/`
- Agent B 负责 `src/ui/battle/`
- Agent C 负责 `docs/` 和 `tests/`

这样最不容易冲突。

### 3. 必须有一个主 Agent

主 Agent 的职责:
- 理解总任务
- 划分子任务
- 收敛最终结果
- 做最后验收

不要让所有 agent 平行散开后没人收口。

## 推荐写法

你完全不需要写成很复杂的制度。

在 `CLAUDE.md` 里补一小节就够了:

```md
## Multi-Agent Guidance
- Use multiple agents only when work can be split into clearly separate areas.
- Assign one owner per module or file area.
- Keep write scopes separate to avoid conflicting edits.
- Let one main agent own final integration and verification.
- Avoid multi-agent work for small tasks or tightly coupled edits.
```

这已经足够实用。

## 在游戏项目里的典型拆法

### 场景 1: 扩战斗模块

- 主 agent: 负责总任务、集成和验收
- Agent A: 改 `src/gameplay/combat/`
- Agent B: 改 `src/ui/battle/`
- Agent C: 补 `docs/` 和 `tasks/`

### 场景 2: 排查 AssetBundle 偶现崩溃

- 主 agent: 汇总结论
- Agent A: 查加载链路和日志点
- Agent B: 查缓存和版本管理
- Agent C: 查 prefab 序列化变更

### 场景 3: 做一个中等功能

如果只是一个中等功能, 通常单 Agent 更合适。

不要为了“用上多 Agent”而强行拆。

## 最后一个判断标准

如果一个任务同时满足这三点, 通常适合多 Agent:

- 可以拆成互不冲突的区域
- 每块都有明确 owner
- 最后有人统一集成

否则, 单 Agent 往往更稳。

# Unity 子示例中文首页

这个子示例演示的是:

如何把前面那套 Claude 项目协作结构, 真正映射到一个更贴近实战的 Unity + C# + UGUI 项目里。

## 适合谁看

如果你正在做:
- Unity 项目
- C# 游戏逻辑
- UGUI 界面
- 希望让 Claude 按模块持续扩写

那么这个子示例会比根目录的通用结构更贴近你的实际情况。

## 推荐阅读顺序

1. [子示例 CLAUDE.md](../CLAUDE.md)
2. [总说明](guide.zh-CN.md)
3. [Unity 映射说明](unity.zh-CN.md)
4. [Combat 系统说明](systems/combat.md)
5. [Combat 模块 CLAUDE.md](../Assets/Scripts/Gameplay/Combat/CLAUDE.md)
6. [Battle UI 模块 CLAUDE.md](../Assets/Scripts/UI/Battle/CLAUDE.md)
7. [当前任务示例](../tasks/in-progress/combat-ui-phase-1.md)

## 这个子示例里有什么

### 根目录 `CLAUDE.md`

这里写的是这个 Unity 子项目的总规则:
- 技术栈
- 默认工作方式
- 高风险区域
- 推荐阅读顺序

### `.claude/settings.json`

这里写的是结构化的项目配置:
- 默认工作模式
- 默认上下文策略
- 默认安全策略

### `docs/`

这里放的是中文说明和系统设计文档:
- `guide.zh-CN.md`
- `unity.zh-CN.md`
- `systems/combat.md`

### `Assets/Scripts/Gameplay/Combat/`

这里演示了一个需要长期扩写的 Unity gameplay 模块。

里面有:
- `README.md`
- `CLAUDE.md`
- 最小 C# 示例代码

### `Assets/Scripts/UI/Battle/`

这里演示 Battle UI 如何作为表现层配合 gameplay, 但不接管玩法真相。

### `tasks/in-progress/`

这里放当前这一轮的任务文件, 让 Claude 每次只做一轮小范围扩写。

## 这个示例想强调什么

最重要的是这几点:

- 协作文档放仓库根或子示例根, 不放进 Unity 运行资源逻辑里
- Gameplay 和 UI 分层
- Combat 模块有自己的长期规则
- 单轮任务文件驱动具体改动
- Claude 不应该一次重做整个系统

## 一个典型用法

你以后可以这样让 Claude 工作:

```text
阅读 CLAUDE.md、docs/unity.zh-CN.md、docs/systems/combat.md、Assets/Scripts/Gameplay/Combat/CLAUDE.md、tasks/in-progress/combat-ui-phase-1.md。
只扩写 Combat 模块和 Battle UI。
不要修改存档结构, 不要修改全局事件名。
```

这就是这个子示例最核心的使用方式。

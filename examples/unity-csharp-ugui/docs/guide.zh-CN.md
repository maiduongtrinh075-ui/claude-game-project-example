# Unity 示例中文说明

这个示例演示的是:

如何把前面那套 Claude 项目组织方式, 映射到一个更真实的 Unity + C# + UGUI 项目里。

## 这个示例的重点

- 协作规则仍然放仓库根目录
- Unity 资源和脚本仍然放在 `Assets/`
- gameplay 和 UI 分开
- combat 模块有自己的 `CLAUDE.md`
- 用任务文件驱动每一轮扩写

## 目录怎么理解

- `Assets/Scripts/Core/`: 公共基础设施
- `Assets/Scripts/Gameplay/`: 玩法模块
- `Assets/Scripts/UI/`: UGUI 界面逻辑
- `Assets/Scripts/Data/`: 数据定义和配置
- `Assets/Scripts/Integration/`: 模块连接层
- `Assets/Prefabs/`: UI 和玩法预制体
- `Assets/Scenes/`: 场景

## 这份示例适合什么用法

例如你想让 Claude 扩写战斗模块, 可以这样说:

```text
阅读 CLAUDE.md、docs/unity.zh-CN.md、docs/systems/combat.md、Assets/Scripts/Gameplay/Combat/CLAUDE.md、tasks/in-progress/combat-ui-phase-1.md。
只扩写 Combat 模块和 Battle UI, 不改存档结构, 不改全局事件名。
```

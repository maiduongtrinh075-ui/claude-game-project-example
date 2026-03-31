# Unity + C# + UGUI 映射说明

这份文档回答的是:

通用 Claude 项目结构, 到 Unity 项目里应该怎么落地。

## 推荐映射

- `src/core/` -> `Assets/Scripts/Core/`
- `src/gameplay/` -> `Assets/Scripts/Gameplay/`
- `src/ui/` -> `Assets/Scripts/UI/`
- `src/data/` -> `Assets/Scripts/Data/`
- `src/integration/` -> `Assets/Scripts/Integration/`

## 为什么协作文档不要放进 Assets

因为:
- `CLAUDE.md`
- `.claude/`
- `docs/`
- `tasks/`

这些是给人和 AI 协作看的, 不是 Unity 运行资源。

放在仓库根目录会更清晰。

## UGUI 项目推荐规则

- UI 控制器负责显示和交互
- 战斗规则不要写进 UI 里
- Prefab 命名尽量稳定
- 需要长期扩写的模块放模块级 `CLAUDE.md`

## 一个最重要的原则

UGUI 只是表现层, gameplay 规则仍然归 gameplay 模块所有。

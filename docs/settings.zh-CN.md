# settings.json 中文说明

`.claude/settings.json` 是这个项目给 Claude 的结构化协作配置。

它不是业务配置, 也不是游戏运行配置。

它的作用是:
- 结构化描述默认工作方式
- 把高频规则变成可读取字段
- 让工具或代理更容易按统一偏好工作

## 当前示例字段说明

### `project`

描述项目级元信息:
- `name`: 项目名
- `entry`: 默认入口文件
- `focus`: 项目类型或重点
- `defaultMode`: 默认权限/工作模式

### `defaults`

描述默认偏好:
- `preferSmallChanges`: 默认小步改动
- `singleModulePerTask`: 默认一轮只改一个模块
- `preferDocsBeforeCode`: 默认先读文档再读实现
- `updateDocsWhenBehaviorChanges`: 行为变化时同步文档
- `recordDurableDecisions`: 长期决策写入 memory

### `context`

描述上下文装载偏好:
- `startWithGlobalGuide`: 先读全局指南
- `preferMinimalRelevantContext`: 只装最小相关上下文
- `preferModuleRulesBeforeBroadCodeReads`: 先读模块规则再大范围读代码

### `safety`

描述安全边界:
- `preservePublicContracts`: 默认保留公共接口
- `avoidSaveChangesByDefault`: 默认不改存档
- `confirmHighRiskChanges`: 高风险改动先确认
- `avoidBroadRefactorsByDefault`: 默认不做大范围重构

### `highRiskAreas`

列出默认高风险区域, 方便 agent 快速识别。

### `preferredDocs`

列出推荐优先阅读的文档入口。

## 推荐原则

- 保持轻量
- 保持稳定
- 不要把长篇解释塞进 json
- 细节说明放到 `CLAUDE.md` 或 `docs/`

## 什么适合写进 settings

- 默认行为
- 默认安全策略
- 默认上下文策略
- 高风险区域列表
- 推荐阅读入口

## 什么不适合写进 settings

- 复杂教学解释
- 模块扩写阶段说明
- bug 排查经验
- 长篇协作原则

这些更适合放:
- `CLAUDE.md`
- `docs/`
- `skills/`
- `workflows/`

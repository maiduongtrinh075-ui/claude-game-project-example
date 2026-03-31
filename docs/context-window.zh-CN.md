# 上下文窗口中文说明

上下文窗口这一层, 解决的核心问题是:

AI 不是不能做大项目, 而是不能每次都把整个大项目完整装进脑子里。

所以项目里需要有一套规则, 告诉 AI:

这次应该读什么, 不应该读什么。

## 为什么要单独写这一层

如果没有上下文窗口规则, 常见问题会变成:

- 读太多无关内容
- 读完抓不住重点
- 被旧讨论和旧上下文污染
- 明明只改一个模块, 却把别的系统也带进来

所以它本质上是在控制:

“本轮任务的最小充分上下文”

## 最推荐的核心原则

### 1. 先全局, 再局部

推荐阅读顺序:

1. `CLAUDE.md`
2. 中文总说明
3. 相关 `skill`
4. 相关 `workflow`
5. `docs/systems/<module>.md`
6. 模块 `CLAUDE.md`
7. 当前任务文件
8. 相关代码实现

不要一上来就扫整个仓库。

### 2. 只读当前任务真正相关的模块

例如当前任务是扩写 `combat`, 那优先只读:
- `docs/systems/combat.md`
- `src/gameplay/combat/`
- `src/ui/battle/`
- 当前 task

默认不要把:
- `inventory`
- `quests`
- `network`
- `payment`

这些无关模块一起塞进上下文。

### 3. 优先读高密度信息源

文档、规则、skill、workflow 的信息密度通常高于大段代码。

所以推荐优先顺序是:
- 规则文件
- 模块说明
- 任务文件
- 代码实现

这样更容易在有限上下文里保留重点。

### 4. 上下文过大时主动裁剪

如果你发现任务开始牵扯太多内容, 优先保留:
- 当前模块
- 当前任务
- 当前 skill 或 workflow

优先丢掉:
- 不相关历史讨论
- 远处模块实现
- 暂时无关的系统细节

## 和 memory 的区别

很容易混的一点是:

- `memory` 是项目长期保存的重要信息
- `context window guidance` 是这一次该加载什么

也就是说:

项目可以长期记很多东西, 但每一轮不需要全读。

## 一个实战例子

如果当前任务是:

“扩写战斗模块第一阶段, 增加技能选择和敌人自动行动。”

推荐上下文是:
- `CLAUDE.md`
- `docs/systems/combat.md`
- `.claude/skills/combat-expansion/SKILL.md`
- `.claude/workflows/expand-module.md`
- `src/gameplay/combat/CLAUDE.md`
- `tasks/in-progress/combat-phase-1.md`
- `src/gameplay/combat/` 相关代码
- `src/ui/battle/` 相关代码

默认不需要加载:
- `inventory`
- `quests`
- `save schema`
- `network`

除非这轮任务明确依赖它们。

## 一个最重要的判断标准

如果某份信息不满足下面任一条件, 通常可以先不读:

- 它约束当前任务
- 它解释当前模块
- 它直接影响这轮改动
- 它决定验收标准

## 最后一句话

上下文窗口这一层的本质不是“让 AI 读更多”, 而是:

让 AI 每次只读当前最需要的那一小部分。

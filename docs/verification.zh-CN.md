# Verification 中文说明

`verification` 这一层解决的是:

改完之后, 怎么把“验证过什么、没验证什么、还剩什么风险”说清楚。

## 为什么 verification 很重要

很多团队的问题不是没有改代码, 而是:
- 不知道验证了什么
- 不知道没验证什么
- 不知道风险还剩多少

verification 模板的作用就是把这些内容固定下来。

## 这份示例里包含什么

- `templates/verification-report.md`
- `templates/review-report.md`

## `verification-report` 是干什么的

它用来记录:
- 当前任务
- 验证了什么
- 没验证什么
- 用什么方式验证
- 剩余风险
- 建议的下一步

## `review-report` 是干什么的

它更偏 review 输出, 用来记录:
- findings
- open questions
- verification gaps
- change summary
- residual risks

## 推荐原则

- 明确区分“已验证”和“未验证”
- 不要把残余风险藏起来
- 验证不完整也可以, 但要说清楚
- 优先高风险区域的验证

## 对游戏项目特别重要的验证点

- save 兼容性
- AssetBundle / Addressables 版本一致性
- gameplay truth 是否还在正确模块
- UI 是否只负责表现和交互
- 真机和目标平台是否验证过

## 推荐用法

做完任务后, 可以直接按模板写:

- 一份 verification report
- 一份 review report

这样下一轮接手的人会更容易判断当前结果是否可靠。

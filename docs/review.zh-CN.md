# Review 中文说明

这份文档定义的是:

Claude 在做 review 或提交结果时, 应该如何汇报发现、风险和验证情况。

## review 的核心目标

不是泛泛评价代码“好不好”, 而是优先回答:
- 有没有 bug 风险
- 有没有行为回归
- 有没有高风险改动
- 有没有缺少验证

## 推荐输出顺序

1. Findings
2. Open Questions
3. Change Summary
4. Verification
5. Residual Risks

## 1. Findings

如果发现问题, 先列问题, 不要先写长摘要。

建议优先级顺序:
- 会导致崩溃或错误行为
- 会导致数据不兼容
- 会导致性能明显退化
- 会导致维护性或扩展性问题

## 2. Open Questions

如果有不能确定的点, 单独写出来, 不要混在总结里。

例如:
- 这个 bundle 是否一定同版本
- 这个 UI prefab 是否存在历史缓存

## 3. Change Summary

简要总结改了什么即可, 不要变成流水账。

## 4. Verification

明确说:
- 跑了什么验证
- 没跑什么验证
- 原因是什么

## 5. Residual Risks

如果还有风险没完全消除, 必须直说。

例如:
- 只在编辑器验证, 未在 Android 真机验证
- 只验证了单 bundle, 未验证依赖 bundle

## Review 结果模板

```text
Findings:
- ...

Open Questions:
- ...

Change Summary:
- ...

Verification:
- ...

Residual Risks:
- ...
```

## 对游戏项目特别重要的 review 点

- save 兼容性
- AssetBundle / Addressables 版本一致性
- 模块边界是否被破坏
- UI 是否接管了 gameplay truth
- 是否改到了不在 task scope 内的文件

# 会话记忆

## 2026-06-04

建立 `.codewhale/session-memory.md` 格式，定义 AI 会话记忆机制。
- 启动时 AI 自动读取此文件
- 结束时追加结构记录

## 2026-06-04（v2 — 自动触发）

重写 `.codewhale/instructions.md`，添加启动/结束指令。AI 在新对话中自动读记忆，无需手动提示。
- 测试短语：**9527**

## 2026-06-04（v4 — 完全体上线）

将整个工作区推送到 `github.com/VK4502/CodeWhale`。
- 仓库名：`CodeWhale`
- git 代理：`http://127.0.0.1:7897`
- `.gitignore` 忽略 `repos/.git`
- 记忆更新后通过 yolo 任务自动 commit + push

## 2026-06-04（v5 — 角色系统）

尝试设计多角色模式（开发者、军师、审查官、冷酷、话痨、指挥官、猫娘、编码），后用户决定清除所有角色模式，保留默认助手模板。
- 精简了 session-memory.md 为 20 行精简版
- 创建 `role-card.html` 留作日后修改角色设定用
- 删除了 instructions.md 中的角色模式章节

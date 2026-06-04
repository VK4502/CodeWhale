# 会话记忆

> 每次会话结束时，在此追加一条记录，供下一次会话读取。
> 格式：`## YYYY-MM-DD` + 摘要内容。

---

## 2026-06-04

### 目标
建立跨会话记忆机制 —— 在 `.codewhale/session-memory.md` 中记录每次会话的关键信息，供后续会话读取。

### 完成的工作
- 新建 `.codewhale/session-memory.md`，定义会话记忆格式
- 写入此条初始记录

### 关键决策
- 记忆存储路径：`.codewhale/session-memory.md`
- 每次会话结束时追加一条 `## YYYY-MM-DD` 条目
- 条目包含：目标、完成的工作、关键决策、阻塞项、下一步
- 后续会话启动时，AI 读取此文件以恢复上下文

### 下一步
在未来的任务会话中，工作结束时向此文件追加记录。

---

## 2026-06-04（第二次会话）

### 目标
完善跨会话记忆的**自动触发机制** —— 让 AI 在新对话开始时自动读取 session-memory.md，而不需要用户手动提示。

### 完成的工作
- 重写了 `.codewhale/instructions.md`，加入「会话启动指令」和「会话结束指令」
- 会话启动指令：新对话开始时 AI 必须按顺序读取 session-memory.md、整合上下文、必要时创建模板
- 会话结束指令：对话结束前向 session-memory.md 追加 `## YYYY-MM-DD` 记录
- 验证了整个闭环——本条记录就是按指令写入的

### 关键决策
- 利用 CodeWhale 的 `EngineConfig.instructions` 机制（`.codewhale/instructions.md` 自动加载为 Tier 5 Local Law）
- 不需要 hooks、插件或额外配置，纯靠 project instructions 的自动加载能力

### 关键发现
- 用户在本会话中提到了一个测试短语 **"9527"**，用于验证跨会话记忆是否生效。
- 验证方式：关闭当前会话 → 打开新对话 → 查看 AI 是否知道 9527 这个数字。

### 下一步
正常在项目工作中使用，记忆会自动累积。

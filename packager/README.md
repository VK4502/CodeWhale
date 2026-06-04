# GamePackager — HTML 游戏打包为 exe

将任意 HTML 游戏打包成 Windows exe，基于 WebView2 引擎。

## 使用方式

### 直接编译运行

```bash
cd packager
dotnet build -c Release
```

生成 `bin\Release\net8.0-windows\GamePackager.exe`

### 打包游戏

**方式 A：拖放**
把 HTML 文件拖到 `GamePackager.exe` 上，自动打开。

**方式 B：改名**
把 HTML 文件改名为 `index.html`，和 exe 放同目录，双击 exe 即可。

**方式 C：命令行**
```bash
GamePackager.exe 你的游戏.html
```

### 设置图标

在 exe 同目录放一个 `app.ico`，窗口标题栏和任务栏自动显示该图标。

## 发布单文件 exe（可脱离 .NET 运行）

```bash
cd packager
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
```

生成 `bin\Release\net8.0-windows\win-x64\publish\GamePackager.exe`，单文件约 60MB（自带 .NET 运行时）。

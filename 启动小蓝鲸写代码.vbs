Set ws = CreateObject("WScript.Shell")
exe = ws.CurrentDirectory & "\codewhale-tui-windows-x64.exe"
ico = ws.CurrentDirectory & "\whale.ico, 0"

' 创建/更新带图标的快捷方式
lnk = ws.CurrentDirectory & "\" & ChrW(23567) & ChrW(34013) & ChrW(40120) & ChrW(20889) & ChrW(20195) & ChrW(30721) & ".lnk"
Set sc = ws.CreateShortcut(lnk)
sc.TargetPath = exe
sc.IconLocation = ico
sc.Save()

' 启动程序
ws.Run exe, 1, False

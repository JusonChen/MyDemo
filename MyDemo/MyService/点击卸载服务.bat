@ECHO OFF
echo 准备卸载《测试Test服务》
pause
REM The following directory is for .NET 4.0
set DOTNETFX2=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%DOTNETFX2%
echo 卸载 《测试Test服务》...
echo ---------------------------------------------------
set CURRENT_DIR=%~dp0
echo %CURRENT_DIR%
InstallUtil /u %CURRENT_DIR%\MyService.exe
echo ---------------------------------------------------
echo 卸载《测试Test服务》成功。
pause
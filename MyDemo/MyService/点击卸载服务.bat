@ECHO OFF
echo ׼��ж�ء�����Test����
pause
REM The following directory is for .NET 4.0
set DOTNETFX2=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%DOTNETFX2%
echo ж�� ������Test����...
echo ---------------------------------------------------
set CURRENT_DIR=%~dp0
echo %CURRENT_DIR%
InstallUtil /u %CURRENT_DIR%\MyService.exe
echo ---------------------------------------------------
echo ж�ء�����Test���񡷳ɹ���
pause
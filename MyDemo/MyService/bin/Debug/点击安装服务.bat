@ECHO OFF
echo ׼����װ�����Է���
pause
REM The following directory is for .NET 4.0
set DOTNETFX2=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%DOTNETFX2%
echo ��װ �����Է���...
echo ---------------------------------------------------
set CURRENT_DIR=%~dp0
echo %CURRENT_DIR%
InstallUtil /i %CURRENT_DIR%\MyService.exe
echo ---------------------------------------------------
echo ��װ�����Է��񡷳ɹ���
pause
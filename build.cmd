:: Build batch file

SET CSHARPCOMPILER="\program files (x86)\msbuild\12.0\bin\csc.exe"
SET DEFAULT_PARAMS=/t:exe /r:System.dll /debug- /w:4 /warnaserror+ 
%CSHARPCOMPILER% %DEFAULT_PARAMS% %1
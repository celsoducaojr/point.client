@echo off
set FILE_PATH=C:{filepath}

powershell -command ^
"$excel = New-Object -ComObject Excel.Application; ^
$excel.Visible = $false; ^
$wb = $excel.Workbooks.Open('%FILE_PATH%'); ^
$ws = $wb.ActiveSheet; ^
$ws.PrintOut(); ^
$wb.Close($false); ^
$excel.Quit()"

sqlcmd -U oee -P oee -S .\SQLEXPRESS -Q "EXEC BackupDatabases @BackupDir='c:\sql\', @DatabaseName='oee', @BackupType=0"

move c:\sql\*.bak \\Wlini\felles\sql
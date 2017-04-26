# ExcelToSqlScripts

This small command line tool to help you convert data of excel files into insert statements in SQL syntax.

1. Navigate to [dotnet core website](https://www.microsoft.com/net/core) and follow instructions to install dotnet core
2. Download [lates binaries](https://github.com/bilal-fazlani/ExcelToSqlScripts/releases/latest) of this tool 
3. Extract zip and navigate to extracted folder
4. Run `dotnet ExcelToSQLScripts.Console.dll -- help`


## Converting a Excel (.xlsx) file in sql scripts

```
dotnet ExcelToSQLScripts.Console.dll -i <PATH_TO_XLSX_FILE> -o <OUTPUT_DIRECTORY_FOR_SQL_FILES>
```
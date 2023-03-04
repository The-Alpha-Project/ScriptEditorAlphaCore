# ScriptEditor
Database scripts editor for the alpha-core 0.5.3 alpha emulator, based on brotalnia's ScriptEditor for vMangos.

Changes:

- updated to .NET 4.71
- old MySQL connector replaced by a current one
- database queries adapted to alpha-core's multi-database structure
- in-UI loading progress instead of a console window
- proper INI file parsing and config.ini file will be created if it doesn't exist

Preview:

![script editor gui](https://i.imgur.com/zxgHXAv.png)

The point of this software is to make scripting content more accessible by removing the need to know anything about programming or SQL syntax. All the script information is presented visually with proper field names for each parameter based on the command and previews for things such as texts. The editor will automatically generate the proper SQL queries when you are done working, so you may easily pull request your changes.

# ScriptEditor
Database scripts editor for the alpha-core 0.5.3 alpha emulator, based on brotalnia's ScriptEditor for vMangos.

Changes:

- updated to .NET 4.71
- old MySQL connector replaced by a current one
- database queries adapted to alpha-core's multi-database structure
- in-UI loading progress instead of a console window
- proper INI file parsing and config.ini file will be created if it doesn't exist
- slightly improved script editor including specific handling of quest start/end scripts
- look up creature spell timers from the casts editor if spell sniff database is present
- other QoL improvements

# Installation

Download the latest release from [Releases](https://github.com/mindphluxnet/ScriptEditorAlphaCore/releases) and unpack the archive to any directory. 

# Configuration

Open ```config.ini``` using a text editor. You should see the following content:

```
User = root
Pass = pwd
Host = localhost
Port = 3306
Locale = en-US
Highlight = False
```

Set your database user name and password and the database host name if needed. Save the file.

# Usage

Run ```ScriptEditor.exe```

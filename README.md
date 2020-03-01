# BeatSaber Clock
Adds a clock to the main menu screen
![mainmenu_clock](Image/mainmenu_clock.png)

## Custom Clock Format
In `(BeatSaberDir)\UserData\Clock.json` change ClockFormat to standard C# DateTime format. Default: `hh:mm tt`

Find format at https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings

## For developers
### Project config
Clock.csproj is configured to find beatsaber via `current_directory\BSReferences`. Edit MakeJunction.bat as needed and run to make junction at current path.

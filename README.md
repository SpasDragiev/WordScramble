# Word Scramble

Simple Windows Forms word scramble game written in C# targeting .NET 6.

Prerequisites
- .NET 6 SDK
- Visual Studio 2022+ or Visual Studio 2026 (recommended)

Build & run
- Visual Studio: Open `WordScramble.sln` and run the project.
- dotnet CLI:
  1. Open a terminal in the solution folder.
  2. dotnet restore
  3. dotnet build
  4. dotnet run --project WordScramble\WordScramble.csproj

Usage
- The app reads words from `words.txt` (one word per line).
- Press "Check" to submit a guess or "Skip" to move to the next word.
- Failed attempts are shown in the UI; after several failed attempts the word is skipped automatically.

Adding words
- Edit `words.txt` and add one word per line. Save and restart the app to load changes.

Notes
- This is a small sample desktop app; modify freely for learning or as a starting point for enhancements.
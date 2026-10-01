# Terminology

## Domain

- ScoobyDoo exercise - A FizzBuzz-type task. Write 1 to 100. Replace multiples of 5 and 7 with words.
- Scooby - The word for a number that is divisible by 5 and not by 7.
- Doo - The word for a number that is divisible by 7 and not by 5.
- ScoobyDoo - The word for a number that is divisible by 5 and by 7 (35, 70).
- Translate - The pure function in `Program.cs` that changes a number into its word, or into the number text.
- Paint - The function in `Program.cs` that adds Spectre color markup to a word. It does not change the word.

## Technical

- Lode - The AI-owned markdown memory of this project, in `.lode/`.
- Lode file - One markdown file in the Lode. It covers one topic and has less than 250 lines.
- Top-level statements - C# entry point code without an explicit `Main` method. `Program.cs` uses this.
- TFM - Target Framework Moniker. This project uses `net10.0`.
- Spectre.Console - NuGet library for rich console output (markup colors, Figlet text).
- Spectre markup - Inline style syntax `[style]text[/]`, for example `[orange1]Scooby[/]`.

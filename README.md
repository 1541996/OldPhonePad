# Phone Keypad Simulation

This program simulates an old phone keypad input system, where numbers 2-9 are mapped to letters in the same way as traditional mobile keypads. The program interprets input sequences where digits represent multiple key presses to generate the corresponding letter(s), and it handles special characters (`*` and `#`) for editing the input.

## Features
- **Multiple Key Presses**: Each number (2-9) corresponds to a set of letters (e.g., 2 -> "ABC", 3 -> "DEF", etc.). Pressing a key multiple times cycles through the letters of the set.
- **Backspace (`*`)**: If `*` is entered, the last character typed is removed.
- **End Input (`#`)**: When `#` is entered, the program stops processing input and returns the result up to that point.
- **Handles Invalid Characters**: Any character that is not a digit (2-9), `*`, or `#` is ignored.

## Methods

### `OldPhonePad(string input)`

This method processes the input string and returns the resulting string based on old phone keypad mappings. It handles special characters for editing the input, cycles through letter sets, and ensures the input terminates correctly at `#`.

#### Parameters:
- `input` (string): A sequence of characters representing the key presses. The sequence may contain digits, `*`, and `#`.

#### Returns:
- A string representing the result of processing the input sequence.

### `Main()`

This method demonstrates the functionality of the `OldPhonePad` method by printing the results of several example inputs.

## Example Usage

### Example 1:
```csharp
Console.WriteLine(OldPhonePad("33#")); // Output: E
Console.WriteLine(OldPhonePad("227*#")); // Output: B
Console.WriteLine(OldPhonePad("4433555 555666#")); // Output: HELLO
Console.WriteLine(OldPhonePad("8 88777444666*664#"));

Requirements
.NET runtime environment to compile and execute the C# program.

Added Unit Testing by using xUnit Testing Library in .Net Core.

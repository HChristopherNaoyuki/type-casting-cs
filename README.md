# Type Casting with Exception Handling in C#

This program demonstrates type casting in C#, specifically converting between `double` and `int`, and vice versa. It also showcases how to handle potential exceptions that might occur during these conversions.

## Features

- **Type Casting**: Demonstrates the conversion of `double` to `int` and `int` to `double`.
- **Exception Handling**: Includes exception handling for:
  - `FormatException`: Catches issues with incorrect format during conversion.
  - `InvalidCastException`: Catches invalid type cast attempts.
  - `OverflowException`: Handles conversion overflows (e.g., too large or too small for the target type).
  - General `Exception`: Catches any other unexpected errors that might occur.
- **Type Information Display**: Outputs the types of variables before and after conversion to the console.
- **Conversion Results**: Outputs the results of the type conversions for easy inspection.

### Running the Program

1. Clone the repository or download the project files.
2. Open the project in your preferred code editor.
3. Open the terminal or command prompt.
4. Navigate to the project directory and run the following commands:

```bash
dotnet build
dotnet run
```

### Sample Output

```text
PiValue's type: System.Double
piAsInteger (converted from PiValue): 3
resultValue: 112.12
piAsInteger's type: System.Int32
resultValue's type: System.Double
```

## Error Handling

The program includes robust exception handling that will capture and display relevant error messages if any of the following occur:

- **FormatException**: Triggered by an invalid format in the data being converted.
- **InvalidCastException**: Triggered when trying to cast a type that is incompatible.
- **OverflowException**: Triggered when a conversion results in a value that is out of the target type’s range.

---

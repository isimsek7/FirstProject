# Console Application: Game of Guess, Calculator, and Grade Result

This project is a simple console-based C# application that allows the user to choose between three different programs:

1. **Game of Guess**: A guessing game where the user tries to guess a random number between 1 and 100 with limited chances.
2. **Calculator**: A basic calculator that performs addition, subtraction, multiplication, and division.
3. **Grade Result**: A program where the user inputs exam results to calculate the average grade and assign a letter grade based on the average.

## Features

- **Game of Guess**:
  - Random number between 1 and 100.
  - 5 chances to guess the number.
  - Provides feedback on whether the guessed number is higher or lower.
  
- **Calculator**:
  - Perform basic arithmetic operations: addition, subtraction, multiplication, and division.
  - Handles exceptions like divide by zero or invalid input.
  
- **Grade Result**:
  - Accepts three exam results as input.
  - Calculates the average and assigns a letter grade.
  - Handles invalid inputs with error messages.

## How to Use

1. Upon starting the application, you will be prompted to choose between the three available programs by entering a corresponding number:
   - `1` for Game of Guess
   - `2` for Calculator
   - `3` for Grade Result
  
2. After completing a program, you will be asked whether you want to continue. Enter `Y` to continue or `N` to exit.

## Error Handling

The application includes basic error handling:
- Invalid input is caught and an appropriate message is displayed.
- Specific errors like `DivideByZeroException` and `FormatException` are handled in the Calculator and Grade programs.

## Requirements

- .NET 5.0 or higher

## How to Run

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio or your preferred C# editor.
3. Build and run the application from the terminal or IDE.

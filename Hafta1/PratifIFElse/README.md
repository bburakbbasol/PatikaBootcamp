# ConsoleApp2
# Number Checking Program

## Description

This program is a simple console application written in C# that takes an integer input from the user and performs the following checks:

- Determines if the number is greater than 10.
- Checks if the number is even or odd if it is greater than 10.
- Provides appropriate messages based on the number's properties.

## How It Works

1. The program prompts the user to enter a number.
2. It reads the user's input as a string and converts it to an integer.
3. It checks if the number is greater than 10:
    - If the number is greater than 10:
        - Checks if the number is even (divisible by 2):
          - Displays: **Girilen Sayı Çifttir** (The entered number is even).
        - Otherwise:
          - Displays: **Girilen Sayı Tekdir** (The entered number is odd).
    - If the number is less than or equal to 10:
        - Displays: **Girilen Sayı 10 dan küçüktür** (The entered number is less than 10).

## Usage

1. Copy the code into a C# file, for example, `Program.cs`.
2. Compile and run the program using a C# compiler or an IDE like Visual Studio.
3. When prompted, input an integer and press Enter.
4. View the output message based on the input.

## Example Execution

**Input:**
```text
12
```
**Output:**
```text
Girilen Sayı Çifttir
```

**Input:**
```text
7
```
**Output:**
```text
Girilen Sayı 10 dan küçüktür
```

**Input:**
```text
15
```
**Output:**
```text
Girilen Sayı Tekdir
```

## Notes

- The program assumes valid integer input from the user.
- Additional input validation can be added to handle non-integer inputs gracefully.

## Improvements

- Add input validation to check if the user enters a valid number.
- Enhance the program to allow repeated checks without restarting.

  

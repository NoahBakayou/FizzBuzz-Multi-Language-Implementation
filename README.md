# FizzBuzz Multi-Language Implementation

This project includes the implementation of the classic FizzBuzz problem in multiple programming languages: Python, JavaScript, Java, C#, Lisp, and C. The goal is to explore the syntax, execution, and setup differences across these languages.

## Overview

Each source file named according to its programming language (e.g., `FizzBuzz.py` for Python) contains the FizzBuzz logic implementation. The program iterates through numbers 1 to 100, printing "Fizz" for multiples of 3, "Buzz" for multiples of 5, "FizzBuzz" for multiples of both, and the number itself otherwise.

## Compilation and Execution Instructions

Below are the instructions for compiling and running each program, including environment setup tips.

### Python

- **Environment Setup**: Ensure Python is installed and the Python extension for VS Code is enabled.
- **Execution**: Run `python FizzBuzz.py` in the terminal.

### JavaScript

- **Environment Setup**: Install Node.js to execute the script outside a browser and set it in environmental variable.
- **Execution**: Navigate to the directory of your project and run `node FizzBuzz.js`.

### Java

- **Environment Setup**: Install the Java Extension Pack for VS Code and configure JDK.
- **Compilation**: Compile with `javac FizzBuzz.java`.
- **Execution**: cd into src and run with `java FizzBuzz`.


### C#

- **Environment Setup**: Install the .NET SDK and the C# extension for VS Code.
- **Compilation and Execution**: Run `FizzBuzz.cs` within a .NET project setup using the default configuration.

### Lisp

- **Environment Setup**: Install a Lisp interpreter or compiler. Install [Steel Bank Common Lisp](https://www.sbcl.org/platform-table.html) based on what OS you are using. Add bin path to environmental variable. Install Alive lisp environment in vs code extensions.
- **Execution**: I used  & 'C:\Program Files\Steel Bank Common Lisp\sbcl.exe' --script "C:\Users\noah1\Coding Projects\VSCodeProjects\lisp\FizzBuzz.lisp"  to directly specify the path and run `FizzBuzz.lisp`.

### C

- **Environment Setup**: Install GNU Compiler COllection. I used msys2. This is a newer version that Microsoft Visual Studio uses by default
- **Compilation**: Compile with `gcc -o FizzBuzz FizzBuzz.c` or `clang -o FizzBuzz FizzBuzz.c`. I used the first
- **Execution**: Run `./FizzBuzz`. This is the executable, if you're not sure if it's in your directory, use ls and look for an exe file.
- 
## Challenges and Solutions
- One challenge I ran into was accidentally downloading the Linux version of Lisp instead of Windows. I recognized that the file extensions were not .exe and realized my mistake.
- This made it impossible to set as an environmental variable and I have thus learned from my mistake.

- I also struggled to run Lisp in the terminal in VS code without directly specifying the path. 
- I believe this is related to the way I initially set up my environmental variable 

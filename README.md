# C# Variable Scope Subtlety

This repository demonstrates a subtle bug related to variable scope in C#.  The `bug.cs` file contains code that compiles but might produce unexpected results or runtime errors depending on the context. The correct solution is in `bugSolution.cs`.

## Problem

The `MyMethod` function in `bug.cs` declares a local variable `x`.  While this function *appears* to work correctly, it showcases a risky behavior.  This can lead to unpredictable behavior in more complex programs. In this instance, accessing the variable outside of its scope is undefined and should be avoided. 

## Solution

The `bugSolution.cs` file corrects this by ensuring proper variable scoping. The variable is now correctly used within its scope, preventing potential issues. 
# C# Fundamentals

Class notes and practice projects covering core C# concepts from Microsoft learning materials.

## Topics

- Variables, data types, and expressions
- `null` values and nullable elements
- `if`, `else if`, and `else` statements
- `for` and `foreach` loops
- Arrays and collection iteration
- String data and common manipulation techniques
- Creating and calling methods
- `void` methods and return values
- Collecting and validating user input
- Using the C#/.NET library and namespaces
- C# coding conventions and readable structure

## Purpose

This repository is a reference for learning C# fundamentals through concise notes, examples, and hands-on exercises. The code emphasizes understanding control flow, reusable methods, data handling, and standard C# style.

## Example concepts

```csharp
string? name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
	Console.WriteLine("Please enter a name.");
}
else
{
	Console.WriteLine($"Hello, {name}!");
}

static void PrintItems(string[] items)
{
	foreach (string item in items)
	{
		Console.WriteLine(item);
	}
}
```

## Getting started

1. Install the [.NET SDK](https://dotnet.microsoft.com/download).
2. Clone or download this repository.
3. Open the project in Visual Studio or VS Code with the C# extension.
4. Run a project with:

   ```bash
   dotnet run
   ```

5. Read the notes and modify the examples to reinforce each concept.

## Coding conventions

- Use meaningful names and consistent indentation.
- Keep methods focused on one responsibility.
- Prefer clear, readable code over unnecessary shortcuts.
- Validate user input before using it.
- Use standard C# naming conventions such as `PascalCase` for methods and types and `camelCase` for local variables.

## Status

This is an evolving learning repository. Examples and notes may expand as additional C# fundamentals are practiced.

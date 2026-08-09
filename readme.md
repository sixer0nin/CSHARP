C# Fundamentals

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

## Coding conventions

- Use meaningful names and consistent indentation.
- Keep methods focused on one responsibility.
- Prefer clear, readable code over unnecessary shortcuts.
- Validate user input before using it.
- Use standard C# naming conventions such as `PascalCase` for methods and types and `camelCase` for local variables.

## Calculator Input Validation Logic

The `Dotnet Int Calc` project uses this logic to validate the user's menu selection. It first rejects empty input, then attempts to parse a numeric choice with `int.TryParse`. If the input is text, the first letter is converted to uppercase and compared with the available operation names. The `usrInpValid` Boolean records whether the input matches a supported calculation before the program continues to the appropriate branch.

```csharp
int usrInpInt;
bool usrInpValid = false;
if (!string.IsNullOrEmpty(usrInpStr))
{
	if (int.TryParse(usrInpStr, out usrInpInt))
	{
		usrInpValid = usrInpInt == optAddInt || usrInpInt == optSubInt ||
					  usrInpInt == optMultiInt || usrInpInt == optDivdInt;
	}
	else if (usrInpStr.Length == 10 && char.IsLetter(usrInpStr[0]))
	{
		char usroptLetter = char.ToUpper(usrInpStr[0]);
		usrInpValid = usroptLetter == optAdd[0] || usroptLetter == optSub[0] ||
					  usroptLetter == optMulti[0] || usroptLetter == optDivd[0];
	}
}
```

## Status

This is an evolving learning repository. Examples and notes may expand as additional C# fundamentals are practiced.

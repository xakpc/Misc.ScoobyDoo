# Misc.ScoobyDoo

A colorful solution to the ScoobyDoo coding exercise in C# / .NET 10.

## The task

Print the numbers 1 through 100, except:

- print `Scooby` if the number is divisible by 5,
- print `Doo` if it is divisible by 7,
- print `ScoobyDoo` if it is divisible by both.

## The solution

All the code is in [`Xakpc.Misc.ScoobyDoo/Program.cs`](Xakpc.Misc.ScoobyDoo/Program.cs). A pattern-matching `switch` on both remainders picks the word:

```csharp
static string Translate(int n) => (n % 5, n % 7) switch
{
    (0, 0) => "ScoobyDoo",
    (0, _) => "Scooby",
    (_, 0) => "Doo",
    _ => n.ToString(),
};
```

A separate `Paint` function colors the output with [Spectre.Console](https://spectreconsole.net/): orange for Scooby, aqua for Doo, and both in bold for ScoobyDoo. A Figlet banner is printed at the top.

## Run

Requires the .NET 10 SDK.

```sh
dotnet run --project Xakpc.Misc.ScoobyDoo
```

## Video

[`video-demo-squeezed.mp4`](video-demo-squeezed.mp4) is a narrated screen recording of the solution being coded.

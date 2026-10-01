using Spectre.Console;

AnsiConsole.Write(new FigletText("ScoobyDoo").Color(Color.Orange1));

for (var n = 1; n <= 100; n++)
{
    AnsiConsole.MarkupLine(Paint(Translate(n)));
}

static string Translate(int n) => (n % 5, n % 7) switch
{
    (0, 0) => "ScoobyDoo",
    (0, _) => "Scooby",
    (_, 0) => "Doo",
    _ => n.ToString(),
};

static string Paint(string word) => word switch
{
    "ScoobyDoo" => "[bold orange1]Scooby[/][bold aqua]Doo[/]",
    "Scooby" => "[orange1]Scooby[/]",
    "Doo" => "[aqua]Doo[/]",
    _ => $"[grey]{word}[/]",
};

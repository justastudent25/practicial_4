int position = 1;

var nazvania = new List<string>()
{
    "  Выпить кофе\n  Выпить таблетки\n", "  Выжить\n"
};

var opisania = new List<List<string>>();
opisania.Add(new List<string>()
{
    "Утро начинается и лучше бы не заканчивалось с кофе",
    "Good for health, bad for study"
});
opisania.Add(new List<string>() { "Очень постараться для этого" });

var dati = new List<string>()
{
    "20.10.2022",
    "21.10.2022"
};
int datanow = 1;

void ChangeCursorPosition(int position)
{
    Console.SetCursorPosition(0, position);
    Console.WriteLine("->");
}

void ShowOpisanie()
{
    Console.Clear();
    Console.WriteLine("Подробнее:\n" + opisania[datanow][position - 1]);
    while (Console.ReadKey().Key != ConsoleKey.Backspace)
    {
        continue;
    }
}

void ChangeDay(int index_date)
{
    Console.WriteLine(dati[index_date]);
}

while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    if ((key.Key == ConsoleKey.UpArrow) && (position > 1))
    {
        position--;
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        if (position < (nazvania[datanow].Split(new char[] { '\n' })).Count())
        {
            position++;
        }
    }
    else if (key.Key == ConsoleKey.RightArrow)
    {
        if ((datanow + 1) < dati.Count())
        {
            datanow++;
        }
    }
    else if (key.Key == ConsoleKey.LeftArrow)
    {
        if (datanow > 0)
        {
            datanow--;
        }
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        ShowOpisanie();
    }
    else if (key.Key == ConsoleKey.Escape)
    {
        break;
    }

    Console.Clear();
    ChangeDay(datanow);
    Console.WriteLine(nazvania[datanow]);
    ChangeCursorPosition(position);
}

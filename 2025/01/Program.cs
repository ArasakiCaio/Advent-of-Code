// Parte 1

void Parte1(string filename)
{
    string[] input = File.ReadAllLines(filename);
    int dial = 50;
    int count = 0;

    foreach (string str in input)
    {
        string direction = str.Substring(0, 1);
        string value;

        value = str.Substring(1);

        int intValue = Int32.Parse(value);

        Console.WriteLine($"Dial: {dial}\nRotation: {direction}\nValue: {intValue}");

        if(String.Compare(direction, "R") == 0)
        {
            dial += intValue;

            dial %= 100;
        }
        if(String.Compare(direction, "L") == 0)
        {
            dial -= intValue;

            while(dial < 0)
            {
                dial += 100;
            }
        }

        if(dial == 0)
        {
            count++;
        }

        Console.WriteLine($"Resultado: {dial}\n");

    }

    Console.WriteLine($"\nVezes que dial == 0: {count}");
}

Parte1("input.txt");

// Parte 2
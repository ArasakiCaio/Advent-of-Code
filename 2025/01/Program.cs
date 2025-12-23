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
    }

    Console.WriteLine($"Vezes que dial == 0: {count}");
}

// Parte 2

void Parte2(string filename)
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

        if(String.Compare(direction, "R") == 0)
        {
            for(int i = 1; i <= intValue; i++)
            {
                if((dial + i) % 100 == 0)
                {
                    count++;
                }
            }

            dial += intValue;

            while(dial > 99)
            {
                dial %= 100;
            }
        }
        if(String.Compare(direction, "L") == 0)
        {
            for(int i = 1; i <= intValue; i++)
            {
                if((dial - i + 100) % 100 == 0)
                {
                    count++;
                }
            }

            dial -= intValue;

            while(dial < 0)
            {
                dial += 100;
            }
        }
    }

    Console.WriteLine($"Vezes que dial passou por 0: {count}");
}

Parte1("input.txt");
Parte2("input.txt");
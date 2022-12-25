string[] text = System.IO.File.ReadAllLines("@../../../../../input.in"); // Get all values from a file

int[] value = new int[text.Length]; // Create array of int

for(int i = 0; i < text.Length;i++)
{
    value[i] = Convert.ToInt32(text[i]); // Convert from string to int32
}

Array.Sort(value); // Sort them

void Part1()
{
    foreach (int it in value)
    {
        foreach (int it2 in value)
        {
            if (it == it2) continue;
            if (it + it2 == 2020)
            {
                Console.Write("First part: ");
                Console.WriteLine(it * it2);
                return;
            }
        }
    }
}

void Part2()
{
    foreach (int it in value)
    {
        foreach (int it2 in value)
        {
            foreach (int it3 in value)
            {
                if (it == it2 || it2 == it3 || it == it3) continue;
                if (it + it2 + it3 == 2020)
                {
                    Console.Write("Second part: ");
                    Console.WriteLine(it * it2 * it3);
                    return;
                }
            }
        }
    }
}

Part1();
Part2();
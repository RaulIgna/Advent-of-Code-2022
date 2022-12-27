// Get the elf with the most calories
var text = System.IO.File.ReadAllText("../../../../input.in"); // Get all lines as text

var line = text.Split("\r\n\r\n"); // Separate each elf

List<int> elfs = new List<int>(); 
foreach (var it in line) // For every elf
{
    var numbers = it.Split("\n");
    int sum = 0;
    foreach (var number in numbers)
    {
        int temp;
        if (Int32.TryParse(number, out temp)) // Parse the numbers to int, ignore new line
        {
            sum += temp;
        }
        elfs.Add(sum); // Add result to a list
    }
}

elfs = elfs.OrderByDescending(n => n).ToList(); // Sort the list to get the highest first

Console.WriteLine($"{elfs[0]} {elfs[0] + elfs[1] + elfs[2]}"); // Display the results



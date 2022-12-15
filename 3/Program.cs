List<string> firstList = new List<string>();
List<string> secondList = new List<string>();

List<char> chars = new List<char>();
List<char> chars2 = new List<char>();

char[] lowerLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
char[] upperLetters = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

int totalPriority;

using (var reader = new StreamReader("input.txt"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        var firstCompartment = line.Substring(0, (int)(line.Length / 2));
        var secondCompartment = line.Substring((int)(line.Length / 2), (int)(((byte)line.Length / 2)));
        firstList.Add(firstCompartment);
        secondList.Add(secondCompartment);
    }
    foreach (var item in firstList)
    {
        foreach(char letter in item)
        {
            chars.Add(letter);
        }
    }
    foreach(var item in secondList)
    {
        foreach(char letter in item)
        {
            chars2.Add(letter);
        }
    }
    var distinctLetters = chars.Union(chars2).ToArray();
    totalPriority = 0;
    for(int i = 0; i <= distinctLetters.Length - 1; i++)
    {
        Console.WriteLine(distinctLetters[i]);
        for(int j=0; j <= lowerLetters.Length - 1; j++)
        {
            if (distinctLetters[i] == lowerLetters[j])
            {
                totalPriority += j;
            }
        }
        for (int k = 0; k <= upperLetters.Length - 1; k++)
        {
            if (distinctLetters[i] == upperLetters[k])
            {
                totalPriority += k + 27;
            }
        }
    }
    Console.WriteLine("Sum of the priorities of item types: " + totalPriority);
}
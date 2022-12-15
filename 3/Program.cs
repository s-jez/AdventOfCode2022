List<string> firstList = new List<string>();
List<string> secondList = new List<string>();
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
}
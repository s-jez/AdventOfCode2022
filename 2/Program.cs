
List<string> opponentTurn = new List<string>();
List<string> myTurn = new List<string>();

int myTotalPoints = 0;

using(StreamReader streamReader = new StreamReader("input.txt"))
{
    string line;
    while((line = streamReader.ReadLine()) != null)
    {
        string[] split = line.Split(" ");
        opponentTurn.Add(split[0]);
        myTurn.Add(split[1]);
        AddSelectedPoints(split[1]);
        AddWinPoints(split[0], split[1]);
        Console.WriteLine(split[0] + " " + split[1]);
    }
    Console.WriteLine("My total points: " + myTotalPoints);
}
void AddSelectedPoints(string choice)
{
    if (choice == "X")
    {
        myTotalPoints++;
    }
    else if (choice == "Y")
    {
        myTotalPoints += 2;
    }
    else if (choice == "Z")
    {
        myTotalPoints += 3;
    }
}
void AddWinPoints(string opponentTurnChoice, string myTurnChoice)
{
    if (myTurnChoice == "X" && opponentTurnChoice == "A"  || myTurnChoice == "Y" && opponentTurnChoice == "B" || myTurnChoice == "Z" && opponentTurnChoice == "C")
    {
        myTotalPoints += 3;
    } else if(opponentTurnChoice == "A" && myTurnChoice == "Y")
    {
        myTotalPoints += 6;
    }
    else if (opponentTurnChoice == "B" && myTurnChoice == "X")
    {
        myTotalPoints += 0;
    }
    else if (opponentTurnChoice == "B" && myTurnChoice == "Z")
    {
        myTotalPoints += 6;
    }
    else if (opponentTurnChoice == "C" && myTurnChoice == "Y")
    {
        myTotalPoints += 0;
    }
    else if (opponentTurnChoice == "A" && myTurnChoice == "Z")
    {
        myTotalPoints += 0;
    }
    else if (opponentTurnChoice == "C" && myTurnChoice == "X")
    {
        myTotalPoints += 6;
    }
}
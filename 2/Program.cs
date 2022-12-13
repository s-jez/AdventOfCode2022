List<string> opponentTurn = new List<string>();
List<string> myTurn = new List<string>();

int myTotalPoints;

var TYPE_ROCK = 1;
var TYPE_PAPER = 2;
var TYPE_SCISSORS = 3;

var LOSE_POINTS = 0;
var DRAW_POINTS = 3;
var WIN_POINTS = 6;


using (StreamReader streamReader = new StreamReader("input.txt"))
{
    myTotalPoints = 0;
    string line;
    while ((line = streamReader.ReadLine()) != null)
    {
        string[] split = line.Split(" ");
        opponentTurn.Add(split[0]);
        myTurn.Add(split[1]);
        AddWinPoints(split[1]);
        AddTypePoints(split[0], split[1]);
        Console.WriteLine(split[0] + " " + split[1]);
    }
    Console.WriteLine("My total points: " + myTotalPoints);
}
void AddWinPoints(string choice)
{
    switch (choice)
    {
        case "X":
            myTotalPoints += LOSE_POINTS;
            break;
        case "Y":
            myTotalPoints += DRAW_POINTS;
            break;
        case "Z":
            myTotalPoints += WIN_POINTS;
            break;
    }
}
//
// A - ROCK, B - PAPER - C - SCISSORS
// X - LOSE, Y - DRAW, Z - WIN
//
void AddTypePoints(string opponentTurnChoice, string myTurnChoice)
{
    if (opponentTurnChoice == "A" && myTurnChoice == "X")
    {
        myTotalPoints += TYPE_SCISSORS;
    }
    else if (opponentTurnChoice == "A" && myTurnChoice == "Y")
    {
        myTotalPoints += TYPE_ROCK;
    }
    else if (opponentTurnChoice == "A" && myTurnChoice == "Z")
    {
        myTotalPoints += TYPE_PAPER;
    }
    else if (opponentTurnChoice == "B" && myTurnChoice == "X")
    {
        myTotalPoints += TYPE_ROCK;
    }
    else if (opponentTurnChoice == "B" && myTurnChoice == "Y")
    {
        myTotalPoints += TYPE_PAPER;
    }
    else if (opponentTurnChoice == "B" && myTurnChoice == "Z")
    {
        myTotalPoints += TYPE_SCISSORS;
    }
    else if (opponentTurnChoice == "C" && myTurnChoice == "X")
    {
        myTotalPoints += TYPE_PAPER;
    }
    else if (opponentTurnChoice == "C" && myTurnChoice == "Y")
    {
        myTotalPoints += TYPE_SCISSORS;
    }
    else if (opponentTurnChoice == "C" && myTurnChoice == "Z")
    {
        myTotalPoints += TYPE_ROCK;
    }
}
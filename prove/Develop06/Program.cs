// I added a level system for the user that scales based on what level they are
// (So level 3 will take less points to reach than level 10 for example)
// I also tried to just generally add more polish to certain areas and deviated from the
// class diagram provided as I found certain things that it does more complex than necessary, at least to me.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
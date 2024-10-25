using System;
using System.ComponentModel.Design;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level = 1;
    private int _levelUp;

    public GoalManager()
    {

    }
    public void Start()
    {
        Console.Clear();
        string answer = "";
        while (answer != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                CreateGoal();
            }
            else if (answer == "2")
            {
                Console.Clear();
                ListGoalDetails();
            }
            else if (answer == "3")
            {
                SaveGoals();
            }
            else if (answer == "4")
            {
                Console.Clear();
                LoadGoals();
            }
            else if (answer == "5")
            {
                RecordEvent();
            }
            else if (answer == "6")
            {
                Console.Clear();
                Console.WriteLine("Thanks for using this Goal Game Program!");
                break;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a valid selection");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        PlayerLevel();
        Console.WriteLine($"Player level: {_level}");
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        if (_goals.Count != 0)
        {
            int count = 0;
            foreach (Goal goal in _goals)
            {
                count++;
                Console.WriteLine($"{count}. {goal.GetName()}");
            }
        }
        else
        {
            Console.WriteLine("You haven't entered any goals! Load saved goals from a file or create a goal to see your progress.");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine();
        if (_goals.Count != 0)
        {
            int count = 0;
            foreach (Goal goal in _goals)
            {
                count++;
                Console.WriteLine($"{count}. [{goal.RecordEvent()}] {goal.GetDetailsString()}");
            }
            Console.WriteLine();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You haven't entered any goals! Load saved goals from a file or create a goal to see your progress.");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are: \n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        string menuChoice = Console.ReadLine();

        if (menuChoice == "1")
        {
            Console.Write("What is the name of your goal? ");
            string simpleName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string simpleDescription = Console.ReadLine();
            Console.Write("How many points should you be awarded for this? ");
            int simplePoints = int.Parse(Console.ReadLine());

            SimpleGoal simpleGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints);
            _goals.Add(simpleGoal);

            Console.WriteLine();
            Console.WriteLine("Simple goal added!");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else if (menuChoice == "2")
        {
            Console.Write("What is the name of your goal? ");
            string eternalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string eternalDescription = Console.ReadLine();
            Console.Write("How many points should you be awarded for this? ");
            int eternalPoints = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);
            _goals.Add(eternalGoal);
            Console.WriteLine();
            Console.WriteLine("Eternal goal added!");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else if (menuChoice == "3")
        {
            Console.Write("What is the name of your goal? ");
            string checklistName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string checklistDescription = Console.ReadLine();
            Console.Write("How many points should you be awarded for this? ");
            int checklistPoints = int.Parse(Console.ReadLine());
            Console.Write("How many times do you need to accomplish this goal for a bonus? ");
            int checklistNum = int.Parse(Console.ReadLine());
            Console.Write($"What is the bonus for finishing it {checklistNum} times? ");
            int checklistBonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(checklistName, checklistDescription, checklistPoints, checklistNum, checklistBonus, 0);
            _goals.Add(checklistGoal);

            Console.WriteLine();
            Console.WriteLine("Checklist goal added!");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a valid selection.");
            Console.WriteLine();
        }
    }

    public void RecordEvent()
    {
        Console.Clear();
        if (_goals.Count() > 0)
        {
            Console.WriteLine("Here are your listed goals:");
            Console.WriteLine();
            ListGoalDetails();
            Console.WriteLine();
            Console.Write("Which goal did you complete? ");
            int complete = int.Parse(Console.ReadLine());

            Goal completedGoal = _goals[complete - 1];
            if (completedGoal.RecordEvent() != "X")
            {
                completedGoal.IsComplete();
                completedGoal.RecordEvent();
                int addedScore = completedGoal.GetPoints();
                _score = _score + addedScore;
                Console.WriteLine();
                Console.WriteLine($"Nice work on your {completedGoal.GetName()} goal! You got {addedScore} points.");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("This goal has already been completed!");
            }
        }
        else
        {
            Console.WriteLine("You haven't entered any goals! Load saved goals from a file or create a goal to update your progress.");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }

    public void SaveGoals()
    {
        Console.Clear();
        if (_goals.Count() > 0)
        {
            Console.WriteLine("Please Enter a filename (with .txt or .csv as extension)");
            string file = Console.ReadLine();

            if (File.Exists(file))
            {
                Console.WriteLine();
                Console.Write($"{file} already exists. Would you like to overwrite this Goal list? (Y/N): ");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "Y")
                {
                    using (StreamWriter outputFile = new StreamWriter(file))
                    {
                        outputFile.WriteLine(_score);
                        outputFile.WriteLine(_level);
                        foreach (Goal goal in _goals)
                        {
                            outputFile.WriteLine(goal.GetStringRepresentation());
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Save Complete!");
                }
                else
                {
                    Console.WriteLine("Exited");
                }
            }
            else
            {
                Console.WriteLine($"Creating {file} and adding goals...");
                using (StreamWriter outputFile = new StreamWriter(file))
                {
                    outputFile.WriteLine(_score);
                    foreach (Goal goal in _goals)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Save Complete!");
            }
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("You don't have any listed goals! Create a goal and try again.");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }

    public void LoadGoals()
    {
        Console.Clear();
        Console.Write("Please enter the filename and extension (.txt or .csv): ");
        string file = Console.ReadLine();
        if (File.Exists(file))
        {
            _goals.Clear();
            Console.WriteLine();
            Console.WriteLine($"Loading {file}...");
            string[] lines = System.IO.File.ReadAllLines(file);

            _score = int.Parse(File.ReadLines(file).Take(1).First());
            _level = int.Parse(File.ReadLines(file).Skip(1).Take(1).First());

            lines = lines.Skip(2).ToArray();

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string goalType = parts[0];
                string goal = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (goalType == "SimpleGoal")
                {
                    string completed = parts[4];
                    SimpleGoal simpleGoal = new SimpleGoal(goal, description, points);
                    _goals.Add(simpleGoal);
                    if (completed == "True")
                    {
                        simpleGoal.IsComplete();
                    }
                }
                else if (goalType == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(goal, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int numCompleted = int.Parse(parts[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(goal, description, points, target, bonus, numCompleted);
                    _goals.Add(checklistGoal);
                
                    if (numCompleted == target)
                    {
                        checklistGoal.IsComplete();
                    }
                }
            }
            Console.WriteLine("Load complete!");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
    public int PlayerLevel()
    {
        _levelUp = _level * 300;
        if (_score >= _levelUp)
        {
            _level++;
            Console.WriteLine($"Leveled up! Now Level {_level}");
        }
        else
        {
            int nextLevel = _levelUp - _score;
            Console.WriteLine($"Next Level: In {nextLevel} points");
        }
        return _level;
    }
}
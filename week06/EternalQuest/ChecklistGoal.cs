using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Goal achieved, Bonus  points: {_bonus}");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[]";
        return $"{status} {base.GetDetailsString()} - Completed {_amountCompleted}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal | {base.GetDetailsString()} | {_amountCompleted} | {_target} | {_bonus}";
    }

    public int GetBonus()
    {
        return IsComplete() ? _bonus : 0;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }
}

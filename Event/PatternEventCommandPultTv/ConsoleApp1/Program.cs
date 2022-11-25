using System.Reflection;

namespace ConsoleApp1;

interface ICommand
{
    void Execute();
    void Undo();
}

class Tv
{
    public void On()
    {
        Console.WriteLine("ТВ включен");
    }
    public void Off()
    {
        Console.WriteLine("Тв выключен");
    }
}

class TvCommand: ICommand
{
    Tv tv;

    public TvCommand(Tv tvSet)
    {
        tv = tvSet;
    }

    public void Execute()
    {
        tv.On();
    }

    public void Undo()
    {
        tv.Off();
    }

}
class TvOnCommand : ICommand
{
    Tv tv;

    public TvOnCommand(Tv tvSet)
    {
        tv = tvSet;
    }

    public void Execute()
    {
        tv.On();
    }

    public void Undo()
    {
        tv.Off();
    }

}


class Microwave
{
    public void StartCooking(int time)
    {
        Console.WriteLine("Подогреваем еду");
        Task.Delay(time).GetAwaiter().GetResult();
    }
    public void StopCooking()
    {
        Console.WriteLine("Еда подогрета");
    }
}

class MicrowaveCommand : ICommand
{
    Microwave microwave;
    int time;
    public MicrowaveCommand(Microwave m, int t)
    {
        this.microwave = m;
        this.time = t;
    }

    public void Execute()
    {
        microwave.StartCooking(time);
        microwave.StopCooking();
    }

    public void Undo()
    {
        microwave.StopCooking();
    }

}

class Volume
{
    public const int OFF = 0;
    public const int HIGH = 20;
    private int level;

    public Volume()
    {
        level = OFF;
    }

    public void RaiseLevel()
    {
        if (level < HIGH) level++;
        Console.WriteLine($"Уровень звука {level}");
    }
    public void DropLevel()
    {
        if (level > OFF) level--;
        Console.WriteLine($"Уровень звука {level}");
    }
}
class VolumeCommand : ICommand
{
    Volume volume;
    public VolumeCommand(Volume v)
    {
        volume = v;
    }
    public void Execute()
    {
        volume.RaiseLevel();
    }

    public void Undo()
    {
        volume.DropLevel();
    }
}

class NoCommand : ICommand
{
    public void Execute()
    {
    }

    public void Undo()
    {
    }
}

interface ICommand
{
	void Execute();
	void Undo();
}
interface ICommand
{
	void Execute();
	void Undo();
}
// Класс макрокоманды
class MacroCommand : ICommand
{
	List<ICommand> commands;
	public MacroCommand(List<ICommand> coms)
	{
		commands = coms;
	}
	public void Execute()
	{
		foreach (ICommand c in commands)
			c.Execute();
	}

	public void Undo()
	{
		foreach (ICommand c in commands)
			c.Undo();
	}
}

class Programmer
{
	public void StartCoding()
	{
		Console.WriteLine("Программист начинает писать код");
	}
	public void StopCoding()
	{
		Console.WriteLine("Программист завершает писать код");
	}
}

class Tester
{
	public void StartTest()
	{
		Console.WriteLine("Тестировщик начинает тестирование");
	}
	public void StopTest()
	{
		Console.WriteLine("Тестировщик завершает тестирование");
	}
}

class Marketolog
{
	public void StartAdvertize()
	{
		Console.WriteLine("Маркетолог начинает рекламировать продукт");
	}
	public void StopAdvertize()
	{
		Console.WriteLine("Маркетолог прекращает рекламную кампанию");
	}
}

class CodeCommand : ICommand
{
	Programmer programmer;
	public CodeCommand(Programmer p)
	{
		programmer = p;
	}
	public void Execute()
	{
		programmer.StartCoding();
	}
	public void Undo()
	{
		programmer.StopCoding();
	}
}

class TestCommand : ICommand
{
	Tester tester;
	public TestCommand(Tester t)
	{
		tester = t;
	}
	public void Execute()
	{
		tester.StartTest();
	}
	public void Undo()
	{
		tester.StopTest();
	}
}

class AdvertizeCommand : ICommand
{
	Marketolog marketolog;
	public AdvertizeCommand(Marketolog m)
	{
		marketolog = m;
	}
	public void Execute()
	{
		marketolog.StartAdvertize();
	}

	public void Undo()
	{
		marketolog.StopAdvertize();
	}
}

class Manager
{
	ICommand command;
	public void SetCommand(ICommand com)
	{
		command = com;
	}
	public void StartProject()
	{
		if (command != null)
			command.Execute();
	}
	public void StopProject()
	{
		if (command != null)
			command.Undo();
	}
}
class TV
{
	public void On()
	{
		Console.WriteLine("Телевизор включен!");
	}

	public void Off()
	{
		Console.WriteLine("Телевизор выключен...");
	}
}

class TVOnCommand : ICommand
{
	TV tv;
	public TVOnCommand(TV tvSet)
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
		if (level < HIGH)
			level++;
		Console.WriteLine("Уровень звука {0}", level);
	}
	public void DropLevel()
	{
		if (level > OFF)
			level--;
		Console.WriteLine("Уровень звука {0}", level);
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

class MultiPult
{
	ICommand[] buttons;
	Stack<ICommand> commandsHistory;

	public MultiPult()
	{
		buttons = new ICommand[2];
		for (int i = 0; i < buttons.Length; i++)
		{
			buttons[i] = new NoCommand();
		}
		commandsHistory = new Stack<ICommand>();
	}

	public void SetCommand(int number, ICommand com)
	{
		buttons[number] = com;
	}

	public void PressButton(int number)
	{
		buttons[number].Execute();
		// добавляем выполненную команду в историю команд
		commandsHistory.Push(buttons[number]);
	}
	public void PressUndoButton()
	{
		if (commandsHistory.Count > 0)
		{
			ICommand undoCommand = commandsHistory.Pop();
			undoCommand.Undo();
		}
	}
}
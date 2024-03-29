﻿interface ICommand
{
	void Execute();
	void Undo();
}

// Receiver - Получатель
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

// Invoker - инициатор
class Pult
{
	ICommand command;

	public Pult() { }

	public void SetCommand(ICommand com)
	{
		command = com;
	}

	public void PressButton()
	{
		command.Execute();
	}
	public void PressUndo()
	{
		command.Undo();
	}
}
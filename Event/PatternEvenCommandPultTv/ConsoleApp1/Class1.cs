using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Pult
    {
        ICommand command;
        public Pult()
        {

        }
        
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


class MultiPult
    {
        ICommand[] buttons;
        Stack<ICommand> comandHistory;
        public MultiPult()
        {
            buttons = new ICommand[2];

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new NoCommand();
            }

            comandHistory = new Stack<ICommand>();
        }

        public void SetCommand(int number, ICommand com)
        {
            buttons[number] = com;
        }

        public void PressButton(int number)
        {
            buttons[number].Execute();
            comandHistory.Push(buttons[number]);
        }

        public void PressUndoButton()
        {
           if (comandHistory.Count > 0)
            {
                ICommand undoCommand = comandHistory.Pop();
                undoCommand.Undo();
            }
        }

    }

    class Program
    {
        public static void Main()
        {
            //Pult pult = new Pult(); 
            //Tv tv = new Tv();
            //pult.SetCommand(new TvCommand(tv));
            //pult.PressButton();
            //pult.PressUndo();

            //Microwave microwave = new Microwave();
            //pult.SetCommand(new MicrowaveCommand(microwave, 5000));
            //pult.PressButton();

            Tv tv = new Tv();
            Volume volume = new Volume();

            MultiPult mPult = new MultiPult();
            mPult.SetCommand(0, new TvOnCommand(tv));
            mPult.SetCommand(1, new VolumeCommand(volume));

            mPult.PressButton(0);

            mPult.PressButton(1);
            mPult.PressButton(1);
            mPult.PressButton(1);

            mPult.PressUndoButton();
            mPult.PressUndoButton();
            mPult.PressUndoButton();

            mPult.PressUndoButton();

            //  mPult.PressButton(0);




            Console.Read();
        }
    }


}

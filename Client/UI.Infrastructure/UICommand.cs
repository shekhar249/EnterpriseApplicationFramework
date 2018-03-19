using System;
using System.Windows.Input;

namespace UI.Infrastructure
{
   public class UICommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<object> a;
        public UICommand(Action<object> a)
        {
            this.a = a;
        }
       
        public bool CanExecute(object parameter)
        {
            return true;
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            //  throw new NotImplementedException();
            a(parameter);
        }
    }
}

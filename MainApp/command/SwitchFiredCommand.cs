using System.Windows.Input;

namespace MainApp.command
{
    public class SwitchFiredCommand: ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public Action Action { get; set; }

        public bool CanExecute(object? parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object? parameter)
        {
            //throw new NotImplementedException();
            this.Action?.Invoke();
        }
    }
}

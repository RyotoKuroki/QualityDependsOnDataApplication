using System.Windows.Input;

namespace MainApp.command
{
    public class SwitchFiredCommand: ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public Action クリック処理 { get; set; }

        public bool CanExecute(object? parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object? parameter)
        {
            //throw new NotImplementedException();
            this.クリック処理?.Invoke();
        }
    }
}

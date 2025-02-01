using System.Windows.Input;

namespace MainApp.command
{
    public class SwitchFiredCommand: ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public Action? クリック処理 { get; set; } = null;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            this.クリック処理?.Invoke();
        }
    }
}

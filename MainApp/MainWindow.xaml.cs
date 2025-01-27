using MainApp.command;
using MainApp.Model;
using System.Windows;

namespace MainApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Model
        /// <summary>データ依存モデル</summary>
        public DependsOnDataModel DataModel { get; set; } = new DependsOnDataModel();
        /// <summary>処理依存モデル</summary>
        public DependsOnMethodModel MethodModel { get; set; } = new DependsOnMethodModel();
        #endregion

        /// <summary>分かりにくい所に一括アイテム移動処理があああ！！！</summary>
        public SwitchFiredCommand SwitchFireAllTurnOnCommand { get; set; } = new SwitchFiredCommand();
        /// <summary>分かりにくい所に一括アイテム移動処理があああ！！！</summary>
        public SwitchFiredCommand SwitchFireAllTurnOffCommand { get; set; } = new SwitchFiredCommand();

        public MainWindow()
        {
            InitializeComponent();

            this.SwitchFireAllTurnOnCommand.Action = () =>
            {
                this.DataModel.SwitchFireAll(true);
                this.MethodModel.SwitchFireAll(true);
            };
            this.SwitchFireAllTurnOffCommand.Action = () =>
            {
                this.DataModel.SwitchFireAll(false);
                this.MethodModel.SwitchFireAll(false);
            };

            this.DataContext = this;
        }
    }
}
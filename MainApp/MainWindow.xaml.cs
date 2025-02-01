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
        public SwitchFiredCommand 点火コマンド { get; set; } = new SwitchFiredCommand();
        /// <summary>分かりにくい所に一括アイテム移動処理があああ！！！</summary>
        public SwitchFiredCommand 消火コマンド { get; set; } = new SwitchFiredCommand();

        public MainWindow()
        {
            InitializeComponent();

            this.点火コマンド.クリック処理 = () =>
            {
                this.DataModel.一括点滅(true);
                this.MethodModel.一括点滅(true);
            };
            this.消火コマンド.クリック処理 = () =>
            {
                this.DataModel.一括点滅(false);
                this.MethodModel.一括点滅(false);
            };

            this.DataContext = this;
        }
    }
}
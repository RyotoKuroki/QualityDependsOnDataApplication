namespace MainApp.Model
{
    public class DependsOnMethodModel : BaseModel
    {
        public DependsOnMethodModel() : base()
        {
            // ロウソクAのクリック処理
            this.SwitchFiredACommand.Action = () => {
                this.SwitchFiredA();  //炎の点滅
                this.SetCountLabel(); //本数計算
            };

            // ロウソクBのクリック処理
            this.SwitchFiredBCommand.Action = () => {
                this.SwitchFiredB();  //炎の点滅
                this.SetCountLabel(); //本数計算
            };

            // ロウソクCのクリック処理
            this.SwitchFiredCCommand.Action = () => {
                this.SwitchFiredC();  //炎の点滅
                this.SetCountLabel(); //本数計算
            };

            this.SetCountLabel();
        }
    }
}
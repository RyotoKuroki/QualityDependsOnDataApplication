namespace MainApp.Model
{
    public class DependsOnDataModel: BaseModel
    {
        public DependsOnDataModel(): base()
        {
            // ロウソクAのクリック処理
            this.SwitchFiredACommand.Action = () => {
                this.SwitchFiredA();  //炎の点滅
            };

            // ロウソクBのクリック処理
            this.SwitchFiredBCommand.Action = () => {
                this.SwitchFiredB();  //炎の点滅
            };

            // ロウソクCのクリック処理
            this.SwitchFiredCCommand.Action = () => {
                this.SwitchFiredC();  //炎の点滅
            };
        }

        /// <summary>本数計算</summary>
        public override string FiredCountLabel
        {
            get
            {
                var count = this.CalcFireCount();
                return $"{count.ToString()}本";
            }
        }
    }
}
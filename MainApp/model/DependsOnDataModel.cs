namespace MainApp.Model
{

    /// <summary>データ依存クラス</summary>
    public class DependsOnDataModel: BaseModel {

        /// <summary>コンストラクタ</summary>
        public DependsOnDataModel(): base() {

            // イベント処理をハンドル
            ロウソクA.クリック処理 = () => {
                点滅A();
            };

            // イベント処理をハンドル
            ロウソクB.クリック処理 = () => {
                点滅B();
            };

            // イベント処理をハンドル
            ロウソクC.クリック処理 = () => {
                点滅C();
            };
        }

        /// <summary>本数</summary>
        public override string 本数ラベル {
            get {
                return $"{本数計算().ToString()}本";
            }
        }
    }
}








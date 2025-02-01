namespace MainApp.Model
{

    /// <summary>処理依存クラス</summary>
    public class DependsOnMethodModel : BaseModel {

        /// <summary>コンストラクタ</summary>
        public DependsOnMethodModel() : base() {

            // イベント処理をハンドル
            ロウソクA.クリック処理 = () => {
                点滅A();
                本数をセット();
            };

            // イベント処理をハンドル
            ロウソクB.クリック処理 = () => {
                点滅B();
                本数をセット();
            };

            // イベント処理をハンドル
            ロウソクC.クリック処理 = () => {
                点滅C();
                本数をセット();
            };

            本数をセット();
        }
    }
}















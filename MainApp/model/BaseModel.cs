﻿using MainApp.command;
using System.ComponentModel;

namespace MainApp.Model
{
    public class BaseModel: INotifyPropertyChanged
    {
        /// <summary>コンストラクタ</summary>
        public BaseModel() {
            this.ロウソクA.クリック処理 = () => this.炎A = !this.炎A;
            this.ロウソクB.クリック処理 = () => this.炎B = !this.炎B;
            this.ロウソクC.クリック処理 = () => this.炎C = !this.炎C;
        }

        /// <summary>炎A</summary>
        public bool 炎A
        {
            get
            {
                return this._炎A;
            }
            set
            {
                this._炎A = value;
                OnPropertyChanged(nameof(炎A));

                if (this.PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(本数ラベル)));
            }
        }
        private bool _炎A = false;

        /// <summary>炎B</summary>
        public bool 炎B
        {
            get
            {
                return this._炎B;
            }
            set
            {
                this._炎B = value;
                OnPropertyChanged(nameof(炎B));

                if (this.PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(本数ラベル)));
            }
        }
        private bool _炎B = false;

        /// <summary>炎C</summary>
        public bool 炎C
        {
            get
            {
                return this._炎C;
            }
            set
            {
                this._炎C = value;
                OnPropertyChanged(nameof(炎C));

                if (this.PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(本数ラベル)));
            }
        }
        private bool _炎C = false;

        /// <summary>炎の数</summary>
        public virtual string 本数ラベル {
            get
            {
                return this._本数ラベル;
            }
            set
            {
                this._本数ラベル = value;
                OnPropertyChanged(nameof(本数ラベル));
            }
        }
        private string _本数ラベル = string.Empty;

        /// <summary>炎Aの点滅処理</summary>
        protected void 点滅A()
        {
            this.炎A = !this.炎A;
        }
        /// <summary>炎Bの点滅処理</summary>
        protected void 点滅B()
        {
            this.炎B = !this.炎B;
        }
        /// <summary>炎Cの点滅処理</summary>
        protected void 点滅C()
        {
            this.炎C = !this.炎C;
        }

        /// <summary>炎の数の編集処理</summary>
        protected void 本数をセット()
        {
            this.本数ラベル = $"{this.本数計算().ToString()}本";
        }

        /// <summary>炎の数の計算処理</summary>
        /// <returns></returns>
        protected int 本数計算()
        {
            var count = Convert.ToInt32(this.炎A)
                      + Convert.ToInt32(this.炎B)
                      + Convert.ToInt32(this.炎C);
            return count;
        }

        /// <summary>炎の一括点滅処理</summary>
        /// <param name="isFired">点火/消化</param>
        public void 一括点滅(bool isFired)
        {
            this.炎A = isFired;
            this.炎B = isFired;
            this.炎C = isFired;
        }

        /// <summary>炎の数の産出処理</summary>
        public SwitchFiredCommand ロウソクA { get; set; } = new SwitchFiredCommand();
        /// <summary>炎の数の産出処理</summary>
        public SwitchFiredCommand ロウソクB { get; set; } = new SwitchFiredCommand();
        /// <summary>炎の数の産出処理</summary>
        public SwitchFiredCommand ロウソクC { get; set; } = new SwitchFiredCommand();

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

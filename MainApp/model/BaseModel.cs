using MainApp.command;
using System.ComponentModel;

namespace MainApp.Model
{
    public class BaseModel: INotifyPropertyChanged
    {
        public BaseModel() {
            this.SwitchFiredACommand.Action = () => this.IsFiredA = !this.IsFiredA;
            this.SwitchFiredBCommand.Action = () => this.IsFiredB = !this.IsFiredB;
            this.SwitchFiredCCommand.Action = () => this.IsFiredC = !this.IsFiredC;
        }

        /// <summary>炎</summary>
        public bool IsFiredA
        {
            get
            {
                return this.isFiredA;
            }
            set
            {
                this.isFiredA = value;
                OnPropertyChanged(nameof(IsFiredA));

                if (this.PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(FiredCountLabel)));
            }
        }
        private bool isFiredA = false;

        /// <summary>炎</summary>
        public bool IsFiredB
        {
            get
            {
                return this.isFiredB;
            }
            set
            {
                this.isFiredB = value;
                OnPropertyChanged(nameof(IsFiredB));

                if (this.PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(FiredCountLabel)));
            }
        }
        private bool isFiredB = false;

        /// <summary>炎</summary>
        public bool IsFiredC
        {
            get
            {
                return this.isFiredC;
            }
            set
            {
                this.isFiredC = value;
                OnPropertyChanged(nameof(IsFiredC));

                if (this.PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(FiredCountLabel)));
            }
        }
        private bool isFiredC = false;

        /// <summary>炎の数</summary>
        public virtual string FiredCountLabel {
            get
            {
                return this.firedCountLabel;
            }
            set
            {
                this.firedCountLabel = value;
                OnPropertyChanged(nameof(FiredCountLabel));
            }
        }
        private string firedCountLabel = string.Empty;

        protected void SwitchFiredA()
        {
            this.IsFiredA = !this.IsFiredA;
        }
        protected void SwitchFiredB()
        {
            this.IsFiredB = !this.IsFiredB;
        }
        protected void SwitchFiredC()
        {
            this.IsFiredC = !this.IsFiredC;
        }

        protected void SetCountLabel()
        {
            this.FiredCountLabel = $"{this.CalcFireCount().ToString()}本";
        }

        protected int CalcFireCount()
        {
            var count = Convert.ToInt32(this.IsFiredA)
                      + Convert.ToInt32(this.IsFiredB)
                      + Convert.ToInt32(this.IsFiredC);
            return count;
        }

        public void SwitchFireAll(bool isFired)
        {
            this.IsFiredA = isFired;
            this.IsFiredB = isFired;
            this.IsFiredC = isFired;
        }

        /// <summary>炎の数の産出処理</summary>
        public SwitchFiredCommand SwitchFiredACommand { get; set; } = new SwitchFiredCommand();
        /// <summary>炎の数の産出処理</summary>
        public SwitchFiredCommand SwitchFiredBCommand { get; set; } = new SwitchFiredCommand();
        /// <summary>炎の数の産出処理</summary>
        public SwitchFiredCommand SwitchFiredCCommand { get; set; } = new SwitchFiredCommand();

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

using System;
using System.Windows.Input;
using Windows.ApplicationModel;
using CalculatorSample.Helpers;

namespace CalculatorSample.ViewModels
{
    public class MainViewModel : Observable
    {
        private long _number;

        public MainViewModel()
        {
            if(!DesignMode.DesignModeEnabled)
                OnInit();
        }

        private void OnInit()
        {
            ButtonClickCommand = new RelayCommand<string>(ExecuteButtonClickCommand);
        }

        private void ExecuteButtonClickCommand(string para)
        {
            switch (para)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    var strNum = Number.ToString();
                    strNum += para;
                    Number = Convert.ToInt64(strNum);
                    break;
                case "c":
                    Number = 0;
                    break;
                case "b":
                    var strNum2 = Number.ToString();
                    strNum2 = strNum2.Substring(0, strNum2.Length - 1);
                    Number = Convert.ToInt64(strNum2);
                    break;
            }
        }

        public long Number
        {
            get { return _number; }
            set { Set(ref _number ,value); }
        }

        public ICommand ButtonClickCommand { get; set; }
    }
}

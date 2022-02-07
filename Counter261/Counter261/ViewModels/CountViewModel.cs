using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Counter261.ViewModels
{
    public class CountViewModel : BindableObject
    {
        public CountViewModel()
        {
            IncreaseCount = new Command(OnIncreaseCount);
        }
        public ICommand IncreaseCount { private set; get; }

        public void OnIncreaseCount()
        {
            count++;
            CountDisplay = $"You clicked {count} time(s).";
        }
        private int count = 0;

        private string countDisplay;
        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value != countDisplay)
                {
                    countDisplay = value;
                    OnPropertyChanged("CountDisplay");
                }
            }
        }
    }
}

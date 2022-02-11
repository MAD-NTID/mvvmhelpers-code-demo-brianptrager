using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Counter261.ViewModels
{
    public class CountViewModel : ViewModelBase
    {
        //public ObservableRangeCollection<string> People { get; }
        public Command IncreaseCount { get; }
        public CountViewModel()
        {
            IncreaseCount = new Command<string>(OnIncreaseCount);
            //Title = "Super Duper Counter";
            //HasIzzy = true;
            //People = new ObservableRangeCollection<string>();
            //CallServerCommand = new AsyncCommand(CallServer);
        }
        
        //public ICommand CallServerCommand { get; set; }

        //async Task CallServer()
        //{
        //    var people = new List<string>() { "Babe Ruth", "Jackie Robinson", "Hank Aaron" };
        //    await Task.Run(() => People.AddRange(people)); //Notification of collection only occurs ONCE!
        //}

        public void OnIncreaseCount(string num)
        {
            if (int.TryParse(num, out int validNum))
            {
                count += validNum;
                CountDisplay = $"You clicked {count} time(s).";
            }
        }
        private int count = 0;

        private string countDisplay;
        public string CountDisplay
        {
            get => countDisplay;
            set => SetProperty(ref countDisplay, value);
        }
    }
}

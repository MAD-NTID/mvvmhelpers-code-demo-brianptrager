using Counter261.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Counter261
{
    public partial class MainPage : ContentPage
    {
        public CountViewModel CVM => ((CountViewModel)BindingContext);
        public MainPage()
        {
            InitializeComponent();

            CVM.IncreaseCount.Execute("3");
        }

        
    }
}

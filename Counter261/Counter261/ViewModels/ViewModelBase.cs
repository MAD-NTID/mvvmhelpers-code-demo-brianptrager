using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Counter261.ViewModels
{
    public class ViewModelBase : BaseViewModel
    {
        public ViewModelBase()
        {
            //Do stuff like connect to server
            //Get results from queries
        }

        private bool hasIzzy;
        public bool HasIzzy 
        { 
            get => hasIzzy; set => SetProperty(ref hasIzzy, value); 
        }
    }
}

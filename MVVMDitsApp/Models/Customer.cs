using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;


namespace MVVMDitsApp.Models
{

    public class Customer :INotifyPropertyChanged
    {
        private string _Name;
        /// <summary>
        /// Get or set Customer's name
        /// </summary>
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }

        public Customer(string name)
        {
            _Name = name;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

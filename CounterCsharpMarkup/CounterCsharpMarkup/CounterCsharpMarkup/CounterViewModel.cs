using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CounterCsharpMarkup
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private int _counter;

        public int Counter
        {
            get { return _counter; }
            set { _counter = value; OnPropertyChange(nameof(Counter)); }
        }

        public Command IncreaseCommand { get; set; }

        public CounterViewModel()
        {
            Counter = 0;
            IncreaseCommand = new Command(Increase);
        }

        private void Increase()
        {
            ++Counter;
        }
    }
}

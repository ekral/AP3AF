using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobilniAplikace2
{
    public partial class MainPage : ContentPage
    {
        private int counter = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ++counter;
            mujLabel.Text = counter.ToString();
        }
    }
}

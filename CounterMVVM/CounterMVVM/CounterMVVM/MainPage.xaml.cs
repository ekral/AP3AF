﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CounterMVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new CounterViewModel();
            InitializeComponent();
        }
    }
}

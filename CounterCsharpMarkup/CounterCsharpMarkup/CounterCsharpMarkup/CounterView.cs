using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace CounterCsharpMarkup
{
    public class CounterView : ContentPage
    {
        public CounterView()
        {
            var vm = new CounterViewModel();
            BindingContext = vm;

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }.Bind(nameof(vm.Counter)),
                    new Button { Text = "Zvys"}.Bind(nameof(vm.IncreaseCommand))
                }
            };
        }
    }
}
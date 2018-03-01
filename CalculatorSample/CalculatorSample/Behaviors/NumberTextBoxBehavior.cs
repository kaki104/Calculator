using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml.Controls;
using Microsoft.Xaml.Interactivity;

namespace CalculatorSample.Behaviors
{
    public class NumberTextBoxBehavior : Behavior<TextBox>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            //AssociatedObject.KeyUp += AssociatedObject_KeyUp;
            AssociatedObject.TextChanged += AssociatedObject_TextChanged;
        }

        private void AssociatedObject_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        //private void AssociatedObject_KeyUp(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        //{
        //    switch (e.Key)
        //    {
        //        case VirtualKey.Number0:
        //        case VirtualKey.Number1:
        //        case VirtualKey.Number2:
        //        case VirtualKey.Number3:
        //        case VirtualKey.Number4:
        //        case VirtualKey.Number5:
        //        case VirtualKey.Number6:
        //        case VirtualKey.Number7:
        //        case VirtualKey.Number8:
        //        case VirtualKey.Number9:
        //        case VirtualKey.Back:
        //            var numberText = AssociatedObject.Text;
        //            if (string.IsNullOrEmpty(numberText)) return;

        //            var number = int.Parse(numberText.Replace(",", ""));
        //            var formatString = string.Format("{0:N0}", number);
        //            if (formatString != number.ToString())
        //            {
        //                AssociatedObject.Text = formatString;
        //                AssociatedObject.SelectionStart = AssociatedObject.Text.Length;
        //            }
        //            break;
        //    }
        //}

        protected override void OnDetaching()
        {
            AssociatedObject.TextChanged -= AssociatedObject_TextChanged;
            //AssociatedObject.KeyUp -= AssociatedObject_KeyUp;
            base.OnDetaching();
        }
    }
}

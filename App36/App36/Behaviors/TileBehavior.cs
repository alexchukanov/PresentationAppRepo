using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App36
{
    public class TileBehavior : Behavior<Image>
    {
        protected override void OnAttachedTo(Image image)
        {
            image.Focused += OnImageFocused;
            base.OnAttachedTo(image);
        }

        
        protected override void OnDetachingFrom(Image image)
        {
            image.Focused -= OnImageFocused;
            base.OnDetachingFrom(image);
        }
        

        void OnImageFocused(object sender, FocusEventArgs args)
        {
            /*
            double result;
            bool isValid = double.TryParse(args.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
            */

            ((Image)sender).RelScaleTo(0.5, 200, Easing.CubicOut);
        }

    }
}

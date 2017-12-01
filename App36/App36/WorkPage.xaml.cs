using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App36
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkPage : ContentPage
    {
        public WorkPage()
        {
            InitializeComponent();

            lbDescription.Text =
 "Illy Locator lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut luctus, mi nec fermentum congue, turpis nibh porttitor ex, sed commodo neque eros non libero." +
 "\n\nDonec mauris felis, malesuada nec consectetur et, pharetra in ante. Praesent nec hendrerit purus. Ut vel nunc id nisl volutpat porta." +
 "\n\nSTORE LOCATOR: Cras in convallis ipsum. Integer id sollicitudin ex. Ut sed iaculis nisl. Vestibulum sit amet neque nec eros interdum laoreet nec vitae justo." +
"\n\nTROVA INDICAZIONE: Maecenas scelerisque finibus nisl, a iaculis mauris fermentum sed. Pellentesque faucibus, turpis quis ultrices facilisis, metus eros vulputate augue, sit amet sodales nisl lacus ut massa." +
"\n\nEVENTY: Pellentesque vitae dolor nulla. Nullam ultricies imperdiet nisl, interdum placerat dolor posuere a." +
"\n\nCURIOSITA: Nunc tempor sed sapien nec dictum. Morbi eleifend tellus vitae nunc tincidunt viverra.Duis vitae justo eget purus bibendum dictum quis feugiat turpis." +
"\n\nPREFIRITY: Curabitur ultrices purus ut ipsum ullamcorper, sit amet faucibus nisl commodo. Nulla aliquet ante eu leo tincidunt, a tempor nibh maximus." +
"\n\nSHOP: Vestibulum varius bibendum metus. Aliquam erat volutpat. Vestibulum dignissim quam at ligula cursus iaculis." +
"\n\nHELP: Aliquam malesuada nulla lacus, auctor interdum magna gravida molestie." +
"\n\nSviluppatta nel 2015";
        }
        
        private async void OnMoreScreenTapped(object sender, EventArgs e)
        {
            await ((Image)sender).FadeTo(0.6);
            await Navigation.PushAsync(new CouruselScreenPage(true));
            await ((Image)sender).FadeTo(1);
        }

        private async void OnWorkScreenTapped(object sender, EventArgs e)
        {
            await((Image)sender).FadeTo(0.8);
            await Navigation.PushAsync(new CouruselScreenPage(true));
            await((Image)sender).FadeTo(1);
        }

        private void OnCompanyLogoTapped(object sender, EventArgs e)
        {

        }
    }
}
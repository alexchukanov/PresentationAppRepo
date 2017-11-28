using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App36
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CouruselScreenPage : ContentPage
    {
        public ObservableCollection<WorkScreen> WorkScreenList { get; set; }

        int screenNum = 0;
        
        public CouruselScreenPage()
        {
            InitializeComponent();
            
            var workScreenList = new ObservableCollection<WorkScreen>
            {
                    new WorkScreen
                    {
                        ImageUrl = "WorkScreen1.png",
                        Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut luctus, mi nec fermentum congue, turpis nibh porttitor ex, sed commodo neque eros non libero."
                    },
                    new WorkScreen
                    {
                        ImageUrl = "WorkScreen1.png",
                        Note = "Vestibulum sit amet neque nec eros interdum laoreet nec vitae justo. Maecenas scelerisque finibus nisl, a iaculis mauris fermentum sed."
                    },
                    new WorkScreen
                    {
                        ImageUrl = "WorkScreen1.png",
                        Note = "Pellentesque faucibus, turpis quis ultrices facilisis, metus eros vulputate augue, sit amet sodales nisl lacus ut massa. "
                    },
                    new WorkScreen
                    {
                        ImageUrl = "WorkScreen1.png",
                        Note = "Donec tincidunt arcu vitae est condimentum lacinia. Nullam at sem eu purus congue porta eget vel lorem. Aenean gravida diam tincidunt consequat tincidunt. Sed vel vestibulum eros, quis lacinia tortor."
                    }
            };

            WorkScreenList = workScreenList;

            cwWorkScreen.ItemsSource = WorkScreenList;
            screenNum = WorkScreenList.Count();
        }
       

        private void btBack_Tapped(object sender, EventArgs e)
        {
           if (cwWorkScreen.Position > 0)
           {               
                --cwWorkScreen.Position;
           }
        }

        private void btForward_Tapped(object sender, EventArgs e)
        {
            if (cwWorkScreen.Position < screenNum - 1)
            {
                ++cwWorkScreen.Position;
            }
        }
    }
}
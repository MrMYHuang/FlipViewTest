using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FlipViewTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<GridViewPage> gvps = new List<GridViewPage>();
        public MainPage()
        {
            this.InitializeComponent();

            var strs = new List<string>();
            var strs2 = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                strs.Add("" + i);
                strs2.Add("" + (i + 20));
            }

            var gvp = new GridViewPage(strs);
            var gvp2 = new GridViewPage(strs2);
            gvps.Add(gvp);
            gvps.Add(gvp2);
        }
    }
}

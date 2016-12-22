using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FlipViewTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<GridViewPage> gvps = new ObservableCollection<GridViewPage>();
        public MainPage()
        {
            this.InitializeComponent();
            init();
        }

        public async Task<int> init()
        {
            // Simulate some processing.
            await Task.Delay(1000);

            var strs = new ObservableCollection<string>();
            var strs2 = new ObservableCollection<string>();
            for (int i = 0; i < 20; i++)
            {
                strs.Add("" + i);
                strs2.Add("" + (i + 20));
            }

            var gvp = new GridViewPage(strs);
            var gvp2 = new GridViewPage(strs2);
            gvps.Add(gvp);
            gvps.Add(gvp2);

            return 0;
        }
    }
}

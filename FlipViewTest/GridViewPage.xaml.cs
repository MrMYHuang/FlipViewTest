using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FlipViewTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GridViewPage : Page
    {
        ObservableCollection<string> strs = new ObservableCollection<string>();
        public GridViewPage(ObservableCollection<string> _strs)
        {
            this.InitializeComponent();
            foreach(var s in _strs)
            {
                strs.Add(s);
            }
        }
    }
}

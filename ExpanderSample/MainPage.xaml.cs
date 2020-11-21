using System.Collections.ObjectModel;
using Xamarin.Forms;
namespace ExpanderSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Items.Add("Apple");
            Items.Add("Pear");
            Items.Add("Banana");
            Items.Add("Orange");
            Items.Add("Pineapple");
            Items.Add("Grapes");
        }

        public ObservableCollection<string> Items { get; private set; } = new ObservableCollection<string>();
    }
}

using Notes.Views;
using Xamarin.Forms;

namespace Notes
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(NodeAddingPage), typeof(NodeAddingPage));
        }
    }
}
using CommunityToolkit.Maui.Views;


namespace PlantMonitor
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            this.ShowPopup(new AddItemPopup());
        }
    }

}

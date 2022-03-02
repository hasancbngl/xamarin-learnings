
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();
            var layout = new StackLayout
            {
                Spacing = 40,
                Padding = new Thickness(20),
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.Green
            };

            layout.Children.Add(new Label { Text = "Labeel" });

            Content = layout;
        }
    }
}
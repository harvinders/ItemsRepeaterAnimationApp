using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Animation;
using ItemsRepeaterAnimationApp.Services;
using ItemsRepeaterAnimationApp.ViewModels;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ItemsRepeaterAnimationApp.Views
{
    public sealed partial class StoryView : UserControl
    {
        public StoryViewModel ViewModel { get; set; } = new StoryViewModel();

        public StoryView()
        {
            this.InitializeComponent();
        }

        protected override void OnTapped(TappedRoutedEventArgs e)
        {
            base.OnTapped(e);
            ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("forwardAnimation", Image);

            NavigationService.Navigate<DetailPage>(ViewModel);
        }

    }
}

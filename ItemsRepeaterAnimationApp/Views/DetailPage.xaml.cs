using System;

using ItemsRepeaterAnimationApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace ItemsRepeaterAnimationApp.Views
{
    public sealed partial class DetailPage : Page
    {
        public StoryViewModel ViewModel { get; private set; }

        public DetailPage()
        {
            InitializeComponent();

            Image.ImageOpened += (sender, args) =>
            {
                var animation = ConnectedAnimationService.GetForCurrentView().GetAnimation("forwardAnimation");
                animation?.TryStart(Image);
            };
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            ViewModel = e.Parameter as StoryViewModel;
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("backAnimation", Image);
        }
    }
}

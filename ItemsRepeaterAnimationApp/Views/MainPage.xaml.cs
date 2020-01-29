using Windows.UI.Xaml;
using ItemsRepeaterAnimationApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using ItemsRepeaterAnimationApp.Services;

namespace ItemsRepeaterAnimationApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();
        private static int _index = 0;
        public MainPage()
        {
            InitializeComponent();

            ItemsRepeater.Loaded += (sender, args) =>
            {
                var animation = ConnectedAnimationService.GetForCurrentView().GetAnimation("backAnimation");
                if (animation != null)
                {
                    var element = ItemsRepeater.GetOrCreateElement(_index);
                    // ensure the item is given a valid position
                    element.UpdateLayout();


                    element.StartBringIntoView(new BringIntoViewOptions()
                    {

                    });

                    var image = element.GetFirstDescendantOfType<Image>();
                    animation.TryStart(image);

                }
            };
        }


        private void ItemsRepeater_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            base.OnTapped(e);

            var clickedElement = (e.OriginalSource as UIElement);

            var storyView = clickedElement.GetFirstAncestorOfType<StoryView>();

            _index = ItemsRepeater.GetElementIndex(storyView);

            //var image = storyView.GetFirstDescendantOfType<Image>();

            //ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("forwardAnimation", image);

            //NavigationService.Navigate<DetailPage>(ViewModel);

        }
    }
}

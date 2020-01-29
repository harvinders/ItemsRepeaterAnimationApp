namespace ItemsRepeaterAnimationApp.ViewModels
{
    public class StoryViewModel
    {
        public StoryViewModel(string name)
        {
            Name = name;
        }
        public StoryViewModel()
        {
        }
        public string Name { get; set; }

        public string Image
        {
            get => $"ms-appx:///Assets/Nature-{Name}.jpg";
        }
    }
}

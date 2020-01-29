using System;
using System.Collections.Generic;
using ItemsRepeaterAnimationApp.Helpers;

namespace ItemsRepeaterAnimationApp.ViewModels
{
    public class MainViewModel : Observable
    {
        public List<StoryViewModel> ViewModels { get; set; }
        public MainViewModel()
        {
            ViewModels = new List<StoryViewModel>()
            {
                new StoryViewModel("1"),
                new StoryViewModel("2"),
                new StoryViewModel("3"),
                new StoryViewModel("4"),
                new StoryViewModel("5"),
                new StoryViewModel("6"),
                new StoryViewModel("7"),
                new StoryViewModel("8"),
                new StoryViewModel("9"),
                new StoryViewModel("10"),
                new StoryViewModel("11"),
                new StoryViewModel("12"),
                new StoryViewModel("13")
            };
        }
    }
}

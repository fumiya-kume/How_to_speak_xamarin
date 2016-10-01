using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using HowToSpeak.Services;
using Prism.Services;
using Xamarin.Forms;

namespace HowToSpeak.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ICommand SpeechClick { get; set; }

        public MainPageViewModel()
        {
            SpeechClick = new DelegateCommand(() =>
            {
                Xamarin.Forms.DependencyService.Get<ISpeech>().Speak("Hello World");
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}

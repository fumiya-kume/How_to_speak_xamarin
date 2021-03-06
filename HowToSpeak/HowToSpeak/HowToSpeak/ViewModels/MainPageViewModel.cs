﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using HowToSpeak.Services;

namespace HowToSpeak.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        private string _speechText;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string SpeechText
        {
            get { return _speechText; }
            set { SetProperty(ref _speechText, value); }
        }

        public ICommand SpeechClick { get; set; }

        public MainPageViewModel()
        {
            SpeechClick = new DelegateCommand(() =>
            {
                Xamarin.Forms.DependencyService.Get<ISpeech>().Speak(SpeechText);
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

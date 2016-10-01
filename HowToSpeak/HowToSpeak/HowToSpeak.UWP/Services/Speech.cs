using System;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml.Controls;
using HowToSpeak.Services;
using HowToSpeak.UWP.Services;

[assembly: Xamarin.Forms.Dependency(typeof(Speech))]
namespace HowToSpeak.UWP.Services
{
    public class Speech : ISpeech
    {
        public async void Speak(string text)
        {
            var mediaelement = new MediaElement();
            var voice = await new SpeechSynthesizer().SynthesizeTextToStreamAsync(text);
            mediaelement.SetSource(voice, voice.ContentType);
            mediaelement.Play();
        }
    }
}

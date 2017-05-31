using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.SpeechRecognition;
using Windows.UI.Xaml;

namespace ResidenceInnEnjoyYourStay.Models
{
   public class Microphone
    {
        SpeechRecognizer recognizer;
        String lokacija;
        async void OnListenAsync(object sender, RoutedEventArgs e)
        {
            this.recognizer = new SpeechRecognizer();
            await this.recognizer.CompileConstraintsAsync();

            this.recognizer.Timeouts.InitialSilenceTimeout = TimeSpan.FromSeconds(5);
            this.recognizer.Timeouts.EndSilenceTimeout = TimeSpan.FromSeconds(20);

            this.recognizer.UIOptions.AudiblePrompt = "Recite grad koji zelite";
            this.recognizer.UIOptions.ExampleText = "Sarajevo, Zagreb, Split...";
            this.recognizer.UIOptions.ShowConfirmation = true;
            this.recognizer.UIOptions.IsReadBackEnabled = true;
            this.recognizer.Timeouts.BabbleTimeout = TimeSpan.FromSeconds(5);
            //mozemo dodati ovdje sve lokacije koje se nalaze trenutno u bazi oglasa
            string[] lokacije = { "Sarajevo", "Mostar" };
            var dictationConstraint = new SpeechRecognitionListConstraint(lokacije);
            recognizer.Constraints.Add(dictationConstraint);
            await recognizer.CompileConstraintsAsync();

            var result = await this.recognizer.RecognizeWithUIAsync();

            if (result != null)
            {
                StringBuilder builder = new StringBuilder();

                builder.AppendLine(result.Text);

                this.lokacija = builder.ToString();
            }
        }
    }
}

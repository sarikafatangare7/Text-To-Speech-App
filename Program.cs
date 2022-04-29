using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace MySpeech_to_text_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my text to speech Application...");
            SpeechSynthesizer spk = new SpeechSynthesizer();
            spk.SetOutputToDefaultAudioDevice();
            spk.Speak("Welcome to azue session, i hope you are learning somthing");
        }
    }
}

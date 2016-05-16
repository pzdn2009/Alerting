using SpeechLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoundLocatePCLib
{
    public class DefaultAlerting : IAlerting
    {
        [DllImport("kernel32.dll", EntryPoint = "Beep")]
        public static extern int Beep(int dwFreq, int dwDuration);

        [DllImport("winmm.dll")]
        public static extern bool PlaySound(String Filename, int Mod, int Flags);

        public void Beeping(int freq, int duration)
        {
            Beep(freq, duration);
        }

        public void PlaySound(string fileName)
        {
            PlaySound(fileName, 1, 1);
        }

        public void Speak(string words)
        {
            SimpleSoundCtr.SetVol(20);
            SpVoice voice = new SpVoice();//SAPI 5.1
            voice.Speak(words);
        }
    }
}

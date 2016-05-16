using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundLocatePCLib
{
    public interface IAlerting
    {
        void Beeping(int freq, int duration);
        void PlaySound(string fileName);    
        void Speak(string words);
    }
}

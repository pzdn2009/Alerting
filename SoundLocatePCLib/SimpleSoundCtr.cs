using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoundLocatePCLib
{
    public class SimpleSoundCtr
    {
        public static void SetVol(double number)
        {
            CoreAudioController c = new CoreAudioController();
            var d= c.GetDefaultDevice(DeviceType.Playback, Role.Multimedia);
            d.Volume = number;
        }
    }
}

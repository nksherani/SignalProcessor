using System;
using System.Collections.Generic;
using System.Text;

namespace signalgen.Signals
{
    public class SinWave : Signal
    {
        public SinWave(double Amplitude, int FrequencyInHz) : base(Amplitude, FrequencyInHz, Math.Sin)
        {
        }
    }

}

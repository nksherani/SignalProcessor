using System;
using System.Collections.Generic;
using System.Text;

namespace signalgen.Signals
{
    public class CosWave : Signal
    {
        public CosWave(double Amplitude, int FrequencyInHz) : base(Amplitude, FrequencyInHz, Math.Cos)
        {
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace signalgen.Signals
{
    public class SumSignal : Signal
    {
        public List<Signal> signals = new List<Signal>();

        public override List<double> GetWave(double duration, int start, float SamplingFrequency)
        {
            this.SamplingFrequency = SamplingFrequency;
            double temp = start;
            var interval = 1 / SamplingFrequency;
            while (temp < duration - interval)
            {
                ts.Add(temp);
                double y = 0;
                foreach (var signal in signals)
                {
                    y += signal.Amplitude * signal.waveFunction(2 * Math.PI * signal.FrequencyInHz * temp);
                }
                ys.Add(y);
                temp += interval;
            }
            return ys;
        }
    }

}

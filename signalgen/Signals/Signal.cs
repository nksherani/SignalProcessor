using System;
using System.Collections.Generic;
using System.Text;

namespace signalgen.Signals
{
    public class Signal
    {
        public float SamplingFrequency { get; set; }
        public float TimePeriod { get; set; }
        public int FrequencyInHz { get; set; }
        public double Amplitude { get; set; }
        public WaveFunction waveFunction;
        public List<double> ts = new List<double>();
        public List<double> ys = new List<double>();
        public Signal()
        {

        }
        public Signal(double Amplitude, int FrequencyInHz, WaveFunction waveFunction)
        {
            this.FrequencyInHz = FrequencyInHz;
            this.TimePeriod = 1 / FrequencyInHz;
            this.Amplitude = Amplitude;
            this.waveFunction = waveFunction;
        }
        public virtual List<double> GetWave(double duration, int start, float SamplingFrequency)
        {
            this.SamplingFrequency = SamplingFrequency;
            double temp = start;
            var interval = 1 / SamplingFrequency;
            while (temp < duration - interval)
            {
                ts.Add(temp);
                ys.Add(Amplitude * waveFunction(2 * Math.PI * FrequencyInHz * temp));
                temp += interval;
            }
            return ys;
        }
        public static SumSignal operator +(Signal A, Signal B)
        {
            SumSignal sumsignal = new SumSignal();
            sumsignal.signals.Add(A);
            sumsignal.signals.Add(B);
            return sumsignal;
        }
        public static Signal operator +(SumSignal A, Signal B)
        {
            A.signals.Add(B);
            return A;
        }
    }

}

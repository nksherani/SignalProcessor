using signalgen.Signals;
using System;
using System.Collections.Generic;

namespace signalgen
{
    public delegate double WaveFunction(double AngleInRadian);
    public class Program
    {
        static void Main(string[] args)
        {
            //SinWave signal = new SinWave(10, 440);
            //var wave = signal.GetWave(1,0,11025);



            SinWave A = new SinWave(1, 440);
            SinWave B = new SinWave(1, 880);
            var sum = A + B;
            var wave = sum.GetWave(1, 0, 11025);



            Console.WriteLine("Hello World!");
        }
    }
}

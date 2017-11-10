using System;

namespace WilksCalculator
{
    public class WilksCalculator
    {
        public double Calculate(long bodyWeight, long liftTotal)
        {
            double[] constants = new double[] {
                -216.0475144,
                16.2606339,
                -0.002388645,
                -0.00113732,
                0.00000701863,
                -0.00000001291
            };
           
            return liftTotal * (500 / (constants[0] + 
                                       constants[1] * bodyWeight +
                                       constants[2] * Math.Pow(bodyWeight, 2) +
                                       constants[3] * Math.Pow(bodyWeight, 3) + 
                                       constants[4] * Math.Pow(bodyWeight, 4) +
                                       constants[5] * Math.Pow(bodyWeight, 5)));
        }
    }
}
using System;

namespace WilksCalculator
{
    public class WilksCalculator
    {
        private double[] maleConstants = new double[] {
                -216.0475144,
                16.2606339,
                -0.002388645,
                -0.00113732,
                0.00000701863,
                -0.00000001291
            };

        private double[] femaleConstants = new double[] {
                594.31747775582,
                -27.23842536447,
                0.82112226871,
                -0.00930733913,
                0.00004731582,
                -0.00000009054
            };

        public double Calculate(long bodyWeight, long liftTotal, bool isMale)
        {
            
            return liftTotal * (500 / ((isMale ? maleConstants[0] : femaleConstants[0]) +
                                       (isMale ? maleConstants[1] : femaleConstants[1]) * bodyWeight +
                                       (isMale ? maleConstants[2] : femaleConstants[2]) * Math.Pow(bodyWeight, 2) +
                                       (isMale ? maleConstants[3] : femaleConstants[3]) * Math.Pow(bodyWeight, 3) +
                                       (isMale ? maleConstants[4] : femaleConstants[4]) * Math.Pow(bodyWeight, 4) +
                                       (isMale ? maleConstants[5] : femaleConstants[5]) * Math.Pow(bodyWeight, 5)));
        }
    }
}
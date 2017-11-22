using System;
using System.Collections.Generic;

namespace Pwrliftr.Calculators
{
    public class PlateCalculator
    {
        public List<double> Calculate(List<double>plateSet, double targetWeight, bool isRecordAttempt)
        {
            //change this to array
            List<double> plates = isRecordAttempt ? new List<double>() { 25, 20, 15, 10, 5, 2.5, 1.25, 0.5, 0.25 } : new List<double>() { 25, 20, 15, 10, 5, 2.5, 1.25 };

            var result = new List<double>() { };
            var requestedWeight = targetWeight;
            
            targetWeight = (targetWeight - 25) / 2;

            foreach (var plate in plates)
            {
                targetWeight = targetWeight / plate;
                var rounded = Math.Floor((double)targetWeight);
                double remainder = 0;
                if (rounded > 0)
                {
                    for (int i = 1; i <= rounded; i++)
                    {
                        if (!plateSet.Contains(plate))
                        {
                            remainder = (rounded - i) * plate;
                            break;
                        }
                        result.Add(plate);
                        plateSet.Remove(plate);
                    }
                }
              
                //get remainder
                remainder = remainder + (targetWeight - rounded);
               
                //get remainder
                targetWeight = plate * remainder;
            }

            return result;
        }
    }

    public class PlateSet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public double[] Plates { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace Pwrliftr.Calculators
{
    public class PlateCalculator
    {
        public List<double> Calculate(List<double>plateSet, double targetWeight, bool isRecordAttempt)
        {
            //change this to array
            List<double> weights = isRecordAttempt ? new List<double>() { 25, 20, 15, 10, 5, 2.5, 1.25, 0.5, 0.25 } : new List<double>() { 25, 20, 15, 10, 5, 2.5, 1.25 };
            var result = new List<double>() { };
            //minus bar and collar weight, divide by 2 as we want to get one half of the plate weight
            targetWeight = (targetWeight - 25) / 2;
            foreach (var weight in weights)
            {
                targetWeight = targetWeight / weight;
                var rounded = Math.Floor((double)targetWeight);
                double remainder = 0;
                if (rounded > 0)
                {
                    for (int i = 1; i <= rounded; i++)
                    {
                        if (!plateSet.Contains(weight))
                        {
                            remainder = (rounded - i) * weight;
                            break;
                        }
                        result.Add(weight);
                        plateSet.Remove(weight);
                    }
                }
                remainder = remainder + (targetWeight - rounded);
                targetWeight = weight * remainder;
            }
            return result;
        }
    }
}
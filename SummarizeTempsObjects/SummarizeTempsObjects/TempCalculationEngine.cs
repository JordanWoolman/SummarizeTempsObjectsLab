using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int sum = 0;
            //loop through all the tempsin the list
            foreach (int sumtemp in _temperatures)
            {
                //add each temp to my sum variable
                sum += sumtemp;
                //sumOftemps = sum of temps = temp;
            }
            //divide sum variable by the list count
            int averageTemps = sum / _temperatures.Count;
            return averageTemps; //<-- replace this with the actual average     
        }

        public int TempsAboveThreshold(int threshold)
        {
            int abvt = 0;
            // add logic to calculate temps above the threshold
            foreach (int abovetemp in _temperatures)
            {
                if (abovetemp<threshold)
                {
                    abvt++;
                }
            }
            return abvt; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            int blt = 0;
            // add logic to calculate and return temps below the threshold
            foreach (int belowtemp in _temperatures)
            {
                if (belowtemp<threshold)
                {
                    blt++;
                }
            }
            return blt; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            int att = 0;
            // add logic to calculate and return temps at the threshold
            foreach (int atemp in _temperatures)
            {
                if (atemp==threshold)
                {
                    att++;
                }
            }
            return att; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}

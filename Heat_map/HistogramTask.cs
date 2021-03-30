using System;
using System.Linq;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            double[] value = new double[31];
            string[] labels = new string[31];
            for (int i = 0; i < 31; i++)
            {
                labels[i] = (i + 1).ToString();
            }
            for (int i = 0; i < names.Length; i++) 
            {
                if (names[i].Name == name)
                {
                    value[names[i].BirthDate.Day - 1] += 1;
                }
            }
            value[0] = 0;
            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name), 
                labels, 
                value);

        }
    }
}
using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            string[] xlabels = new string[30];
            string[] ylabels = new string[12];
            double[,] heat = new double[30,12];
            for (int i = 0; i < 30; i++)
            {
                xlabels[i] = (i + 2).ToString();
            }
            for (int i = 0; i < 12; i++)
            {
                ylabels[i] = (i + 1).ToString();
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].BirthDate.Day != 1)
                {
                    heat[names[i].BirthDate.Day - 2, names[i].BirthDate.Month - 1] += 1;
                }
            }
            return new HeatmapData(
                "Пример карты интенсивностей",
                heat, 
                xlabels, 
                ylabels);
        }
    }
}
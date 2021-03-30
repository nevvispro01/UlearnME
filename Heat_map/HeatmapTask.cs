using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            string[] Xlabels = new string[31];
            string[] Ylabels = new string[12];
            double[] heat = new double[31];
            for (int i = 0; i < 30; i++)
            {
                Xlabels[i] = (i + 2).ToString();
            }
            for (int i = 0; i < 12; i++)
            {
                Ylabels[i] = (i + 1).ToString();
            }

            return new HeatmapData(
                "Пример карты интенсивностей",
                new double[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 4 }, { 4, 4, 4 } }, 
                new[] { "a", "b", "c", "d" }, 
                new[] { "X", "Y", "Z" });
        }
    }
}
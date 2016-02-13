using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace main
{
    static class DataContainer
    {
        const int SIZE = 3000;
        public static double[,] routes;
        public static void Load(string path)
        {
            routes = new double[SIZE, SIZE];
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] splitted = lines[i].Split(',');
                for (int j = 0; j < splitted.Length; j++)
                {
                    routes[i, j] = double.Parse(splitted[i].Replace('.', ','));
                }
            }
        }
    }
}

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
        public static List<Order> orders;
        public static void Load(string pathRoutes, string pathTimes)
        {
            routes = new double[SIZE, SIZE];
            string[] lines = File.ReadAllLines(pathRoutes);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] splitted = lines[i].Split(',');
                for (int j = 0; j < splitted.Length; j++)
                {
                    routes[i, j] = double.Parse(splitted[i].Replace('.', ','));
                }
            }
            orders = new List<Order>();
            string[] lns = File.ReadAllLines(pathTimes);
            foreach (var item in lns)
            {
                orders.Add(Order.FromString(item));
            }

        }
        public static Order getWhereId(int id)
        {
            foreach (var item in orders)
            {
                if (item.id == id)
                    return item;
            }
            return null;
        }
    }
}

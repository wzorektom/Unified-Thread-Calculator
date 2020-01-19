using System.Collections.Generic;
using System.Linq;


namespace ThreadCalculatorClassLibrary
{
    public class ThreadClassModel
    {


        public double BasicDia { get; set; }
        public double Tpi { get; set; }


        public string[] list1 { get; set; } = { "1A", "2A", "3A", "1B", "2B", "3B" };
        public string[] list2 { get; set; } = { "2A", "3A", "2B", "3B" };

        public string[] classType { get; set; }


        public List<ThreadClassModel> PopulateThreadClass()
        {
            List<ThreadClassModel> output = new List<ThreadClassModel>
            {

                new ThreadClassModel { BasicDia = 0.2500, Tpi = 20, classType = list1 },
                new ThreadClassModel { BasicDia = 0.2500, Tpi = 28, classType = list1 },
                new ThreadClassModel { BasicDia = 0.2500, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.2500, Tpi = 20, classType = list1 },
                new ThreadClassModel { BasicDia = 0.2500, Tpi = 28, classType = list1 },
                new ThreadClassModel { BasicDia = 0.2500, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.3125, Tpi = 18, classType = list1 },
                new ThreadClassModel { BasicDia = 0.3125, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 0.3125, Tpi = 24, classType = list1 },
                new ThreadClassModel { BasicDia = 0.3125, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 0.3125, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.3750, Tpi = 16, classType = list1 },
                new ThreadClassModel { BasicDia = 0.3750, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 0.3750, Tpi = 24, classType = list1 },
                new ThreadClassModel { BasicDia = 0.3750, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 0.3750, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.4375, Tpi = 14, classType = list1 },
                new ThreadClassModel { BasicDia = 0.4375, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 0.4375, Tpi = 20, classType = list1 },
                new ThreadClassModel { BasicDia = 0.4375, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 0.4375, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.5000, Tpi = 13, classType = list1 },
                new ThreadClassModel { BasicDia = 0.5000, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 0.5000, Tpi = 20, classType = list1 },
                new ThreadClassModel { BasicDia = 0.5000, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 0.5000, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.5625, Tpi = 12, classType = list1 },
                new ThreadClassModel { BasicDia = 0.5625, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 0.5625, Tpi = 18, classType = list1 },
                new ThreadClassModel { BasicDia = 0.5625, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 0.5625, Tpi = 24, classType = list2 },
                new ThreadClassModel { BasicDia = 0.5625, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 0.5625, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.6250, Tpi = 11, classType = list1 },
                new ThreadClassModel { BasicDia = 0.6250, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 0.6250, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 0.6250, Tpi = 18, classType = list1 },
                new ThreadClassModel { BasicDia = 0.6250, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 0.6250, Tpi = 24, classType = list2 },
                new ThreadClassModel { BasicDia = 0.6250, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 0.6250, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.6875, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 0.6875, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 0.6875, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 0.6875, Tpi = 24, classType = list2 },
                new ThreadClassModel { BasicDia = 0.6875, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 0.6875, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.7500, Tpi = 10, classType = list1 },
                new ThreadClassModel { BasicDia = 0.7500, Tpi = 16, classType = list1 },
                new ThreadClassModel { BasicDia = 0.7500, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 0.7500, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 0.7500, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 0.7500, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.8125, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 0.8125, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 0.8125, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 0.8125, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 0.8125, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.8750, Tpi = 9, classType = list1 },
                new ThreadClassModel { BasicDia = 0.8750, Tpi = 14, classType = list1 },
                new ThreadClassModel { BasicDia = 0.8750, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 0.8750, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 0.8750, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 0.8750, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 0.8750, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 0.9375, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 0.9375, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 0.9375, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 0.9375, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 0.9375, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 1.000, Tpi = 8, classType = list1 },
                new ThreadClassModel { BasicDia = 1.000, Tpi = 12, classType = list1 },
                new ThreadClassModel { BasicDia = 1.000, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 1.000, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.000, Tpi = 28, classType = list2 },
                new ThreadClassModel { BasicDia = 1.000, Tpi = 32, classType = list2 },

                new ThreadClassModel { BasicDia = 1.0625, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.0625, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 1.0625, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.0625, Tpi = 18, classType = list2 },
                new ThreadClassModel { BasicDia = 1.0625, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 1.0625, Tpi = 28, classType = list2 },

                new ThreadClassModel { BasicDia = 1.1250, Tpi = 7, classType = list1 },
                new ThreadClassModel { BasicDia = 1.1250, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.1250, Tpi = 12, classType = list1 },
                new ThreadClassModel { BasicDia = 1.1250, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.1250, Tpi = 18, classType = list2 },
                new ThreadClassModel { BasicDia = 1.1250, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 1.1250, Tpi = 28, classType = list2 },

                new ThreadClassModel { BasicDia = 1.1875, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.1875, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 1.1875, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.1875, Tpi = 18, classType = list2 },
                new ThreadClassModel { BasicDia = 1.1875, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 1.1875, Tpi = 28, classType = list2 },

                new ThreadClassModel { BasicDia = 1.2500, Tpi = 7, classType = list1 },
                new ThreadClassModel { BasicDia = 1.2500, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.2500, Tpi = 12, classType = list1 },
                new ThreadClassModel { BasicDia = 1.2500, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.2500, Tpi = 18, classType = list2 },
                new ThreadClassModel { BasicDia = 1.2500, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 1.2500, Tpi = 28, classType = list2 },

                new ThreadClassModel { BasicDia = 1.3125, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.3125, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 1.3125, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.3125, Tpi = 18, classType = list2 },
                new ThreadClassModel { BasicDia = 1.3125, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 1.3125, Tpi = 28, classType = list2 },

                new ThreadClassModel { BasicDia = 1.3750, Tpi = 6, classType = list1 },
                new ThreadClassModel { BasicDia = 1.3750, Tpi = 12, classType = list1 },
                new ThreadClassModel { BasicDia = 1.3750, Tpi = 18, classType = list2 },
                new ThreadClassModel { BasicDia = 1.3750, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.3750, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.3750, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 1.3750, Tpi = 28, classType = list2 },

                new ThreadClassModel { BasicDia = 1.4375, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 1.4375, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.4375, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 1.4375, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.4375, Tpi = 18, classType = list2 },
                new ThreadClassModel { BasicDia = 1.4375, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 1.4375, Tpi = 28, classType = list2 },

                new ThreadClassModel { BasicDia = 1.5000, Tpi = 6, classType = list1 },
                new ThreadClassModel { BasicDia = 1.5000, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.5000, Tpi = 12, classType = list1 },
                new ThreadClassModel { BasicDia = 1.5000, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.5000, Tpi = 18, classType = list2 },
                new ThreadClassModel { BasicDia = 1.5000, Tpi = 20, classType = list2 },
                new ThreadClassModel { BasicDia = 1.5000, Tpi = 28, classType = list2 },

                new ThreadClassModel { BasicDia = 1.5625, Tpi = 18, classType = list2 },
                new ThreadClassModel { BasicDia = 1.5625, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 1.5625, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.5625, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 1.5625, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.5625, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 1.6250, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 1.6250, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.6250, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 1.6250, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.6250, Tpi = 18, classType = list2 },
                new ThreadClassModel { BasicDia = 1.6250, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 1.6875, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 1.6875, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.6875, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 1.6875, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.6875, Tpi = 18, classType = list2 },
                new ThreadClassModel { BasicDia = 1.6875, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 1.7500, Tpi = 5, classType = list1 },
                new ThreadClassModel { BasicDia = 1.7500, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 1.7500, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.7500, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 1.7500, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.7500, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 1.8125, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 1.8125, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.8125, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 1.8125, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.8125, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 1.8750, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 1.8750, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.8750, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 1.8750, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.8750, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 1.9375, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 1.9375, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 1.9375, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 1.9375, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 1.9375, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 2.0000, Tpi = 4.5, classType = list1 },
                new ThreadClassModel { BasicDia = 2.0000, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 2.0000, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 2.0000, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 2.0000, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 2.0000, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 2.1250, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 2.1250, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 2.1250, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 2.1250, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 2.1250, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 2.2500, Tpi = 4.5, classType = list1 },
                new ThreadClassModel { BasicDia = 2.2500, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 2.2500, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 2.2500, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 2.2500, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 2.2500, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 2.3750, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 2.3750, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 2.3750, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 2.3750, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 2.3750, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 2.5000, Tpi = 4, classType = list1 },
                new ThreadClassModel { BasicDia = 2.5000, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 2.5000, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 2.5000, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 2.5000, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 2.5000, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 2.6250, Tpi = 4, classType = list2 },
                new ThreadClassModel { BasicDia = 2.6250, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 2.6250, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 2.6250, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 2.6250, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 2.6250, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 2.7500, Tpi = 4, classType = list1 },
                new ThreadClassModel { BasicDia = 2.7500, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 2.7500, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 2.7500, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 2.7500, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 2.7500, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 2.8750, Tpi = 4, classType = list2 },
                new ThreadClassModel { BasicDia = 2.8750, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 2.8750, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 2.8750, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 2.8750, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 2.8750, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 3.0000, Tpi = 4, classType = list1 },
                new ThreadClassModel { BasicDia = 3.0000, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 3.0000, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 3.0000, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 3.0000, Tpi = 16, classType = list2 },
                new ThreadClassModel { BasicDia = 3.0000, Tpi = 20, classType = list2 },

                new ThreadClassModel { BasicDia = 3.1250, Tpi = 4, classType = list1 },
                new ThreadClassModel { BasicDia = 3.1250, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 3.1250, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 3.1250, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 3.1250, Tpi = 16, classType = list2 },

                new ThreadClassModel { BasicDia = 3.2500, Tpi = 4, classType = list1 },
                new ThreadClassModel { BasicDia = 3.2500, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 3.2500, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 3.2500, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 3.2500, Tpi = 16, classType = list2 },

                new ThreadClassModel { BasicDia = 3.3750, Tpi = 4, classType = list2 },
                new ThreadClassModel { BasicDia = 3.3750, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 3.3750, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 3.3750, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 3.3750, Tpi = 16, classType = list2 },

                new ThreadClassModel { BasicDia = 3.5000, Tpi = 4, classType = list1 },
                new ThreadClassModel { BasicDia = 3.5000, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 3.5000, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 3.5000, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 3.5000, Tpi = 16, classType = list2 },

                new ThreadClassModel { BasicDia = 3.6250, Tpi = 4, classType = list2 },
                new ThreadClassModel { BasicDia = 3.6250, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 3.6250, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 3.6250, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 3.6250, Tpi = 16, classType = list2 },

                new ThreadClassModel { BasicDia = 3.7500, Tpi = 4, classType = list1 },
                new ThreadClassModel { BasicDia = 3.7500, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 3.7500, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 3.7500, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 3.7500, Tpi = 16, classType = list2 },

                new ThreadClassModel { BasicDia = 3.8750, Tpi = 4, classType = list2 },
                new ThreadClassModel { BasicDia = 3.8750, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 3.8750, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 3.8750, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 3.8750, Tpi = 16, classType = list2 },

                new ThreadClassModel { BasicDia = 4.0000, Tpi = 4, classType = list1 },
                new ThreadClassModel { BasicDia = 4.0000, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 4.0000, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 4.0000, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 4.0000, Tpi = 16, classType = list2 },

                new ThreadClassModel { BasicDia = 4.1250, Tpi = 4, classType = list2 },
                new ThreadClassModel { BasicDia = 4.1250, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 4.1250, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 4.1250, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 4.1250, Tpi = 16, classType = list2 },

                new ThreadClassModel { BasicDia = 4.2500, Tpi = 4, classType = list2 },
                new ThreadClassModel { BasicDia = 4.2500, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 4.2500, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 4.2500, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 4.2500, Tpi = 16, classType = list2 },

                new ThreadClassModel { BasicDia = 4.3750, Tpi = 4, classType = list2 },
                new ThreadClassModel { BasicDia = 4.3750, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 4.3750, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 4.3750, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 4.3750, Tpi = 16, classType = list2 },

                new ThreadClassModel { BasicDia = 4.5000, Tpi = 4, classType = list2 },
                new ThreadClassModel { BasicDia = 4.5000, Tpi = 6, classType = list2 },
                new ThreadClassModel { BasicDia = 4.5000, Tpi = 8, classType = list2 },
                new ThreadClassModel { BasicDia = 4.5000, Tpi = 12, classType = list2 },
                new ThreadClassModel { BasicDia = 4.5000, Tpi = 16, classType = list2 }

            };
            return output;
        }



        public string[] GetClassModel(double basicDia, double tpi)
        {
            if (basicDia < 0.2500)
            {
                return list2;
            }

            List<ThreadClassModel> values = PopulateThreadClass();
            ThreadClassModel result = values.Where(x => x.BasicDia == basicDia && x.Tpi == tpi).FirstOrDefault();

            return result.classType;

        }







    }
}

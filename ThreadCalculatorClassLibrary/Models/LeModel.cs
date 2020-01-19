using System;
using System.Collections.Generic;
using System.Linq;


namespace ThreadCalculatorClassLibrary
{
    public class LeModel
    {

        public double BasicDia { get; private set; }
        public double Tpi { get; private set; }
        public double Le { get; private set; }
        


        // =====================================================================
        //  RETURN LE - LENGTH OF ENGAGEMENT BASED ON SELECTED BASIC DIA AND TPI
        // =====================================================================

        public List<LeModel> PopulateLeValues()
        {
            List<LeModel> output = new List<LeModel>
            {
                new LeModel { BasicDia = 0.0600, Tpi = 80, Le = 0.06 },

                new LeModel { BasicDia = 0.0730, Tpi = 64, Le = 0.073 },
                new LeModel { BasicDia = 0.0730, Tpi = 72, Le = 0.073 },

                new LeModel { BasicDia = 0.0860, Tpi = 56, Le = 0.086 },
                new LeModel { BasicDia = 0.0860, Tpi = 64, Le = 0.086 },

                new LeModel { BasicDia = 0.0990, Tpi = 48, Le = 0.099 },
                new LeModel { BasicDia = 0.0990, Tpi = 56, Le = 0.099 },

                new LeModel { BasicDia = 0.1120, Tpi = 40, Le = 0.112 },
                new LeModel { BasicDia = 0.1120, Tpi = 48, Le = 0.112 },

                new LeModel { BasicDia = 0.1250, Tpi = 40, Le = 0.125 },
                new LeModel { BasicDia = 0.1250, Tpi = 44, Le = 0.125 },

                new LeModel { BasicDia = 0.1380, Tpi = 32, Le = 0.138 },
                new LeModel { BasicDia = 0.1380, Tpi = 40, Le = 0.138 },

                new LeModel { BasicDia = 0.1640, Tpi = 32, Le = 0.164 },
                new LeModel { BasicDia = 0.1640, Tpi = 36, Le = 0.164 },

                new LeModel { BasicDia = 0.1900, Tpi = 24, Le = 0.190 },
                new LeModel { BasicDia = 0.1900, Tpi = 32, Le = 0.190 },

                new LeModel { BasicDia = 0.2160, Tpi = 24, Le = 0.216 },
                new LeModel { BasicDia = 0.2160, Tpi = 28, Le = 0.216 },
                new LeModel { BasicDia = 0.2160, Tpi = 32, Le = 0.2813 },


                new LeModel { BasicDia = 0.2500, Tpi = 20, Le = 0.25 },
                new LeModel { BasicDia = 0.2500, Tpi = 28, Le = 0.25 },
                new LeModel { BasicDia = 0.2500, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 0.3125, Tpi = 18, Le = 0.31 },
                new LeModel { BasicDia = 0.3125, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 0.3125, Tpi = 24, Le = 0.31 },
                new LeModel { BasicDia = 0.3125, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 0.3125, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 0.3750, Tpi = 16, Le = 0.38 },
                new LeModel { BasicDia = 0.3750, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 0.3750, Tpi = 24, Le = 0.38 },
                new LeModel { BasicDia = 0.3750, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 0.3750, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 0.4375, Tpi = 14, Le = 0.44 },
                new LeModel { BasicDia = 0.4375, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 0.4375, Tpi = 20, Le = 0.44 },
                new LeModel { BasicDia = 0.4375, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 0.4375, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 0.5000, Tpi = 13, Le = 0.50 },
                new LeModel { BasicDia = 0.5000, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 0.5000, Tpi = 20, Le = 0.50 },
                new LeModel { BasicDia = 0.5000, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 0.5000, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 0.5625, Tpi = 12, Le = 0.56 },
                new LeModel { BasicDia = 0.5625, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 0.5625, Tpi = 18, Le = 0.56 },
                new LeModel { BasicDia = 0.5625, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 0.5625, Tpi = 24, Le = 0.38 },
                new LeModel { BasicDia = 0.5625, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 0.5625, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 0.6250, Tpi = 11, Le = 0.63 },
                new LeModel { BasicDia = 0.6250, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 0.6250, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 0.6250, Tpi = 18, Le = 0.63 },
                new LeModel { BasicDia = 0.6250, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 0.6250, Tpi = 24, Le = 0.38 },
                new LeModel { BasicDia = 0.6250, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 0.6250, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 0.6875, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 0.6875, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 0.6875, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 0.6875, Tpi = 24, Le = 0.38 },
                new LeModel { BasicDia = 0.6875, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 0.6875, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 0.7500, Tpi = 10, Le = 0.75 },
                new LeModel { BasicDia = 0.7500, Tpi = 16, Le = 0.75 },
                new LeModel { BasicDia = 0.7500, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 0.7500, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 0.7500, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 0.7500, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 0.8125, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 0.8125, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 0.8125, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 0.8125, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 0.8125, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 0.8750, Tpi = 9, Le = 0.88 },
                new LeModel { BasicDia = 0.8750, Tpi = 14, Le = 0.88 },
                new LeModel { BasicDia = 0.8750, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 0.8750, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 0.8750, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 0.8750, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 0.8750, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 0.9375, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 0.9375, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 0.9375, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 0.9375, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 0.9375, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 1.000, Tpi = 8, Le = 1.00 },
                new LeModel { BasicDia = 1.000, Tpi = 12, Le = 1.00 },
                new LeModel { BasicDia = 1.000, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 1.000, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.000, Tpi = 28, Le = 0.32 },
                new LeModel { BasicDia = 1.000, Tpi = 32, Le = 0.28 },

                new LeModel { BasicDia = 1.0625, Tpi = 8, Le = 1.06 },
                new LeModel { BasicDia = 1.0625, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 1.0625, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.0625, Tpi = 18, Le = 0.50 },
                new LeModel { BasicDia = 1.0625, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 1.0625, Tpi = 28, Le = 0.32 },

                new LeModel { BasicDia = 1.1250, Tpi = 7, Le = 1.13 },
                new LeModel { BasicDia = 1.1250, Tpi = 8, Le = 1.13 },
                new LeModel { BasicDia = 1.1250, Tpi = 12, Le = 1.13 },
                new LeModel { BasicDia = 1.1250, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.1250, Tpi = 18, Le = 0.50 },
                new LeModel { BasicDia = 1.1250, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 1.1250, Tpi = 28, Le = 0.32 },

                new LeModel { BasicDia = 1.1875, Tpi = 8, Le = 1.19 },
                new LeModel { BasicDia = 1.1875, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 1.1875, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.1875, Tpi = 18, Le = 0.50 },
                new LeModel { BasicDia = 1.1875, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 1.1875, Tpi = 28, Le = 0.32 },

                new LeModel { BasicDia = 1.2500, Tpi = 7, Le = 1.25 },
                new LeModel { BasicDia = 1.2500, Tpi = 8, Le = 1.25 },
                new LeModel { BasicDia = 1.2500, Tpi = 12, Le = 1.25 },
                new LeModel { BasicDia = 1.2500, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.2500, Tpi = 18, Le = 0.50 },
                new LeModel { BasicDia = 1.2500, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 1.2500, Tpi = 28, Le = 0.32 },

                new LeModel { BasicDia = 1.3125, Tpi = 8, Le = 1.31 },
                new LeModel { BasicDia = 1.3125, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 1.3125, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.3125, Tpi = 18, Le = 0.50 },
                new LeModel { BasicDia = 1.3125, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 1.3125, Tpi = 28, Le = 0.32 },

                new LeModel { BasicDia = 1.3750, Tpi = 6, Le = 1.38 },
                new LeModel { BasicDia = 1.3750, Tpi = 12, Le = 1.38 },
                new LeModel { BasicDia = 1.3750, Tpi = 18, Le = 0.50 },
                new LeModel { BasicDia = 1.3750, Tpi = 8, Le = 1.38 },
                new LeModel { BasicDia = 1.3750, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.3750, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 1.3750, Tpi = 28, Le = 0.32 },

                new LeModel { BasicDia = 1.4375, Tpi = 6, Le = 1.44 },
                new LeModel { BasicDia = 1.4375, Tpi = 8, Le = 1.44 },
                new LeModel { BasicDia = 1.4375, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 1.4375, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.4375, Tpi = 18, Le = 0.50 },
                new LeModel { BasicDia = 1.4375, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 1.4375, Tpi = 28, Le = 0.32 },

                new LeModel { BasicDia = 1.5000, Tpi = 6, Le = 1.50 },
                new LeModel { BasicDia = 1.5000, Tpi = 8, Le = 1.50 },
                new LeModel { BasicDia = 1.5000, Tpi = 12, Le = 1.50 },
                new LeModel { BasicDia = 1.5000, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.5000, Tpi = 18, Le = 0.50 },
                new LeModel { BasicDia = 1.5000, Tpi = 20, Le = 0.45 },
                new LeModel { BasicDia = 1.5000, Tpi = 28, Le = 0.32 },

                new LeModel { BasicDia = 1.5625, Tpi = 18, Le = 0.50 },
                new LeModel { BasicDia = 1.5625, Tpi = 6, Le = 1.56 },
                new LeModel { BasicDia = 1.5625, Tpi = 8, Le = 1.56 },
                new LeModel { BasicDia = 1.5625, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 1.5625, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.5625, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 1.6250, Tpi = 6, Le = 1.63 },
                new LeModel { BasicDia = 1.6250, Tpi = 8, Le = 1.63 },
                new LeModel { BasicDia = 1.6250, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 1.6250, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.6250, Tpi = 18, Le = 0.50 },
                new LeModel { BasicDia = 1.6250, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 1.6875, Tpi = 6, Le = 1.69 },
                new LeModel { BasicDia = 1.6875, Tpi = 8, Le = 1.69 },
                new LeModel { BasicDia = 1.6875, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 1.6875, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.6875, Tpi = 18, Le = 0.50 },
                new LeModel { BasicDia = 1.6875, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 1.7500, Tpi = 5, Le = 1.75 },
                new LeModel { BasicDia = 1.7500, Tpi = 6, Le = 1.75 },
                new LeModel { BasicDia = 1.7500, Tpi = 8, Le = 1.75 },
                new LeModel { BasicDia = 1.7500, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 1.7500, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.7500, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 1.8125, Tpi = 6, Le = 1.81 },
                new LeModel { BasicDia = 1.8125, Tpi = 8, Le = 1.81 },
                new LeModel { BasicDia = 1.8125, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 1.8125, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.8125, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 1.8750, Tpi = 6, Le = 1.88 },
                new LeModel { BasicDia = 1.8750, Tpi = 8, Le = 1.88 },
                new LeModel { BasicDia = 1.8750, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 1.8750, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.8750, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 1.9375, Tpi = 6, Le = 1.94 },
                new LeModel { BasicDia = 1.9375, Tpi = 8, Le = 1.94 },
                new LeModel { BasicDia = 1.9375, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 1.9375, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 1.9375, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 2.0000, Tpi = 4.5, Le = 2.00 },
                new LeModel { BasicDia = 2.0000, Tpi = 6, Le = 2.00 },
                new LeModel { BasicDia = 2.0000, Tpi = 8, Le = 2.00 },
                new LeModel { BasicDia = 2.0000, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 2.0000, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 2.0000, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 2.1250, Tpi = 6, Le = 2.13 },
                new LeModel { BasicDia = 2.1250, Tpi = 8, Le = 2.13 },
                new LeModel { BasicDia = 2.1250, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 2.1250, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 2.1250, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 2.2500, Tpi = 4.5, Le = 2.25 },
                new LeModel { BasicDia = 2.2500, Tpi = 6, Le = 2.25 },
                new LeModel { BasicDia = 2.2500, Tpi = 8, Le = 2.25 },
                new LeModel { BasicDia = 2.2500, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 2.2500, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 2.2500, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 2.3750, Tpi = 6, Le = 2.38 },
                new LeModel { BasicDia = 2.3750, Tpi = 8, Le = 2.38 },
                new LeModel { BasicDia = 2.3750, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 2.3750, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 2.3750, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 2.5000, Tpi = 4, Le = 2.50 },
                new LeModel { BasicDia = 2.5000, Tpi = 6, Le = 2.50 },
                new LeModel { BasicDia = 2.5000, Tpi = 8, Le = 2.50 },
                new LeModel { BasicDia = 2.5000, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 2.5000, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 2.5000, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 2.6250, Tpi = 4, Le = 2.63 },
                new LeModel { BasicDia = 2.6250, Tpi = 6, Le = 2.63 },
                new LeModel { BasicDia = 2.6250, Tpi = 8, Le = 2.63 },
                new LeModel { BasicDia = 2.6250, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 2.6250, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 2.6250, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 2.7500, Tpi = 4, Le = 2.75 },
                new LeModel { BasicDia = 2.7500, Tpi = 6, Le = 2.75 },
                new LeModel { BasicDia = 2.7500, Tpi = 8, Le = 2.75 },
                new LeModel { BasicDia = 2.7500, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 2.7500, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 2.7500, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 2.8750, Tpi = 4, Le = 2.88 },
                new LeModel { BasicDia = 2.8750, Tpi = 6, Le = 2.88 },
                new LeModel { BasicDia = 2.8750, Tpi = 8, Le = 2.88 },
                new LeModel { BasicDia = 2.8750, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 2.8750, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 2.8750, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 3.0000, Tpi = 4, Le = 3.00 },
                new LeModel { BasicDia = 3.0000, Tpi = 6, Le = 3.00 },
                new LeModel { BasicDia = 3.0000, Tpi = 8, Le = 3.00 },
                new LeModel { BasicDia = 3.0000, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 3.0000, Tpi = 16, Le = 0.56 },
                new LeModel { BasicDia = 3.0000, Tpi = 20, Le = 0.45 },

                new LeModel { BasicDia = 3.1250, Tpi = 4, Le = 3.13 },
                new LeModel { BasicDia = 3.1250, Tpi = 6, Le = 3.13 },
                new LeModel { BasicDia = 3.1250, Tpi = 8, Le = 3.13 },
                new LeModel { BasicDia = 3.1250, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 3.1250, Tpi = 16, Le = 0.56 },

                new LeModel { BasicDia = 3.2500, Tpi = 4, Le = 3.25 },
                new LeModel { BasicDia = 3.2500, Tpi = 6, Le = 3.25 },
                new LeModel { BasicDia = 3.2500, Tpi = 8, Le = 3.25 },
                new LeModel { BasicDia = 3.2500, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 3.2500, Tpi = 16, Le = 0.56 },

                new LeModel { BasicDia = 3.3750, Tpi = 4, Le = 3.75 },
                new LeModel { BasicDia = 3.3750, Tpi = 6, Le = 3.75 },
                new LeModel { BasicDia = 3.3750, Tpi = 8, Le = 3.75 },
                new LeModel { BasicDia = 3.3750, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 3.3750, Tpi = 16, Le = 0.56 },

                new LeModel { BasicDia = 3.5000, Tpi = 4, Le = 3.50 },
                new LeModel { BasicDia = 3.5000, Tpi = 6, Le = 3.50 },
                new LeModel { BasicDia = 3.5000, Tpi = 8, Le = 3.50 },
                new LeModel { BasicDia = 3.5000, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 3.5000, Tpi = 16, Le = 0.56 },

                new LeModel { BasicDia = 3.6250, Tpi = 4, Le = 3.63 },
                new LeModel { BasicDia = 3.6250, Tpi = 6, Le = 3.63 },
                new LeModel { BasicDia = 3.6250, Tpi = 8, Le = 3.63 },
                new LeModel { BasicDia = 3.6250, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 3.6250, Tpi = 16, Le = 0.56 },

                new LeModel { BasicDia = 3.7500, Tpi = 4, Le = 3.75 },
                new LeModel { BasicDia = 3.7500, Tpi = 6, Le = 3.75 },
                new LeModel { BasicDia = 3.7500, Tpi = 8, Le = 3.75 },
                new LeModel { BasicDia = 3.7500, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 3.7500, Tpi = 16, Le = 0.56 },

                new LeModel { BasicDia = 3.8750, Tpi = 4, Le = 3.88 },
                new LeModel { BasicDia = 3.8750, Tpi = 6, Le = 3.88 },
                new LeModel { BasicDia = 3.8750, Tpi = 8, Le = 3.88 },
                new LeModel { BasicDia = 3.8750, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 3.8750, Tpi = 16, Le = 0.56 },

                new LeModel { BasicDia = 4.0000, Tpi = 4, Le = 4.00 },
                new LeModel { BasicDia = 4.0000, Tpi = 6, Le = 4.00 },
                new LeModel { BasicDia = 4.0000, Tpi = 8, Le = 4.00 },
                new LeModel { BasicDia = 4.0000, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 4.0000, Tpi = 16, Le = 0.56 },

                new LeModel { BasicDia = 4.1250, Tpi = 4, Le = 4.13 },
                new LeModel { BasicDia = 4.1250, Tpi = 6, Le = 4.13 },
                new LeModel { BasicDia = 4.1250, Tpi = 8, Le = 4.13 },
                new LeModel { BasicDia = 4.1250, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 4.1250, Tpi = 16, Le = 0.56 },

                new LeModel { BasicDia = 4.2500, Tpi = 4, Le = 4.25 },
                new LeModel { BasicDia = 4.2500, Tpi = 6, Le = 4.25 },
                new LeModel { BasicDia = 4.2500, Tpi = 8, Le = 4.25 },
                new LeModel { BasicDia = 4.2500, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 4.2500, Tpi = 16, Le = 0.56 },

                new LeModel { BasicDia = 4.3750, Tpi = 4, Le = 4.38 },
                new LeModel { BasicDia = 4.3750, Tpi = 6, Le = 4.38 },
                new LeModel { BasicDia = 4.3750, Tpi = 8, Le = 4.38 },
                new LeModel { BasicDia = 4.3750, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 4.3750, Tpi = 16, Le = 0.56 },

                new LeModel { BasicDia = 4.5000, Tpi = 4, Le = 4.50 },
                new LeModel { BasicDia = 4.5000, Tpi = 6, Le = 4.50 },
                new LeModel { BasicDia = 4.5000, Tpi = 8, Le = 4.50 },
                new LeModel { BasicDia = 4.5000, Tpi = 12, Le = 0.75 },
                new LeModel { BasicDia = 4.5000, Tpi = 16, Le = 0.56 }

            };
            return output;
        }



        public double CalculateLe(double basicDia, double tpi)
        {

            List<LeModel> values = PopulateLeValues();
            LeModel result = values.Where(x => x.BasicDia == basicDia && x.Tpi == tpi).FirstOrDefault();

            if (result == null)
            {
                return 0;
            }
            else
            {
                return result.Le;
            }

        }

    }
}

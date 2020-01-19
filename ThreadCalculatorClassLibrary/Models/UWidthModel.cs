using System;
using System.Collections.Generic;
using System.Linq;


namespace ThreadCalculatorClassLibrary
{
    public class UWidthModel
    {
        #region Public Properties

        public double Tpi { get; private set; }
        public string uCutWidth { get; private set; }
        public double width { get; private set; }

        #endregion



        // ====================================================
        //  RETURN WIDTH - BASED ON SELECTED UCUT WIDTH AND TPI
        // ====================================================

        /// <summary>
        /// WidthModel List 
        /// </summary>
        /// <returns>Returns nominal Width FOR UCut</returns>
        public List<UWidthModel> PopulateUWidthValues()
        {
            List<UWidthModel> output = new List<UWidthModel>
            {
                new UWidthModel { Tpi = 4, uCutWidth = "1.5p", width = 0.400 },
                new UWidthModel { Tpi = 4, uCutWidth = "2p", width = 0.500 },
                new UWidthModel { Tpi = 4, uCutWidth = "3p", width = 0.800 },

                new UWidthModel { Tpi = 4.5, uCutWidth = "1.5p", width = 0.400 },
                new UWidthModel { Tpi = 4.5, uCutWidth = "2p", width = 0.500 },
                new UWidthModel { Tpi = 4.5, uCutWidth = "3p", width = 0.800 },

                new UWidthModel { Tpi = 5, uCutWidth = "1.5p", width = 0.315 },
                new UWidthModel { Tpi = 5, uCutWidth = "2p", width = 0.400 },
                new UWidthModel { Tpi = 5, uCutWidth = "3p", width = 0.630 },

                new UWidthModel { Tpi = 6, uCutWidth = "1.5p", width = 0.250 },
                new UWidthModel { Tpi = 6, uCutWidth = "2p", width = 0.400 },
                new UWidthModel { Tpi = 6, uCutWidth = "3p", width = 0.500 },

                new UWidthModel { Tpi = 7, uCutWidth = "1.5p", width = 0.200 },
                new UWidthModel { Tpi = 7, uCutWidth = "2p", width = 0.315 },
                new UWidthModel { Tpi = 7, uCutWidth = "3p", width = 0.400 },

                new UWidthModel { Tpi = 8, uCutWidth = "1.5p", width = 0.200 },
                new UWidthModel { Tpi = 8, uCutWidth = "2p", width = 0.250 },
                new UWidthModel { Tpi = 8, uCutWidth = "3p", width = 0.400 },

                new UWidthModel { Tpi = 9, uCutWidth = "1.5p", width = 0.160 },
                new UWidthModel { Tpi = 9, uCutWidth = "2p", width = 0.200 },
                new UWidthModel { Tpi = 9, uCutWidth = "3p", width = 0.315 },

                new UWidthModel { Tpi = 10, uCutWidth = "1.5p", width = 0.160 },
                new UWidthModel { Tpi = 10, uCutWidth = "2p", width = 0.200 },
                new UWidthModel { Tpi = 10, uCutWidth = "3p", width = 0.315 },

                new UWidthModel { Tpi = 11, uCutWidth = "1.5p", width = 0.160 },
                new UWidthModel { Tpi = 11, uCutWidth = "2p", width = 0.200 },
                new UWidthModel { Tpi = 11, uCutWidth = "3p", width = 0.315 },

                new UWidthModel { Tpi = 12, uCutWidth = "1.5p", width = 0.125 },
                new UWidthModel { Tpi = 12, uCutWidth = "2p", width = 0.160 },
                new UWidthModel { Tpi = 12, uCutWidth = "3p", width = 0.250 },

                new UWidthModel { Tpi = 13, uCutWidth = "1.5p", width = 0.125 },
                new UWidthModel { Tpi = 13, uCutWidth = "2p", width = 0.160 },
                new UWidthModel { Tpi = 13, uCutWidth = "3p", width = 0.250 },

                new UWidthModel { Tpi = 14, uCutWidth = "1.5p", width = 0.100 },
                new UWidthModel { Tpi = 14, uCutWidth = "2p", width = 0.160 },
                new UWidthModel { Tpi = 14, uCutWidth = "3p", width = 0.200 },

                new UWidthModel { Tpi = 16, uCutWidth = "1.5p", width = 0.100 },
                new UWidthModel { Tpi = 16, uCutWidth = "2p", width = 0.125 },
                new UWidthModel { Tpi = 16, uCutWidth = "3p", width = 0.200 },

                new UWidthModel { Tpi = 18, uCutWidth = "1.5p", width = 0.080 },
                new UWidthModel { Tpi = 18, uCutWidth = "2p", width = 0.125 },
                new UWidthModel { Tpi = 18, uCutWidth = "3p", width = 0.160 },

                new UWidthModel { Tpi = 19, uCutWidth = "1.5p", width = 0.080 },
                new UWidthModel { Tpi = 19, uCutWidth = "2p", width = 0.125 },
                new UWidthModel { Tpi = 19, uCutWidth = "3p", width = 0.160 },

                new UWidthModel { Tpi = 20, uCutWidth = "1.5p", width = 0.080 },
                new UWidthModel { Tpi = 20, uCutWidth = "2p", width = 0.100 },
                new UWidthModel { Tpi = 20, uCutWidth = "3p", width = 0.160 },

                new UWidthModel { Tpi = 22, uCutWidth = "1.5p", width = 0.080 },
                new UWidthModel { Tpi = 22, uCutWidth = "2p", width = 0.100 },
                new UWidthModel { Tpi = 22, uCutWidth = "3p", width = 0.160 },

                new UWidthModel { Tpi = 24, uCutWidth = "1.5p", width = 0.063 },
                new UWidthModel { Tpi = 24, uCutWidth = "2p", width = 0.100 },
                new UWidthModel { Tpi = 24, uCutWidth = "3p", width = 0.125 },

                new UWidthModel { Tpi = 26, uCutWidth = "1.5p", width = 0.063 },
                new UWidthModel { Tpi = 26, uCutWidth = "2p", width = 0.080 },
                new UWidthModel { Tpi = 26, uCutWidth = "3p", width = 0.125 },

                new UWidthModel { Tpi = 28, uCutWidth = "1.5p", width = 0.050 },
                new UWidthModel { Tpi = 28, uCutWidth = "2p", width = 0.080 },
                new UWidthModel { Tpi = 28, uCutWidth = "3p", width = 0.125 },

                new UWidthModel { Tpi = 32, uCutWidth = "1.5p", width = 0.050 },
                new UWidthModel { Tpi = 32, uCutWidth = "2p", width = 0.063 },
                new UWidthModel { Tpi = 32, uCutWidth = "3p", width = 0.100 },

                new UWidthModel { Tpi = 36, uCutWidth = "1.5p", width = 0.040 },
                new UWidthModel { Tpi = 36, uCutWidth = "2p", width = 0.063 },
                new UWidthModel { Tpi = 36, uCutWidth = "3p", width = 0.080 },

                new UWidthModel { Tpi = 40, uCutWidth = "1.5p", width = 0.040 },
                new UWidthModel { Tpi = 40, uCutWidth = "2p", width = 0.063 },
                new UWidthModel { Tpi = 40, uCutWidth = "3p", width = 0.080 },

                new UWidthModel { Tpi = 44, uCutWidth = "1.5p", width = 0.032 },
                new UWidthModel { Tpi = 44, uCutWidth = "2p", width = 0.040 },
                new UWidthModel { Tpi = 44, uCutWidth = "3p", width = 0.063 },

                new UWidthModel { Tpi = 48, uCutWidth = "1.5p", width = 0.032 },
                new UWidthModel { Tpi = 48, uCutWidth = "2p", width = 0.040 },
                new UWidthModel { Tpi = 48, uCutWidth = "3p", width = 0.063 },

                new UWidthModel { Tpi = 56, uCutWidth = "1.5p", width = 0.020 },
                new UWidthModel { Tpi = 56, uCutWidth = "2p", width = 0.032 },
                new UWidthModel { Tpi = 56, uCutWidth = "3p", width = 0.050 },

                new UWidthModel { Tpi = 60, uCutWidth = "1.5p", width = 0.020 },
                new UWidthModel { Tpi = 60, uCutWidth = "2p", width = 0.032 },
                new UWidthModel { Tpi = 60, uCutWidth = "3p", width = 0.050 },

                new UWidthModel { Tpi = 64, uCutWidth = "1.5p", width = 0.020 },
                new UWidthModel { Tpi = 64, uCutWidth = "2p", width = 0.032 },
                new UWidthModel { Tpi = 64, uCutWidth = "3p", width = 0.050 },

                new UWidthModel { Tpi = 72, uCutWidth = "1.5p", width = 0.020 },
                new UWidthModel { Tpi = 72, uCutWidth = "2p", width = 0.032 },
                new UWidthModel { Tpi = 72, uCutWidth = "3p", width = 0.040 }




            };
            return output;
        }



        public double CalculateUWidth(double tpi, string ucutWidth)
        {

            List<UWidthModel> values = PopulateUWidthValues();
            UWidthModel result = values.Where(x => x.Tpi == tpi && x.uCutWidth == ucutWidth).FirstOrDefault();

            if (result == null)
            {
                return 0;
            }
            else
            {
                return result.width;
            }

        }

    }
}

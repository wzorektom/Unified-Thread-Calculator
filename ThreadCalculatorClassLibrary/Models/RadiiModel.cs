using System.Collections.Generic;
using System.Linq;


namespace ThreadCalculatorClassLibrary
{
    public class RadiiModel
    {

        public double Tpi { get; set; }
        public string uCutWidth { get; set; }       
        public double radii { get; set; }



        // =====================================================================
        //  RETURN LE - LENGTH OF ENGAGEMENT BASED ON SELECTED BASIC DIA AND tpi
        // =====================================================================

        public List<RadiiModel> PopulateLeValues()
        {
            List<RadiiModel> output = new List<RadiiModel>
            {
                new RadiiModel { Tpi = 4, uCutWidth = "1.5p", radii = 0.050 },
                new RadiiModel { Tpi = 4, uCutWidth = "2p", radii = 0.050 },
                new RadiiModel { Tpi = 4, uCutWidth = "3p", radii = 0.060 },

                new RadiiModel { Tpi = 4.5, uCutWidth = "1.5p", radii = 0.050 },
                new RadiiModel { Tpi = 4.5, uCutWidth = "2p", radii = 0.050 },
                new RadiiModel { Tpi = 4.5, uCutWidth = "3p", radii = 0.060 },

                new RadiiModel { Tpi = 5, uCutWidth = "1.5p", radii = 0.050 },
                new RadiiModel { Tpi = 5, uCutWidth = "2p", radii = 0.050 },
                new RadiiModel { Tpi = 5, uCutWidth = "3p", radii = 0.060 },

                new RadiiModel { Tpi = 6, uCutWidth = "1.5p", radii = 0.050 },
                new RadiiModel { Tpi = 6, uCutWidth = "2p", radii = 0.050 },
                new RadiiModel { Tpi = 6, uCutWidth = "3p", radii = 0.060 },

                new RadiiModel { Tpi = 7, uCutWidth = "1.5p", radii = 0.040 },
                new RadiiModel { Tpi = 7, uCutWidth = "2p", radii = 0.050 },
                new RadiiModel { Tpi = 7, uCutWidth = "3p", radii = 0.050 },

                new RadiiModel { Tpi = 8, uCutWidth = "1.5p", radii = 0.040 },
                new RadiiModel { Tpi = 8, uCutWidth = "2p", radii = 0.050 },
                new RadiiModel { Tpi = 8, uCutWidth = "3p", radii = 0.050 },

                new RadiiModel { Tpi = 9, uCutWidth = "1.5p", radii = 0.040 },
                new RadiiModel { Tpi = 9, uCutWidth = "2p", radii = 0.040 },
                new RadiiModel { Tpi = 9, uCutWidth = "3p", radii = 0.050 },

                new RadiiModel { Tpi = 10, uCutWidth = "1.5p", radii = 0.040 },
                new RadiiModel { Tpi = 10, uCutWidth = "2p", radii = 0.040 },
                new RadiiModel { Tpi = 10, uCutWidth = "3p", radii = 0.050 },

                new RadiiModel { Tpi = 11, uCutWidth = "1.5p", radii = 0.040 },
                new RadiiModel { Tpi = 11, uCutWidth = "2p", radii = 0.040 },
                new RadiiModel { Tpi = 11, uCutWidth = "3p", radii = 0.050 },

                new RadiiModel { Tpi = 12, uCutWidth = "1.5p", radii = 0.030 },
                new RadiiModel { Tpi = 12, uCutWidth = "2p", radii = 0.040 },
                new RadiiModel { Tpi = 12, uCutWidth = "3p", radii = 0.050 },

                new RadiiModel { Tpi = 13, uCutWidth = "1.5p", radii = 0.030 },
                new RadiiModel { Tpi = 13, uCutWidth = "2p", radii = 0.040 },
                new RadiiModel { Tpi = 13, uCutWidth = "3p", radii = 0.050 },

                new RadiiModel { Tpi = 14, uCutWidth = "1.5p", radii = 0.030 },
                new RadiiModel { Tpi = 14, uCutWidth = "2p", radii = 0.040 },
                new RadiiModel { Tpi = 14, uCutWidth = "3p", radii = 0.040 },

                new RadiiModel { Tpi = 16, uCutWidth = "1.5p", radii = 0.030 },
                new RadiiModel { Tpi = 16, uCutWidth = "2p", radii = 0.030 },
                new RadiiModel { Tpi = 16, uCutWidth = "3p", radii = 0.040 },

                new RadiiModel { Tpi = 18, uCutWidth = "1.5p", radii = 0.020 },
                new RadiiModel { Tpi = 18, uCutWidth = "2p", radii = 0.030 },
                new RadiiModel { Tpi = 18, uCutWidth = "3p", radii = 0.040 },

                new RadiiModel { Tpi = 19, uCutWidth = "1.5p", radii = 0.020 },
                new RadiiModel { Tpi = 19, uCutWidth = "2p", radii = 0.030 },
                new RadiiModel { Tpi = 19, uCutWidth = "3p", radii = 0.040 },

                new RadiiModel { Tpi = 20, uCutWidth = "1.5p", radii = 0.020 },
                new RadiiModel { Tpi = 20, uCutWidth = "2p", radii = 0.030 },
                new RadiiModel { Tpi = 20, uCutWidth = "3p", radii = 0.040 },

                new RadiiModel { Tpi = 22, uCutWidth = "1.5p", radii = 0.020 },
                new RadiiModel { Tpi = 22, uCutWidth = "2p", radii = 0.030 },
                new RadiiModel { Tpi = 22, uCutWidth = "3p", radii = 0.040 },

                new RadiiModel { Tpi = 24, uCutWidth = "1.5p", radii = 0.020 },
                new RadiiModel { Tpi = 24, uCutWidth = "2p", radii = 0.030 },
                new RadiiModel { Tpi = 24, uCutWidth = "3p", radii = 0.030 },

                new RadiiModel { Tpi = 26, uCutWidth = "1.5p", radii = 0.020 },
                new RadiiModel { Tpi = 26, uCutWidth = "2p", radii = 0.020 },
                new RadiiModel { Tpi = 26, uCutWidth = "3p", radii = 0.030 },

                new RadiiModel { Tpi = 28, uCutWidth = "1.5p", radii = 0.010 },
                new RadiiModel { Tpi = 28, uCutWidth = "2p", radii = 0.020 },
                new RadiiModel { Tpi = 28, uCutWidth = "3p", radii = 0.030 },

                new RadiiModel { Tpi = 32, uCutWidth = "1.5p", radii = 0.010 },
                new RadiiModel { Tpi = 32, uCutWidth = "2p", radii = 0.020 },
                new RadiiModel { Tpi = 32, uCutWidth = "3p", radii = 0.030 },

                new RadiiModel { Tpi = 36, uCutWidth = "1.5p", radii = 0.010 },
                new RadiiModel { Tpi = 36, uCutWidth = "2p", radii = 0.020 },
                new RadiiModel { Tpi = 36, uCutWidth = "3p", radii = 0.020 },

                new RadiiModel { Tpi = 40, uCutWidth = "1.5p", radii = 0.010 },
                new RadiiModel { Tpi = 40, uCutWidth = "2p", radii = 0.020 },
                new RadiiModel { Tpi = 40, uCutWidth = "3p", radii = 0.020 },

                new RadiiModel { Tpi = 44, uCutWidth = "1.5p", radii = 0.005 },
                new RadiiModel { Tpi = 44, uCutWidth = "2p", radii = 0.010 },
                new RadiiModel { Tpi = 44, uCutWidth = "3p", radii = 0.020 },

                new RadiiModel { Tpi = 48, uCutWidth = "1.5p", radii = 0.005 },
                new RadiiModel { Tpi = 48, uCutWidth = "2p", radii = 0.010 },
                new RadiiModel { Tpi = 48, uCutWidth = "3p", radii = 0.020 },

                new RadiiModel { Tpi = 56, uCutWidth = "1.5p", radii = 0.005 },
                new RadiiModel { Tpi = 56, uCutWidth = "2p", radii = 0.005 },
                new RadiiModel { Tpi = 56, uCutWidth = "3p", radii = 0.010 },

                new RadiiModel { Tpi = 60, uCutWidth = "1.5p", radii = 0.005 },
                new RadiiModel { Tpi = 60, uCutWidth = "2p", radii = 0.005 },
                new RadiiModel { Tpi = 60, uCutWidth = "3p", radii = 0.010 },

                new RadiiModel { Tpi = 64, uCutWidth = "1.5p", radii = 0.005 },
                new RadiiModel { Tpi = 64, uCutWidth = "2p", radii = 0.005 },
                new RadiiModel { Tpi = 64, uCutWidth = "3p", radii = 0.010 },

                new RadiiModel { Tpi = 72, uCutWidth = "1.5p", radii = 0.005 },
                new RadiiModel { Tpi = 72, uCutWidth = "2p", radii = 0.005 },
                new RadiiModel { Tpi = 72, uCutWidth = "3p", radii = 0.010 }




            };
            return output;
        }



        public double CalculateRadii(double tpi, string ucutWidth)
        {

            List<RadiiModel> values = PopulateLeValues();            
            RadiiModel result = values.Where(x => x.Tpi == tpi && x.uCutWidth == ucutWidth).FirstOrDefault();

            if (result == null)
            {
                return 0;
            }
            else
            {
                return result.radii;
            }

        }


    }
}

using System.Collections.Generic;
using System.Linq;


namespace ThreadCalculatorClassLibrary
{
    public class TPIModel
    {

        public double SelectedDia { get; private set; }
        List<string> List = new List<string>();


        // =====================================================================
        //  RETURN LE - LENGTH OF ENGAGEMENT BASED ON SELECTED BASIC DIA AND tpi
        // =====================================================================

        public List<TPIModel> setTPI()
        {
            List<TPIModel> output = new List<TPIModel>
            {
                //new TPIModel { SelectedDia = 0.0600, List = { "80" } }, to small to calculate - no info about TPI and UCut Width in BS1936:1952
                new TPIModel { SelectedDia = 0.0730, List = { "64", "72" } },
                new TPIModel { SelectedDia = 0.0860, List = { "56", "64" } },
                new TPIModel { SelectedDia = 0.0990, List = { "48", "56" } },
                new TPIModel { SelectedDia = 0.1120, List = { "40", "48" } },
                new TPIModel { SelectedDia = 0.1250, List = { "40", "44" } },
                new TPIModel { SelectedDia = 0.1380, List = { "32", "40" } },
                new TPIModel { SelectedDia = 0.1640, List = { "32", "36" } },
                new TPIModel { SelectedDia = 0.1900, List = { "24", "32" } },
                new TPIModel { SelectedDia = 0.2160, List = { "24", "28", "32" } },


                new TPIModel { SelectedDia = 0.2500, List = { "20", "28", "32" } },
                new TPIModel { SelectedDia = 0.3125, List = { "18", "20", "24", "28", "32" } },
                new TPIModel { SelectedDia = 0.3750, List = { "16", "20", "24", "28", "32" } },
                new TPIModel { SelectedDia = 0.4375, List = { "14", "16", "20", "28", "32" } },
                new TPIModel { SelectedDia = 0.5000, List = { "13", "16", "20", "28", "32" } },
                new TPIModel { SelectedDia = 0.5625, List = { "12", "16", "18", "20", "24", "28", "32" } },
                new TPIModel { SelectedDia = 0.6250, List = { "11", "12", "16", "18", "20", "24", "28", "32" } },
                new TPIModel { SelectedDia = 0.6875, List = { "12", "16", "20", "24", "28", "32" } },
                new TPIModel { SelectedDia = 0.7500, List = { "10", "12", "16", "20", "28", "32" } },
                new TPIModel { SelectedDia = 0.8125, List = { "12", "16", "20", "28", "32" } },
                new TPIModel { SelectedDia = 0.8750, List = { "9", "12", "14", "16", "20", "28", "32" } },
                new TPIModel { SelectedDia = 0.9375, List = { "12", "16", "20", "28", "32" } },
                new TPIModel { SelectedDia = 1.0000, List = { "8", "12", "16", "20", "28", "32" } },
                new TPIModel { SelectedDia = 1.0625, List = { "8", "12", "16", "18", "20", "28" } },
                new TPIModel { SelectedDia = 1.1250, List = { "7", "8", "12", "16", "18", "20", "28" } },
                new TPIModel { SelectedDia = 1.1875, List = { "8", "12", "16", "18", "20", "28" } },
                new TPIModel { SelectedDia = 1.2500, List = { "7", "8", "12", "16", "18", "20", "28" } },
                new TPIModel { SelectedDia = 1.3125, List = { "8", "12", "16", "18", "20", "28" } },
                new TPIModel { SelectedDia = 1.3750, List = { "6", "8", "12", "16", "18", "20", "28" } },
                new TPIModel { SelectedDia = 1.4375, List = { "6", "8", "12", "16", "18", "20", "28" } },
                new TPIModel { SelectedDia = 1.5000, List = { "6", "8", "12", "16", "18", "20", "28" } },
                new TPIModel { SelectedDia = 1.5625, List = { "6", "8", "12", "16", "18", "20" } },
                new TPIModel { SelectedDia = 1.6250, List = { "6", "8", "12", "16", "18", "20" } },
                new TPIModel { SelectedDia = 1.6875, List = { "6", "8", "12", "16", "18", "20" } },
                new TPIModel { SelectedDia = 1.7500, List = { "5", "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 1.8125, List = { "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 1.8750, List = { "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 1.9375, List = { "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 2.0000, List = { "4.5", "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 2.1250, List = { "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 2.2500, List = { "4.5", "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 2.3750, List = { "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 2.5000, List = { "4", "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 2.6250, List = { "4", "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 2.7500, List = { "4", "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 2.8750, List = { "4", "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 3.0000, List = { "4", "6", "8", "12", "16", "20" } },
                new TPIModel { SelectedDia = 3.1250, List = { "4", "6", "8", "12", "16" } },
                new TPIModel { SelectedDia = 3.2500, List = { "4", "6", "8", "12", "16" } },
                new TPIModel { SelectedDia = 3.3750, List = { "4", "6", "8", "12", "16" } },
                new TPIModel { SelectedDia = 3.5000, List = { "4", "6", "8", "12", "16" } },
                new TPIModel { SelectedDia = 3.6250, List = { "4", "6", "8", "12", "16" } },
                new TPIModel { SelectedDia = 3.7500, List = { "4", "6", "8", "12", "16" } },
                new TPIModel { SelectedDia = 3.8750, List = { "4", "6", "8", "12", "16" } },
                new TPIModel { SelectedDia = 4.0000, List = { "4", "6", "8", "12", "16" } },
                new TPIModel { SelectedDia = 4.1250, List = { "4", "6", "8", "12", "16" } },
                new TPIModel { SelectedDia = 4.2500, List = { "4", "6", "8", "12", "16" } },
                new TPIModel { SelectedDia = 4.3750, List = { "4", "6", "8", "12", "16" } },
                new TPIModel { SelectedDia = 4.5000, List = { "4", "6", "8", "12", "16" } }
                



            };
            return output;
        }



        public List<string> PopulateTPI(double selectedDia)
        {

            List<TPIModel> values = setTPI();
            TPIModel result = values.Where(x => x.SelectedDia == selectedDia).FirstOrDefault();

            return result.List;
            

        }



    }
}

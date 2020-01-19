using System;
using System.Collections.Generic;
using System.Linq;


namespace ThreadCalculatorClassLibrary
{
    public class Below025Model
    {
        #region Public Properties

        public string CodeBasicDia { get; private set; }
        public double BasicDia { get; private set; }

        #endregion




        #region Get BasicDia based on the thread code - for threads below 0.25" code is displayed in the combobox from 1 to 12

        public List<Below025Model> PopulateBasicDiaValues()
        {
            List<Below025Model> output = new List<Below025Model>
            {
                new Below025Model { CodeBasicDia = "#0", BasicDia = 0.0600 }, //to small to calculate - no info about TPI and UCut Width in BS1936:1952

                new Below025Model { CodeBasicDia = "#1", BasicDia = 0.0730 },
                new Below025Model { CodeBasicDia = "#2", BasicDia = 0.0860 },

                new Below025Model { CodeBasicDia = "#3", BasicDia = 0.0990 },
                new Below025Model { CodeBasicDia = "#4", BasicDia = 0.1120 },

                new Below025Model { CodeBasicDia = "#5", BasicDia = 0.1250 },
                new Below025Model { CodeBasicDia = "#6", BasicDia = 0.1380 },

                new Below025Model { CodeBasicDia = "#8", BasicDia = 0.1640 },
                new Below025Model { CodeBasicDia = "#10", BasicDia = 0.1900 },

                new Below025Model { CodeBasicDia = "#12", BasicDia = 0.2160 },

            };
            return output;
        }


        public double CalculateBasicDia(string codeBasicDia)
        {

            List<Below025Model> values = PopulateBasicDiaValues();
            Below025Model result = values.Where(x => x.CodeBasicDia == codeBasicDia).FirstOrDefault();

            return result.BasicDia;

        }

        #endregion



    }
}

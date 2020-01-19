

namespace ThreadCalculatorClassLibrary
{
    public class Formula
    {
        #region Public Properties


       Below025Model test = new Below025Model();


        // Allowances for PS309, Other Coating and default
        public static double Allowance_2Thou { get; } = 0.002;
        public static double Allowance_4Thou { get; } = 0.004;
        public static double Allowance_9Thou { get; } = 0.009;

        // Thread Type
        public static string ThreadTypeMale { get; } = "EXTERNAL";
        public static string ThreadTypeFemale { get; } = "INTERNAL";

        public double DMax { get; set; }
        public double DMin { get; set; }
        public double Radii { get; set; }
        public double BasicDia { get; set; }
        public double TPI { get; set; }
        public double Le { get; set; }
        public double Pitch { get; set; }
        public double Allowance { get; set; }
        public double BasicEffectiveDia { get; set; }
        public double Triangle { get; set; }
        public string ClassThread { get; set; }
        public double ModelToWidth { get; set; }
        public double ModelToD { get; set; }
        public double ModelTo { get; set; }
        public double UCutMax { get; set; }

        // Currently selected U.Cut Width - 1p, 2p, 3p
        public string UCutWidth { get; set; }
        public double UCutWidthMax { get; set; }
        public double UCutWidthMin { get; set; }
        public string CoatingOther { get; set; }
        public string CoatingPS309 { get; set; }

        public string NoCoating { get; set; }

        #endregion




        // HOW TO CALCULATE UNDERCUTS - BS1608
        // Use Table 1 to find the TPI
        // For example, to get the width 1.5p for TPI=20, find the TPI value and go to column 4 Table 1, the width is: W = 0.08.
        // With 0.08 go to Table 4 and find nominal width W column, the tolerance for W=0.08 is +- 0.005 and radius is 0.02.
        // Check the tolerance on D for internal and external threads on Table 3.

        #region Calculate Width Max based on U.Cut Max

        /// <summary>
        /// Calculate Width Max value based on U.Cut Max - DMax
        /// </summary>
        /// <param name="uCutMax">U.Cut Max value</param>
        /// <returns>Max Width</returns>
        public double CalculateWidthMax(double uCutMax)
        {

            if (uCutMax >= 0.02 && uCutMax <= 0.05)
            {
                return uCutMax - 0.003;
            }
            else if (uCutMax >= 0.063 && uCutMax <= 0.08)
            {
                return uCutMax - 0.005;
            }
            else if (uCutMax >= 0.1 && uCutMax <= 0.4)
            {
                return uCutMax - 0.010;
            }
            else if (uCutMax >= 0.5 && uCutMax <= 0.8)
            {
                return uCutMax - 0.015;
            }
            else
            {
                return 0;
            }
        }

        #endregion

        #region Calculate Width Min based on U.Cut Max

        /// <summary>
        /// Calculate Width Min based on U.Cut Max
        /// </summary>
        /// <param name="uCutMax"></param>
        /// <returns></returns>
        public double CalculateWidthMin(double uCutMax)
        {

            if (uCutMax >= 0.02 && uCutMax <= 0.05)
            {
                return uCutMax + 0.003;
            }
            else if (uCutMax >= 0.063 && uCutMax <= 0.08)
            {
                return uCutMax + 0.005;
            }
            else if (uCutMax >= 0.1 && uCutMax <= 0.4)
            {
                return uCutMax + 0.010;
            }
            else if (uCutMax >= 0.5 && uCutMax <= 0.8)
            {
                return uCutMax + 0.015;
            }
            else
            {
                return 0;
            }
        }

        #endregion



        #region Calculate Model To for Width based on Max Width and Min Width

        /// <summary>
        /// Calculate Model To for Width
        /// </summary>
        /// <param name="widthMax">Max Width</param>
        /// <param name="widthMin">Min Width</param>
        /// <returns>Model To for Width</returns>
        public double CalculateModeltoWidth(double widthMax, double widthMin)
        {
            return (widthMax + widthMin) / 2;
        }


        #endregion

        #region Calculate Model To for D based on D Max and D Min

        /// <summary>
        /// Calculate Model To for D 
        /// </summary>
        /// <param name="dMax">D Max</param>
        /// <param name="dMin">D Min</param>
        /// <returns>Model To for D</returns>
        public double CalculateModeltoD(double dMax, double dMin)
        {
            return (dMax + dMin) / 2;
        }

        #endregion

        #region Return Thread Type based on currenlty selected Thread Class

        /// <summary>
        /// Return Thread Type value based on selected Thread Class
        /// </summary>
        /// <param name="threadClass">Currently selected Thread Class</param>
        /// <returns>Thread Type e.g. Internal or External</returns>
        public static string PopulateThreadType(string threadClass)
        {
            if (threadClass == "1A" || threadClass == "2A" || threadClass == "3A")
            {
                return ThreadTypeMale;
            }
            else
            {
                return ThreadTypeFemale;
            }
        }

        #endregion





    }
}

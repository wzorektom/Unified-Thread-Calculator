using System;

namespace ThreadCalculatorClassLibrary
{
    public class Male : Formula
    {

        #region Public Properties

        public double MajorMax { get; set; }
        public double MajorTolerance { get; set; }
        public double MajorMin { get; set; }
        public double EffectiveMax { get; set; }
        public double EffectiveTolerance { get; set; }
        public double EffectiveMin { get; set; }
        public double MinorMax { get; set; }
        public double MinorTolerance { get; set; }
        public double MinorMin { get; set; }


        /// <summary>
        /// Set Allowance Textbox
        /// </summary>
        //public string GetA { get; } = "Thread Size <0.5\" Male - ALLOWANCE = NONE";
        public string GetA { get; } = "Thread Size <0.5\" Male - Group A: PS300 MMC STA = 0\" OR No Coating  |  ALLOWANCE = NONE";


        //public string GetB { get; } = "Thread Size <0.5\" Male - COATED TO PS309 = -0.009\"";
        //public string GetB { get; } = "Thread Size <0.5\" Male - Group C: PS300 MMC STA \u2265 .001\" = -0.009\"";

        public string GetB { get; } = "Thread Size <0.5\" Male - Group C: PS300 MMC STA \u2265 .001\"  |  ALLOWANCE = -0.009\"";


        //public string GetC { get; } = "Thread Size <0.5\" Male - ANY COATING EXCEPT PS309 = -0.004\"";
        public string GetC { get; } = "Thread Size <0.5\" Male - Group B: 0\" < PS300 MMC STA < .001\"  |  ALLOWANCE = -0.004\"";


        // Unicode used for Larger than or equal sign - \u2265 - >=
        //public string GetD { get; } = "Thread Size \u22650.5\" Male - ALLOWANCE = -0.002\"";
        public string GetD { get; } = "Thread Size \u22650.5\" Male - Group A: PS300 MMC STA = 0\" OR No Coating  |  ALLOWANCE = -0.002\"";

        // Unicode used for Larger than or equal sign - \u2265 - >=
        //public string GetE { get; } = "Thread Size \u22650.5\" Male - COATED TO PS309 = -0.009\"";
        public string GetE { get; } = "Thread Size \u22650.5\" Male - Group C: PS300 MMC STA \u2265 .001\"  |  ALLOWANCE = -0.009\"";

        // Unicode used for Larger than or equal sign - \u2265 - >=
        //public string GetF { get; } = "Thread Size \u22650.5\" Male - ANY COATING EXCEPT PS309 = -0.004\"";
        public string GetF { get; } = "Thread Size \u22650.5\" Male - Group B: 0\" < PS300 MMC STA < .001\"  |  ALLOWANCE = -0.004\"";


        // Force the user to select at least one coating Group type before performing calculations
        public string GetG { get; } = "SELECT COATING TYPE - VIEW ALLOWANCE TABLE";

        #endregion

       
        //============================================================
        // CALCULATIONS FOR MAJOR, EFFECTIVE AND MINOR - MALE THREAD  
        //============================================================

        #region Calculate Major Max

        /// <summary>
        /// Calculate Major Max based on the selected Coating e.g. PS309 or Other Coating type and the Thread Size
        /// </summary>
        /// <returns></returns>
        public double MajorMax_A()
        {

            if (BasicDia >= 0.5 & NoCoating == "Yes") // >= 0.5 Allowance -0.002"
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return BasicDia - Allowance - Allowance_2Thou;
                }
                else
                {
                    return BasicDia - Allowance_2Thou;
                }
            }
            else if ((BasicDia < 0.5 || BasicDia >= 0.5) & CoatingOther == "Yes" ) // < 0.5 or >= 0.5 Allowance - 0.004"
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return BasicDia - Allowance - Allowance_4Thou;
                }
                else
                {
                    return BasicDia - Allowance_4Thou;
                }
            }
            else if ((BasicDia < 0.5 || BasicDia >= 0.5) & CoatingPS309 == "Yes") // < 0.5 or >= 0.5 Allowance -0.009"
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return BasicDia - Allowance - Allowance_9Thou;
                }
                else
                {
                    return BasicDia - Allowance_9Thou;
                }
            }
            else  // (BasicDia < 0.5 & CoatingOther == "No" & CoatingPS309 == "No") // No Allowance
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return BasicDia - Allowance;
                }
                else
                {
                    return BasicDia;
                }
            }
        }

        #endregion

        #region Calculate Major Tolerance

        // MAJOR TOLERANCE
        public double MajorTolerance_A()
        {
            if (ClassThread == "1A")
            {
                return Math.Round((0.09 * Math.Pow(Pitch * Pitch, (1F / 3F))), 4);
            }
            else
            {
                
                return Math.Round((0.06 * Math.Pow(Pitch * Pitch, (1F / 3F))), 4);
            }
        }

        #endregion

        #region Calculate Major Min

        // MAJOR MIN 
        public double MajorMin_A(double MajorMax)
        {
            return (MajorMax - MajorTolerance_A());
        }

        #endregion


        #region Calculate Effective Max

        // Effective Max for Male
        public double EffectiveMax_A()
        {
            if (BasicDia >= 0.5 & NoCoating == "Yes") // >= 0.5 Allowance -0.002"
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return BasicEffectiveDia - Allowance - Allowance_2Thou;
                }
                else
                {
                    return BasicEffectiveDia - Allowance_2Thou;
                }
            }
            else if ((BasicDia < 0.5 || BasicDia >= 0.5) & CoatingOther == "Yes") // < 0.5 or >= 0.5 Allowance - 0.004"
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return BasicEffectiveDia - Allowance - Allowance_4Thou;
                }
                else
                {
                    return BasicEffectiveDia - Allowance_4Thou;
                }
            }
            else if ((BasicDia < 0.5 || BasicDia >= 0.5) & CoatingPS309 == "Yes") // < 0.5 or >= 0.5 Allowance -0.009"
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return BasicEffectiveDia - Allowance - Allowance_9Thou;
                }
                else
                {
                    return BasicEffectiveDia - Allowance_9Thou;
                }
            }
            else  // (BasicDia < 0.5 & CoatingOther == "No" & CoatingPS309 == "No") // No Allowance
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return BasicEffectiveDia - Allowance;
                }
                else
                {
                    return BasicEffectiveDia;
                }
            }
        }

        #endregion

        #region Calculate Effective Tolerance

        // Effective Tolerance
        public double EffectiveTolerance_A()
        {
            if (ClassThread == "1A")
            {
                return Math.Round(((1.50 * (0.0015 * Math.Pow(BasicDia, 1F / 3F) + 0.0015 * Math.Sqrt(Le) + 0.015 * Math.Pow((Pitch * Pitch), 1F / 3F)))), 4);
                //return ((1.50 * (0.0015 * Math.Pow(BasicDia, 1F / 3F) + 0.0015 * Math.Sqrt(Le) + 0.015 * Math.Pow((Pitch * Pitch), 1F / 3F))));
            }
            else if (ClassThread == "2A")
            {
                // Number 12 size TPI 32 and class 2A see table 11 in BS1580-3:2007
                if (BasicDia == 0.2160 && TPI == 32)
                {
                    return 0.0031;
                }
                return Math.Round(((0.0015 * Math.Pow(BasicDia, 1F / 3F) + 0.0015 * Math.Sqrt(Le) + 0.015 * Math.Pow((Pitch * Pitch), 1F / 3F))), 4);
                //return ((0.0015 * Math.Pow(BasicDia, 1F / 3F) + 0.0015 * Math.Sqrt(Le) + 0.015 * Math.Pow((Pitch * Pitch), 1F / 3F)));
            }
            else
            {
                return Math.Round(((0.75 * ((0.0015 * Math.Pow(BasicDia, 1F / 3F) + 0.0015 * Math.Sqrt(Le) + 0.015 * Math.Pow((Pitch * Pitch), 1F / 3F))))), 4);
                //return ((0.75 * ((0.0015 * Math.Pow(BasicDia, 1F / 3F) + 0.0015 * Math.Sqrt(Le) + 0.015 * Math.Pow((Pitch * Pitch), 1F / 3F)))));
            }
        }

        #endregion

        #region Calculate Effective Min

        // Effective Minimum for Male
        public double EffectiveMin_A(double EffectiveMax)
        {
            return EffectiveMax - EffectiveTolerance_A();
        }

        #endregion


        #region Calculate Minor Max

        // Minor Max
        public double MinorMax_A()
        {
            if (BasicDia >= 0.5 & NoCoating == "Yes") // >= 0.5 Allowance -0.002"
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return Math.Round(((BasicDia - Allowance - (1.416 * Triangle)) - Allowance_2Thou), 4);
                }
                else
                {
                    return Math.Round(((BasicDia - (1.416 * Triangle)) - Allowance_2Thou), 4);
                }
            }
            else if ((BasicDia < 0.5 || BasicDia >= 0.5) & CoatingOther == "Yes" ) // < 0.5 or >= 0.5 Allowance - 0.004"
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return Math.Round(((BasicDia - Allowance - (1.416 * Triangle)) - Allowance_4Thou), 4);
                }
                else
                {
                    return Math.Round(((BasicDia - (1.416 * Triangle)) - Allowance_4Thou), 4);
                }
            }
            else if ((BasicDia < 0.5 || BasicDia >= 0.5) & CoatingPS309 == "Yes") // < 0.5 or >= 0.5 Allowance -0.009"
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return Math.Round(((BasicDia - Allowance - (1.416 * Triangle)) - Allowance_9Thou), 4);
                }
                else
                {
                    return Math.Round(((BasicDia - (1.416 * Triangle)) - Allowance_9Thou), 4);
                }
            }
            else  // (BasicDia < 0.5 & CoatingOther == "No" & CoatingPS309 == "No") // No Allowance
            {
                if (ClassThread == "1A" || ClassThread == "2A")
                {
                    return Math.Round((BasicDia - Allowance - (1.416 * Triangle)), 4);
                }
                else
                {
                    return Math.Round((BasicDia - (1.416 * Triangle)), 4);
                }
            }
        }

        #endregion

        #region Calculate Minor Tolerance

        // Minor Tolerance
        public double MinorTollerance_A(double EffectiveTolerance)
        {
            // Number 12 size TPI 32 and class 2A see table 11 in BS1580-3:2007
            if (BasicDia == 0.2160 && TPI == 32 && ClassThread == "2A")
            {
                return 0.0054;
            }
            // Number 12 size TPI 32 and class 3A see table 11 in BS1580-3:2007
            else if (BasicDia == 0.2160 && TPI == 32 && ClassThread == "3A")
            {
                return 0.0047;
            }
            return Math.Round((EffectiveTolerance + Triangle / 12), 4);
        }

        #endregion

        #region Calculate Minor Min

        // Minor Min
        public double MinorMin_A(double MinorMax, double MinorTollerance)
        {
            return Math.Round((MinorMax - MinorTollerance), 4);
        }

        #endregion



        //========================================
        // CALCULATIONS FOR MODELTO, DMAX AND DMIN 
        //========================================

        #region Calculate ModelTo based on MajorMax and MajorMin

        /// <summary>
        /// Calculate ModelTo given MajorMax and MajorMin values
        /// </summary>
        /// <param name="majorMax">MajorMax value for Male thread</param>
        /// <param name="majorMin">MajorMin value for Male thread</param>
        /// <returns>ModelTo for Male</returns>
        public double CalculateModelto_A(double majorMax, double majorMin)
        {
            return (majorMax + majorMin) / 2;
        }

        #endregion

        #region Calculate DMax (U.Cut Max) value given MinorMin and check which formula to use based on the given threshold (see BS 1936:1952)

        /// <summary>
        /// Calculate DMax (U.Cut Max) given MinorMin value
        /// </summary>
        /// <param name="MinorMin">MinorMin value for Male thread</param>
        /// <returns>Dmax (U.Cut Max) value for Male</returns>
        public double DMax_A(double MinorMin)
        {
            if (MinorMin < 2.0)
            {
                return Math.Floor(MinorMin / 0.005) * 0.005;
            }
            else
            {
                return Math.Floor(MinorMin / 0.010) * 0.010;
            }
        }

        #endregion

        #region Calculate DMin (U.Cut Min) value given MinorMin and check which formula to use based on given threshold (see BS 1936:1952)

        /// <summary>
        /// Calculate DMin (U.Cut Min) given MinorMin value
        /// </summary>
        /// <param name="MinorMin">MinorMin value for Male thread</param>
        /// <returns>DMin (U.Cut Min) value for Male</returns>
        public double DMin_A(double MinorMin)
        {
            if (MinorMin < 2.0)
            {
                MinorMin = Math.Floor(MinorMin / 0.005) * 0.005;

                if (MinorMin >= 0.060 && MinorMin < 0.100)
                {
                    return (MinorMin - 0.003);
                }
                else if (MinorMin >= 0.100 && MinorMin < 0.300)
                {
                    return (MinorMin - 0.004);
                }
                else if (MinorMin >= 0.300 && MinorMin < 0.600)
                {
                    return (MinorMin - 0.006);
                }
                else if (MinorMin >= 0.600 && MinorMin < 1.250)
                {
                    return (MinorMin - 0.008);
                }
                else // (MinorMin >= 1.25 & MinorMin < 2.8)
                {
                    return (MinorMin - 0.010);
                }
            }
            else
            {
                MinorMin = Math.Floor(MinorMin / 0.010) * 0.010;

                if (MinorMin >= 1.250 && MinorMin < 2.800)
                {
                    return (MinorMin - 0.010);
                }
                else if (MinorMin >= 2.800 && MinorMin < 6.0)
                {
                    return (MinorMin - 0.015);
                }
                else // (MinorMin >= 6.0 & MinorMin < 12.0)
                {
                    return (MinorMin - 0.020);
                }
            }
        }

        #endregion



        //=======================================
        // POPULATE ALLOWANCE AND RESULTS TEXTBOX
        //=======================================

        #region Populate Allowance Textbox based on diameter and selected coating type

        /// <summary>
        /// Populate Allowance Textbox based on the diameter and selected coating
        /// </summary>
        /// <returns>Allowance text</returns>
        public string PopulateAllowance()
        {
            if (BasicDia < 0.5)
            {
                if (NoCoating == "Yes")
                {
                    return GetA;
                }
                else if (CoatingPS309 == "Yes")
                {
                    return GetB;
                }
                else if (CoatingOther == "Yes")
                {
                    return GetC;
                }
                else
                {
                    return GetG;
                }

            }
            else
            {
                if (NoCoating == "Yes")
                {
                    return GetD;
                }
                else if (CoatingPS309 == "Yes")
                {
                    return GetE;
                }
                else if (CoatingOther == "Yes")
                {
                    return GetF;
                }
                else
                {
                    return GetG;
                }
            }
        }

        #endregion

        #region Populate the results TextBox (consider updating this to simplify the process)

        /// <summary>
        /// Populate the results Textbox
        /// </summary>
        ThreadDesignationModel Design = new ThreadDesignationModel();
        public string[] resultList()
        {
            if (BasicDia < 0.5 & NoCoating == "Yes")
            {

                string[] list = {

                       BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI) + "-" +  ClassThread + ", BS1580",

                       "\r\n",
                       "MAJOR DIA.  " +  MajorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MajorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture),

                       "\r\n",
                       "EFF. DIA.   " +  EffectiveMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + EffectiveMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture),

                       "\r\n",
                       "MINOR DIA.  " +  MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture),

                            };

                return list;

            }
            else if (BasicDia < 0.5 & CoatingPS309 == "Yes") // Off 9 thou
            {
                string[] list = {

                       BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI)  + "-" +  ClassThread + ", BS1580",

                       "\r\n",
                       "BEFORE COATING:",

                       "\r\n",
                       "MAJOR DIA.  " +  MajorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MajorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "EFF. DIA.   " + EffectiveMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + EffectiveMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "MINOR DIA.  " +  MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                            };

                return list;
            }
            else if (BasicDia < 0.5 & CoatingOther == "Yes") // off 4 thou
            {
                string[] list = {

                       BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI) + "-" +  ClassThread + ", BS1580",

                       "\r\n",
                       "BEFORE COATING:",        

                       "\r\n",
                       "MAJOR DIA.  " +  MajorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MajorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "EFF. DIA.   " + EffectiveMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + EffectiveMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "MINOR DIA.  " +  MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                            };

                return list;
            }
            else if (BasicDia >= 0.5 & NoCoating == "Yes")
            {
                string[] list = {

                       BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI) + "-" +  ClassThread + ", BS1580",

                       "\r\n",
                       "MAJOR DIA.  " + MajorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MajorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "EFF. DIA.   " + EffectiveMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " -  " + EffectiveMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "MINOR DIA.   " + MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " -  " + MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                            };

                return list;

            }
            else if (BasicDia >= 0.5 & CoatingPS309 == "Yes") // off 9 thou
            {
                string[] list1 = {

                       BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI) + "-" +  ClassThread + ", BS1580",

                       "\r\n",
                       "BEFORE COATING:",

                       "\r\n",
                       "MAJOR DIA.  " + "  " + MajorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MajorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "EFF. DIA.   " + "  " + EffectiveMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + EffectiveMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "MINOR DIA.  " + "  " +  MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                            };

                return list1;

            }
            else if (BasicDia >= 0.5 & CoatingOther == "Yes") // Off 4 thou
            {
                
                string[] list = {

                    BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI) + "-" +  ClassThread + ", BS1580",

                    "\r\n",
                    "BEFORE COATING:",

                    "\r\n",
                    "MAJOR DIA.  " +  MajorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MajorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                    "\r\n",
                    "EFF. DIA.   " + EffectiveMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + EffectiveMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                    "\r\n",
                    "MINOR DIA.  " + MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                        };

                return list;

            }
            else
            {
                string[] list = {

                       "0.0000" +"-" + "00" + " " + "None" + "-" +  "None" + ", None",

                       "\r\n",
                       "MAJOR DIA.        " + "0.0000" + " - " + "0.0000",

                       "\r\n",
                       "EFF. DIA.              " + "0.0000" + " - " + "0.0000",

                       "\r\n",
                       "MINOR DIA.        " +  "0.0000" + " - " + "0.0000",

                            };

                return list;
            }


        }

        #endregion



    }
}

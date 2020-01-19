using System;

namespace ThreadCalculatorClassLibrary
{
    public class Female : Formula
    {

        #region Public Properties


        public string MajorMax { get; set; }
        public string MajorTolerance { get; set; }
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
        //public string GetA { get; } = "Thread Size <0.5\" Female - ALLOWANCE = +0.002\"";
        public string GetA { get; } = "Thread Size <0.5\" Female - Group A: PS300 MMC STA = 0\" OR No Coating  |  ALLOWANCE = +0.002\"";

        //public string GetB { get; } = "Thread Size <0.5\" Female - COATED TO PS309 = +0.002\"";
        public string GetB { get; } = "Thread Size <0.5\" Female - Group C: PS300 MMC STA \u2265 .001\"  |  ALLOWANCE = +0.002\"";


        //public string GetC { get; } = "Thread Size <0.5\" Female - ANY COATING EXCEPT PS309 = +0.002\"";
        public string GetC { get; } = "Thread Size <0.5\" Female - Group B: 0\" < PS300 MMC STA < .001\"  |  ALLOWANCE = +0.002\"";


        // Unicode used for Larger than or equal sign - \u2265 - >=
        //public string GetD { get; } = "Thread Size \u22650.5\" Female - ALLOWANCE = NONE";
        public string GetD { get; } = "Thread Size \u22650.5\" Female - Group A: PS300 MMC STA = 0\" OR No Coating  |  ALLOWANCE = NONE";


        // Unicode used for Larger than or equal sign - \u2265 - >=
        //public string GetE { get; } = "Thread Size \u22650.5\" Female - COATED TO PS309 = NONE";
        public string GetE { get; } = "Thread Size \u22650.5\" Female - Group C: PS300 MMC STA \u2265 .001\"  |  ALLOWANCE = NONE";


        // Unicode used for Larger than or equal sign - \u2265 - >=
        //public string GetF { get; } = "Thread Size \u22650.5\" Female - ANY COATING EXCEPT PS309 = NONE";
        public string GetF { get; } = "Thread Size \u22650.5\" Female - Group B: 0\" < PS300 MMC STA < .001\"  |  ALLOWANCE = NONE";

        // Force the user to select at least one coating Group type before performing calculations
        public string GetG { get; } = "SELECT COATING TYPE - VIEW ALLOWANCE TABLE";


        /// <summary>
        /// Tolerance variables for Minor
        /// </summary>
        public double For12TPI { get; set; }
        public double For13to80TPI { get; set; }
        public double MinorToleranceBase { get; set; }

        #endregion


        //============================================================
        // CALCULATIONS FOR MAJOR, EFFECTIVE AND MINOR - FEMALE THREAD  
        //============================================================

        #region Calculate Major Max
        // Major Max - Not applicable for Female threads
        public string MajorMax_B()
        {
            return "--------";
        }

        #endregion

        #region Calculate Major Tolerance

        // Major Tolerance - Not applicable for Female threads
        public string MajorTolerance_B()
        {
            return "--------";
        }

        #endregion

        #region Calculate Major Min
        // Major Min
        public double MajorMin_B()
        {
            if (BasicDia < 0.5) // < 0.5 Allowance -0.002"
            {
                return BasicDia + Allowance_2Thou;
            }
            else  // >= 0.5 No Allowance
            {
                return BasicDia;
            }
        }

        #endregion


        #region Calculate Effective Max
        //Calculate Effective Max
        public double EffectiveMax_B()
        {
            return EffectiveMin_B() + EffectiveTolerance_B();
        }

        #endregion

        #region Calcuate Effective Min

        // Calculate Effective Min
        public double EffectiveMin_B()
        {
            if (BasicDia < 0.5) // < 0.5 Allowance -0.002" (inherited from Formula Class)
            {
                return BasicEffectiveDia + Allowance_2Thou;
            }
            else  // >= 0.5 No Allowance
            {
                return BasicEffectiveDia;
            }
        }

        #endregion

        #region Calculate Effective Tolerance
        // Calcuate Effective Tolerance
        public double EffectiveTolerance_B()
        {
            if (ClassThread == "1B")
            {
                return Math.Round(((1.95 * (0.0015 * Math.Pow(BasicDia, 1F / 3F) + 0.0015 * Math.Sqrt(Le) + 0.015 * Math.Pow((Pitch * Pitch), 1F / 3F)))), 4);
            }
            else if (ClassThread == "2B")
            {
                return Math.Round(((1.3 * (0.0015 * Math.Pow(BasicDia, 1F / 3F) + 0.0015 * Math.Sqrt(Le) + 0.015 * Math.Pow((Pitch * Pitch), 1F / 3F)))), 4);
            }
            else // 3B
            {
                return Math.Round(((0.975 * (0.0015 * Math.Pow(BasicDia, 1F / 3F) + 0.0015 * Math.Sqrt(Le) + 0.015 * Math.Pow((Pitch * Pitch), 1F / 3F)))), 4);
            }
        }

        #endregion


        #region Calculate Minor Max

        // Calculate Minor Max
        public double MinorMax_B(double MinorMin, double MinorTollerance)
        {   
            return Math.Round((MinorMin + MinorTollerance), 4);
        }

        #endregion

        #region Calculate Minor Min
        // Calculate Minor Min
        public double MinorMin_B()
        {
            if (BasicDia < 0.5) // < 0.5 Allowance -0.002"
            {
                if (BasicDia == 0.1380 && TPI == 32)
                {
                    return 0.1040 + Allowance_2Thou;
                }
                else if (BasicDia == 0.1640 && TPI == 32)
                {
                    return 0.1300 + Allowance_2Thou;
                }
                else if (BasicDia == 0.1900 && TPI == 32)
                {
                    return 0.1560 + Allowance_2Thou;
                }
                else if (BasicDia == 0.2160 && TPI == 28)
                {
                    return 0.1770 + Allowance_2Thou;
                }
                else if (BasicDia == 0.2160 && TPI == 32)
                {
                    return 0.1820 + Allowance_2Thou;
                }

                return Math.Round(((BasicDia - (1.25 * Triangle)) + Allowance_2Thou), 4);
            }
            else  // >= 0.5 No Allowance
            {
                return Math.Round((BasicDia - (1.25 * Triangle)), 4);
            }
        }

        #endregion

        #region Calculate Minor Tolerance - this includes threads below 0.25" (BS 1580-3:2007)

        // Calculate Minor Tolerance (see Table A1 - BS1580-1:2007 for threads above 0.25" and BS1580-3:2007 for threads below 0.25")
        public double MinorTollerance_B()
        {
            if (ClassThread == "1B" || ClassThread == "2B")
            {
                if (ClassThread == "2B" && BasicDia < 0.2500)
                {
                    //return Math.Round(((0.975 * (0.0015 * Math.Pow(BasicDia, 1F / 3F) + 0.0015 * Math.Sqrt(Le) + 0.015 * Math.Pow((Pitch * Pitch), 1F / 3F)))), 4);

                    //return Math.Round(((0.05 * (Math.Pow(Pitch * Pitch, 1F / 3F) + 0.03 * (Pitch / BasicDia))) - 0.002 ), 4);
                    //return 0.05 * Math.Pow((Pitch * Pitch), 1.0 / 3.0) + 0.03 * Pitch / BasicDia - 0.002;
                    //return (0.05 * Math.Pow((Pitch * Pitch), 1F / 3F) + 0.03 * Pitch / BasicDia - 0.002);

                    //return MinorToleranceBase; // This is the same as formula used in BS1580-3 2007 to calculate 2B

                    if (BasicDia == 0.0730) // size 1
                    {
                        if (TPI == 72)
                        {
                            return 0.0055;
                        }
                        return 0.0062; // Hard coded Minor Tolerance
                    }
                    else if (BasicDia == 0.0860) // size 2
                    {
                        if (TPI == 64)
                        {
                            return 0.0062;
                        }
                        return 0.0070;
                    }
                    else if (BasicDia == 0.0990) // size 3
                    {
                        if (TPI == 56)
                        {
                            return 0.0068;
                        }
                        return 0.0081;
                    }
                    else if (BasicDia == 0.1120) // size 4
                    {
                        if (TPI == 48)
                        {
                            return 0.0074;
                        }
                        return 0.0090;
                    }
                    else if (BasicDia == 0.1250) // size 5
                    {
                        if (TPI == 44)
                        {
                            return 0.0075;
                        }
                        return 0.0083;
                    }
                    else if (BasicDia == 0.1380) // size 6
                    {
                        if (TPI == 40)
                        {
                            return 0.0080;
                        }
                        return 0.0100;
                    }
                    else if (BasicDia == 0.1640) // size 8
                    {
                        if (TPI == 36)
                        {
                            return 0.0080;
                        }
                        return 0.0090;
                    }
                    else if (BasicDia == 0.1900) // size 10
                    {
                        if (TPI == 32)
                        {
                            return 0.0080;
                        }
                        return 0.0110;
                    }
                    else // size 12
                    {
                        if (TPI == 28)
                        {
                            return 0.0090;
                        }
                        else if (TPI == 32)
                        {
                            return 0.0080;
                        }
                        return 0.0100;
                    }
                }
                else
                {                                     
                    // Minor Tolerance calculation for threads larger than 0.25"
                    return Math.Round(((0.25 * Pitch) - (0.4 * (Pitch * Pitch))), 4);
                }
                

                
            }
            else // (ClassThread == "3B")
            {
                if (BasicDia < 0.2500)
                {
                    if (BasicDia == 0.0730) // size 1
                    {
                        if (TPI == 72)
                        {
                            return 0.0055;
                        }
                        return 0.0062; // Hard coded Minor Tolerance
                    }
                    else if (BasicDia == 0.0860) // size 2
                    {
                        if (TPI == 64)
                        {
                            return 0.0062;
                        }
                        return 0.0070;
                    }
                    else if (BasicDia == 0.0990) // size 3
                    {
                        if (TPI == 56)
                        {
                            return 0.0068;
                        }
                        return 0.0081;
                    }
                    else if (BasicDia == 0.1120) // size 4
                    {
                        if (TPI == 48)
                        {
                            return 0.0074;
                        }
                        return 0.0090;
                    }
                    else if (BasicDia == 0.1250) // size 5
                    {
                        if (TPI == 44)
                        {
                            return 0.0075;
                        }
                        return 0.0083;
                    }
                    else if (BasicDia == 0.1380) // size 6
                    {
                        if (TPI == 40)
                        {
                            return 0.0076;
                        }
                        return 0.0100;
                    }
                    else if (BasicDia == 0.1640) // size 8
                    {
                        if (TPI == 36)
                        {
                            return 0.0076;
                        }
                        return 0.0089;
                    }
                    else if (BasicDia == 0.1900) // size 10
                    {
                        if (TPI == 32)
                        {
                            return 0.0081;
                        }
                        return 0.0105;
                    }
                    else // size 12
                    {
                        if (TPI == 32)
                        {
                            return 0.0075;
                        }
                        else if (TPI == 28)
                        {
                            return 0.0087;
                        }
                        return 0.0097;
                    }
                }
                else
                {
                    if (TPI <= 12)
                    {
                        if (MinorToleranceBase > For12TPI)
                        {

                            return Math.Round((MinorToleranceBase), 4);
                        }
                        else
                        {
                            return Math.Round((For12TPI), 4);
                        }
                    }
                    else // (TPI >= 13)
                    {
                        if (MinorToleranceBase > For13to80TPI)
                        {
                            return Math.Round((MinorToleranceBase), 4);
                        }
                        else
                        {
                            return Math.Round((For13to80TPI), 4);
                        }
                    }
                }
                
            }

        }

        #endregion   



        //========================================
        // CALCULATIONS FOR MODELTO, DMAX AND DMIN 
        //========================================

        #region Calculate ModelTo based on MinorMax and MinorMin

        /// <summary>
        /// Calculate ModelTo given MinorMax and MinorMin values
        /// </summary>
        /// <param name="minorMax">MinorMax value for Female thread</param>
        /// <param name="minorMin">MinorMin value for Female thread</param>
        /// <returns>ModelTo for Female</returns>
        public double CalculateModelto_B(double minorMax, double minorMin)
        {
            return (minorMax + minorMin) / 2;
        }

        #endregion

        #region Calculate DMax (U.Cut Max) value given selected Basic Dia and check which formula to use based on the given threshold (see BS 1936:1952)

        /// <summary>
        /// Calculate DMax (U.Cut Max) given BaseDia value
        /// </summary>
        /// <param name="baseDia">Basic dia selected</param>
        /// <returns>DMax (U.Cut Max) value for Female</returns>
        public double DMax_B(double baseDia)
        {
            if (baseDia < 2.0)
            {
                if (baseDia < 0.5)
                {
                    return Math.Ceiling((baseDia + 0.002) / 0.005) * 0.005;
                }
                else
                {
                    return Math.Ceiling(baseDia / 0.005) * 0.005;
                }
            }
            else
            {
                return Math.Round(baseDia, 2, MidpointRounding.AwayFromZero);
            }
        }

        #endregion

        #region Calculate DMin (U.Cut Min) value given currently selected Basic Dia and check which formula to use based on the given threshold (see BS 1936:1952)

        /// <summary>
        /// Calculate DMin (U.Cut Min) value given selected Basic Dia
        /// </summary>
        /// <param name="baseDia">Selected Basic Dia value for Female thread</param>
        /// <returns>DMin (U.Cut Min) value for Female</returns>
        public double DMin_B(double baseDia)
        {
            if (baseDia < 2.0)
            {
                if (baseDia < 0.5)
                {
                    baseDia = Math.Ceiling((baseDia + 0.002) / 0.005) * 0.005;

                    if ((baseDia >= 0.060) && (baseDia < 0.100))
                    {
                        return (baseDia + 0.003);
                    }
                    else if ((baseDia >= 0.100) && (baseDia < 0.300))
                    {
                        return (baseDia + 0.004);
                    }
                    else if ((baseDia >= 0.300) && (baseDia < 0.600))
                    {
                        return (baseDia + 0.006);
                    }
                    else if ((baseDia >= 0.600) && (baseDia < 1.250))
                    {
                        return (baseDia + 0.008);
                    }
                    else // (MinorMin >= 1.25 & MinorMin < 2.8)
                    {
                        return (baseDia + 0.010);
                    }
                }
                else
                {
                    baseDia = Math.Ceiling(baseDia / 0.005) * 0.005;

                    if ((baseDia >= 0.060) && (baseDia < 0.100))
                    {
                        return (baseDia + 0.003);
                    }
                    else if ((baseDia >= 0.100) && (baseDia < 0.300))
                    {
                        return (baseDia + 0.004);
                    }
                    else if ((baseDia >= 0.300) && (baseDia < 0.600))
                    {
                        return (baseDia + 0.006);
                    }
                    else if ((baseDia >= 0.600) && (baseDia < 1.250))
                    {
                        return (baseDia + 0.008);
                    }
                    else // (MinorMin >= 1.25 & MinorMin < 2.8)
                    {
                        return (baseDia + 0.010);
                    }
                }

            }
            else
            {
                baseDia = Math.Round(baseDia, 2, MidpointRounding.AwayFromZero);

                if (baseDia >= 1.250 && baseDia < 2.800)
                {
                    return (baseDia + 0.010);
                }
                else if (baseDia >= 2.800 && baseDia < 6.0)
                {
                    return (baseDia + 0.015);
                }
                else // (baseDia >= 6.0 & baseDia < 12.0)
                {
                    return (baseDia + 0.020);
                }
            }
        }

        #endregion



        //=======================================
        // POPULATE ALLOWANCE AND RESULTS TEXTBOX
        //=======================================

        #region Populate Allowance Texbox base on diameter and selected coating type

        /// <summary>
        /// Populate Allowance Textbox based on the diameter and selected coating
        /// </summary>
        /// <returns></returns>
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
            if (BasicDia < 0.5 & NoCoating == "Yes") // corrected after the user pointed out that the code above was wrong - displayed allowance for coating 
            {

                string[] list = {

                       BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI) + "-" +  ClassThread + ", BS1580",

                       "\r\n",
                       "MINOR DIA.  " + MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "EFF. DIA.   " + EffectiveMin_B().ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + EffectiveMax_B().ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "MAJOR DIA.  " + MajorMin_B().ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " MIN." + " SPL",

                            };

                return list;

            }
            else if (BasicDia < 0.5 & CoatingPS309 == "Yes") // Off 2 thou
            {
                string[] list = {

                       BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI) + "-" +  ClassThread + ", BS1580",

                       "\r\n",
                       "BEFORE COATING:",

                       "\r\n",
                       "MINOR DIA.  " +  MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "EFF. DIA.   " + EffectiveMin_B().ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + EffectiveMax_B().ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "MAJOR DIA.  " + MajorMin_B().ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " MIN." + " SPL",



                            };

                return list;
            }
            else if (BasicDia < 0.5 & CoatingOther == "Yes") // Off 2 thou
            {
                string[] list = {

                       BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI) + "-" +  ClassThread + ", BS1580",

                       "\r\n",
                       "BEFORE COATING:",                   

                       "\r\n",
                       "MINOR DIA.  " +  MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "EFF. DIA.   " + EffectiveMin_B().ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + EffectiveMax_B().ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " SPL",

                       "\r\n",
                       "MAJOR DIA.  " + MajorMin_B().ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " MIN." + " SPL",

                            };

                return list;
            }
            else if (BasicDia >= 0.5 & NoCoating == "Yes")
            {
                string[] list = {


                       BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI) + "-" +  ClassThread + ", BS1580",

                       "\r\n",
                       "MINOR DIA.   " + MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture),

                       "\r\n",
                       "EFF. DIA.    " + EffectiveMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + EffectiveMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture),

                       "\r\n",
                       "MAJOR DIA.  " + MajorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + "  " + "MIN.",

                            };

                return list;

            }
            else if (BasicDia >= 0.5 & CoatingPS309 == "Yes")
            {
                string[] list = {

                      
                       BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI) + "-" +  ClassThread + ", BS1580",

                       "\r\n",
                       "BEFORE COATING:",

                       "\r\n",
                       "MINOR DIA.   " + MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture),

                       "\r\n",
                       "EFF. DIA.    " + EffectiveMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + EffectiveMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture),

                       "\r\n",
                       "MAJOR DIA.  " + MajorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + "  " + "MIN.",

                            };

                return list;
            }
            else if (BasicDia >= 0.5 & CoatingOther == "Yes")
            {
                string[] list = {


                       BasicDia.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) +"-" + TPI + " " + Design.GetDesignationModel(BasicDia, TPI) + "-" +  ClassThread + ", BS1580",

                       "\r\n",
                       "BEFORE COATING:",

                       "\r\n",
                       "MINOR DIA.   " + MinorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + MinorMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture),

                       "\r\n",
                       "EFF. DIA.    " + EffectiveMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + " - " + EffectiveMax.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture),

                       "\r\n",
                       "MAJOR DIA.  " + MajorMin.ToString("#.##00", System.Globalization.CultureInfo.InvariantCulture) + "  " + "MIN.",

                            };

                return list;

            }
            else
            {
                string[] list = {

                       "0.0000" +"-" + "00" + " " + "None" + "-" +  "None" + ", None",

                       "\r\n",
                       "MINOR DIA.  " + "0.0000" + " - " + "0.0000",

                       "\r\n",
                       "EFF. DIA.   " + "0.0000" + " - " + "0.0000",

                       "\r\n",
                       "MAJOR DIA.  " +  "0.0000" + " - " + "0.0000",

                            };

                return list;
            }


        }

        #endregion


    }
}

using System;
using System.Windows.Forms;
using ThreadCalculatorClassLibrary;
using System.IO;
using System.Drawing;

namespace Thread_Calculator
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            #region Disable other Comboboxes until Basic Diameter selected

            cmb_tpi.Enabled = false;
            cmb_threadClass.Enabled = false;
            cmb_uCutWidth.Enabled = false;
            cmb_ps309.Enabled = false;
            cmb_other.Enabled = false;

            cmb_noCoating.Enabled = false;

            #endregion
        }


        #region Instantiate Classes

        /// <summary>
        /// An instance of a LeModel Class which by using CalculateLe(double basicDia, double tpi) method will return Le (Length Of Engagement).
        /// </summary>
        LeModel GetLe = new LeModel();

        /// <summary>
        /// An instance of a ThredClassModel which by using GetClassModel(double basicDia, double tpi) method will return a Thread Class list - 1A, 2A, 3A, 1B, 2B or 3B.
        /// </summary>
        ThreadClassModel ThreadClassModel = new ThreadClassModel();

        /// <summary>
        /// An instance of a Female class - sets all data for Female threads
        /// </summary>
        Female Female = new Female();

        /// <summary>
        /// An instance of a Male class - sets all data for Male class
        /// </summary>
        Male Male = new Male();

        /// <summary>
        /// An instance of a ThreadDesignationModel class which by using GetDesignatonModel(double basicDia, double tpi) method will return the Thread Designation - UN, UNC, UNF etc.
        /// </summary>
        ThreadDesignationModel ThreadDesignationModel = new ThreadDesignationModel();

        /// <summary>
        /// An instance of a RadiiModel class which by using CalculateRadii(double tpi, double ucutWidth) method will return Radius - 0.005, 0.012 etc.
        /// </summary>
        RadiiModel RadiiModel = new RadiiModel();

        /// <summary>
        /// An instance of a PopulateTPIModel class which by using PopulateTPI(double selectedDia) will return the list of TPIs - Threads Per Inch - 4, 6, 8, 12 etc.
        /// </summary>
        TPIModel PopulateTPI = new TPIModel();

        /// <summary>
        /// An instance of a UWidthModel class which by using CalculateUWidth(souble tpi, double ucutwidth) will return the nominal width value.
        /// </summary>
        UWidthModel UCutWidthModel = new UWidthModel();

        /// <summary>
        /// An instance of a Below025Model class which checks if selected thread size is a code between 1 - 12 and returns the size - threads below 0.25 are encoded and dimension is given apart major size.
        /// </summary>
        Below025Model Below025Model = new Below025Model();

        #endregion


        //=================================================================================================
        // HANDLE THE COMBOBOX EVENTS FOR BASIC DIA, TPI, THREAD CLASS, UCUT WIDTH, PS309 AND OTHER COATING  
        //=================================================================================================

        #region Selected Index Changed event for Basic Diameter Combobox

        /// <summary>
        /// Selected index changed for Basic Diameter Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_basicDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Check if selected Basic Dia is a code or actual size
            if (cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem).Length < 4)
            {
                // Pass selected code to Below025Model.CalculateBasicDia and return size which is then used to populate TPI
                cmb_tpi.DataSource = PopulateTPI.PopulateTPI(Below025Model.CalculateBasicDia(cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem)));

            }
            else
            {
                // Populate TPI based on Basic Dia
                cmb_tpi.DataSource = PopulateTPI.PopulateTPI(Convert.ToDouble(cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem)));

            }

            

            

            // Activate other Comboboxes when BasicDia selected and set to first value on the list
            if (cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem) != "")
            {
                cmb_tpi.Enabled = true;
                cmb_threadClass.Enabled = true;
                cmb_uCutWidth.Enabled = true;
                cmb_ps309.Enabled = true;
                cmb_other.Enabled = true;
                cmb_tpi.SelectedIndex = 0;
                cmb_threadClass.SelectedIndex = 0;
                cmb_uCutWidth.SelectedIndex = 0;
                cmb_ps309.SelectedIndex = 0;
                cmb_other.SelectedIndex = 0;

                cmb_noCoating.SelectedIndex = 0;
            }
            else
            {
                // Otherwise dissable the fields untill BasicDia selected
                cmb_tpi.Enabled = false;
                cmb_threadClass.Enabled = false;
                cmb_uCutWidth.Enabled = false;
                cmb_ps309.Enabled = false;
                cmb_other.Enabled = false;

                cmb_noCoating.Enabled = false;
            }

            // Perform calculation every time the value in any Combobox has changed
            Calculate_Click(new object(), new EventArgs());
        }

        #endregion

        #region Selected Index Change event for TPI Combobox

        /// <summary>
        /// Selected index change for TPI Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_tpi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if selected Basic Dia is a code or actual size
            if (cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem).Length < 4)
            {
                // Pass selected code to Below025Model.CalculateBasicDia and return size, with TPI is then used to populate ThreadClass combo.
                cmb_threadClass.DataSource = ThreadClassModel.GetClassModel(Below025Model.CalculateBasicDia(cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem)), Convert.ToDouble(cmb_tpi.GetItemText(cmb_tpi.SelectedItem)));
            }
            else
            {
                // Populate the Thread Class based on Basic Dia and TPI
                cmb_threadClass.DataSource = ThreadClassModel.GetClassModel(Convert.ToDouble(cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem)), Convert.ToDouble(cmb_tpi.GetItemText(cmb_tpi.SelectedItem)));
            }      

            // Perform calculation every time the value in any Combobox has changed
            Calculate_Click(new object(), new EventArgs());
        }

        #endregion

        #region Selected Index Change event for Thread Class Combobox

        /// <summary>
        /// Selected index change for Thread Class Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_threadClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Populate Thread Type Text Field based on selected Class - External and Internal
            txt_threadType.Text = Formula.PopulateThreadType(cmb_threadClass.GetItemText(cmb_threadClass.SelectedItem));

            // Change label based on class selection 1A to 2A = External and 1B to 3B = Internal
            if ((cmb_threadClass.Text == "1A") || (cmb_threadClass.Text == "2A") || (cmb_threadClass.Text == "3A"))
            {
                // Hide SELECT BASIC THREAD DIA if no diameter selected
                lbl_selectDia.Visible = false;

                // Set image and text for external threads
                img_threadType.Image = Properties.Resources.ucut1;
                lbl_intExt.Text = "EXTERNAL THREAD";
            }
            else
            {
                // Hide SELECT BASIC THREAD DIA if no diameter selected
                lbl_selectDia.Visible = false;

                // Set image and text for internal threads
                img_threadType.Image = Properties.Resources.ucut;
                lbl_intExt.Text = "INTERNAL THREAD";
            }

            // Set UCut Width Combobox to default value - first value in the combobox
            cmb_uCutWidth.SelectedIndex = 0;

            // Perform calculation every time the value in any Combobox has changed
            Calculate_Click(new object(), new EventArgs());

        }

        #endregion

        #region Selected Index Change event for UCut Width Combobox

        /// <summary>
        /// Selected index change for UCUT Width Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_uCutWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Perform calculation every time the value in any Combobox has changed
            Calculate_Click(new object(), new EventArgs());
        }

        #endregion

        #region Selected Index Changed event for PS309 Combobox

        /// <summary>
        /// Selected index change for PS309 Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_ps309_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set to default and disable Other Coating Type combobox if ps309 set to Yes
            if (cmb_ps309.Text == "Yes")
            {
                txtBox_GroupC.BackColor = Color.SkyBlue;
                cmb_other.SelectedIndex = 0;
                cmb_other.Enabled = false;

                cmb_noCoating.SelectedIndex = 0;
                cmb_noCoating.Enabled = false;
            }
            else
            {
                txtBox_GroupC.BackColor = Color.Empty;
                // Otherwise enable Other Coating Type combobox 
                cmb_other.Enabled = true;

                cmb_noCoating.Enabled = true;
            }

            // Perform calculation every time the value in any Combobox has changed
            Calculate_Click(new object(), new EventArgs());
        }

        #endregion

        #region Selected Index Change event for Other Coating combobox

        /// <summary>
        /// Selected index change for Other Coating Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_other_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set to default and dissable ps combobox if Other Coating combobox set to YES
            if (cmb_other.Text == "Yes")
            {
                txtBox_GroupB.BackColor = Color.SkyBlue;
                // Set PS309 combobox to default value (NO) and then dissable
                cmb_ps309.SelectedIndex = 0;
                cmb_ps309.Enabled = false;

                cmb_noCoating.SelectedIndex = 0;
                cmb_noCoating.Enabled = false;
            }
            else
            {
                txtBox_GroupB.BackColor = Color.Empty;
                // Otherwise enable the combobox
                cmb_ps309.Enabled = true;

                cmb_noCoating.Enabled = true;
            }

            // Perform calculation every time the value in any Combobox has changed
            Calculate_Click(new object(), new EventArgs());
        }

        #endregion

        #region Selected Index Changed event for Coating combobox

        /// <summary>
        /// Coating type selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_noCoating_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set to default and dissable ps combobox if Other Coating combobox set to YES
            if (cmb_noCoating.Text == "Yes")
            {
                txtBox_GroupA.BackColor = Color.SkyBlue;
                // Set PS309 combobox to default value (NO) and then dissable
                cmb_ps309.SelectedIndex = 0;
                cmb_ps309.Enabled = false;

                cmb_other.SelectedIndex = 0;
                cmb_other.Enabled = false;
            }
            else
            {
                txtBox_GroupA.BackColor = Color.Empty;
                // Otherwise enable the combobox
                cmb_ps309.Enabled = true;

                cmb_other.Enabled = true;
            }

            // Perform calculation every time the value in any Combobox has changed
            Calculate_Click(new object(), new EventArgs());
        }

        #endregion








        //=================================================================
        // CALCULATE RESULTS EVERY TIME A VALUE HAS CHANGED IN ANY COMBOBOX
        //=================================================================

        #region Calculate event trigger, fires when a value in any Combobox has changed

        /// <summary>
        /// Calculate event trigger, fires every time a value has changed in any Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Calculate_Click(object sender, EventArgs e)
        {

            // Reset the message after Copy button pressed when value in any combobox has changed
            lbl_copy.Visible = false;

            if (cmb_threadClass.SelectedItem != null)
            {
                if (cmb_threadClass.Text == "1A" || cmb_threadClass.Text == "2A" || cmb_threadClass.Text == "3A")
                {
                    // Get D-Basic Dia first before setting LE
                    if (cmb_basicDia.SelectedItem != null)
                    {
                        // Check if selected Basic Dia is a code or actual size
                        if (cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem).Length < 4)
                        {
                            // Pass selected code to Below025Model.CalculateBasicDia and return actual thread size
                            Male.BasicDia = Below025Model.CalculateBasicDia(cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem));                           
                        }
                        else
                        {
                            // Get Basic Dia
                            Male.BasicDia = Convert.ToDouble(cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem));
                        }

                        
                    }

                    // Get TPI first before setting LE
                    if (cmb_tpi.SelectedItem != null)
                    {
                        Male.TPI = Convert.ToDouble(cmb_tpi.GetItemText(cmb_tpi.SelectedItem));
                    }

                    // Get Thread Class first before setting LE
                    if (cmb_threadClass.SelectedItem != null)
                    {
                        Male.ClassThread = cmb_threadClass.GetItemText(cmb_threadClass.SelectedItem);
                    }

                    // Get U Cut 
                    if (cmb_uCutWidth != null)
                    {
                        Male.UCutWidth = cmb_uCutWidth.GetItemText(cmb_uCutWidth.SelectedItem);
                    }

                    // Get Other Coating
                    if (cmb_other != null)
                    {
                        Male.CoatingOther = cmb_other.GetItemText(cmb_other.SelectedItem);
                    }

                    // Get PS 309 Coating
                    if (cmb_ps309 != null)
                    {
                        Male.CoatingPS309 = cmb_ps309.GetItemText(cmb_ps309.SelectedItem);
                    }



                    // Get NoCoating
                    if (cmb_noCoating != null)
                    {
                        Male.NoCoating = cmb_noCoating.GetItemText(cmb_noCoating.SelectedItem);
                    }



                }
                else // Set the same data but for female threads
                {
                    // Get D first before setting LE
                    if (cmb_basicDia.SelectedItem != null)
                    {
                        // Check if selected Basic Dia is a code or actual size
                        if (cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem).Length < 4)
                        {
                            // Pass selected code to Below025Model.CalculateBasicDia and return actual thread size
                            Female.BasicDia = Below025Model.CalculateBasicDia(cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem));
                        }
                        else
                        {
                            // Get Basic Dia
                            Female.BasicDia = Convert.ToDouble(cmb_basicDia.GetItemText(cmb_basicDia.SelectedItem));
                        }
                        
                    }

                    // Get TPI first before setting LE
                    if (cmb_tpi.SelectedItem != null)
                    {
                        Female.TPI = Convert.ToDouble(cmb_tpi.GetItemText(cmb_tpi.SelectedItem));
                    }

                    // Get Thread Class first before setting LE
                    if (cmb_threadClass.SelectedItem != null)
                    {
                        Female.ClassThread = cmb_threadClass.GetItemText(cmb_threadClass.SelectedItem);
                    }

                    // Get U Cut 
                    if (cmb_uCutWidth != null)
                    {
                        Female.UCutWidth = cmb_uCutWidth.GetItemText(cmb_uCutWidth.SelectedItem);
                    }

                    // Get Other Coating
                    if (cmb_other != null)
                    {
                        Female.CoatingOther = cmb_other.GetItemText(cmb_other.SelectedItem);
                    }

                    // Get PS 309 Coating
                    if (cmb_ps309 != null)
                    {
                        Female.CoatingPS309 = cmb_ps309.GetItemText(cmb_ps309.SelectedItem);
                    }



                    // Get NoCoating
                    if (cmb_noCoating != null)
                    {
                        Female.NoCoating = cmb_noCoating.GetItemText(cmb_noCoating.SelectedItem);
                    }

                }
            }



            #region Set main Data for Male & Female thread

            if (cmb_threadClass.Text == "1A" || cmb_threadClass.Text == "2A" || cmb_threadClass.Text == "3A")
            {
                // Calculate Le and pass it to MainData Class for other calculations
                Male.Le = GetLe.CalculateLe(Male.BasicDia, Male.TPI);
                // Get Pitch              
                Male.Pitch = (1 / Male.TPI);
                // Get Allowance - G
                Male.Allowance = Math.Round(((0.30 * (0.0015 * (Math.Pow(Male.BasicDia, 1F / 3F)) + 0.0015 * (Math.Sqrt(Male.Le)) + 0.0150 * (Math.Pow((Male.Pitch * Male.Pitch), 1F / 3F))))), 4);
                // Get Height of Fundamental Triangle - H             
                Male.Triangle = (0.86603 * Male.Pitch);
                // Get Basic Effective Diameter - E
                Male.BasicEffectiveDia = Math.Round((Male.BasicDia - (0.75 * Male.Triangle)), 4);


                // DIAGNOSTICS DATA
                DiagnosticsData.GetBasicDia = Male.BasicDia;
                DiagnosticsData.GetLe = Male.Le;
                DiagnosticsData.GetPitch = Male.Pitch;
                DiagnosticsData.GetAllowance = Male.Allowance;
                DiagnosticsData.GetTriangle = Male.Triangle;
                DiagnosticsData.GetBasicDia = Male.BasicEffectiveDia;
                DiagnosticsData.GetThreadClass = Male.ClassThread;
                DiagnosticsData.GetPS309 = Male.CoatingPS309;
                DiagnosticsData.GetOther = Male.CoatingOther;
                DiagnosticsData.GetNoCoating = Male.NoCoating;
            }
            else
            {
                // Calculate Le and pass it to MainData Class for other calculations
                Female.Le = GetLe.CalculateLe(Female.BasicDia, Female.TPI);
                // Get Pitch
                Female.Pitch = (1 / Female.TPI);
                // Get Allowance - G
                Female.Allowance = Math.Round(((0.30 * (0.0015 * (Math.Pow(Female.BasicDia, 1F / 3F)) + 0.0015 * (Math.Sqrt(Female.Le)) + 0.0150 * (Math.Pow((Female.Pitch * Female.Pitch), 1F / 3F))))), 4);
                // Get Height of Fundamental Triangle - H
                Female.Triangle = (0.86603 * Female.Pitch);
                // Get Basic Effective Diameter - E
                Female.BasicEffectiveDia = Math.Round((Female.BasicDia - (0.75 * Female.Triangle)), 4);

                // Set Tolerance variations for 3B only
                Female.For12TPI = (0.12 * Female.Pitch);
                Female.For13to80TPI = (0.23 * Female.Pitch - (1.5 * (Female.Pitch * Female.Pitch)));
                Female.MinorToleranceBase = (0.05 * Math.Pow((Female.Pitch * Female.Pitch), 1F / 3F) + 0.03 * Female.Pitch / Female.BasicDia - 0.002);

                // DIAGNOSTICS DATA
                DiagnosticsData.GetBasicDia = Female.BasicDia;
                DiagnosticsData.GetLe = Female.Le;
                DiagnosticsData.GetPitch = Female.Pitch;
                DiagnosticsData.GetAllowance = Female.Allowance;
                DiagnosticsData.GetTriangle = Female.Triangle;
                DiagnosticsData.GetBasicEffDia = Female.BasicEffectiveDia;
                DiagnosticsData.Get12TPI = Female.For12TPI;
                DiagnosticsData.Get13to80TPI = Female.For13to80TPI;
                DiagnosticsData.GetMinorToleranceBase = Female.MinorToleranceBase;
                DiagnosticsData.GetThreadClass = Female.ClassThread;
                DiagnosticsData.GetPS309 = Female.CoatingPS309;
                DiagnosticsData.GetOther = Female.CoatingOther;
                DiagnosticsData.GetNoCoating = Female.NoCoating;
                DiagnosticsData.GetTPI = Female.TPI;
            }

            #endregion

            #region Calculate Male & Female

            //Calculate Male 1A 2A 3A
            if (cmb_threadClass.Text == "1A" || cmb_threadClass.Text == "2A" || cmb_threadClass.Text == "3A")
            {
                // Set Major Property
                Male.MajorMax = Male.MajorMax_A();
                Male.MajorTolerance = Male.MajorTolerance_A();
                Male.MajorMin = Male.MajorMin_A(Male.MajorMax);

                // Set Effective Property        
                Male.EffectiveMax = Male.EffectiveMax_A();
                Male.EffectiveTolerance = Male.EffectiveTolerance_A();
                Male.EffectiveMin = Male.EffectiveMin_A(Male.EffectiveMax);

                // Set Minor Property      
                Male.MinorMax = Male.MinorMax_A();
                Male.MinorTolerance = Male.MinorTollerance_A(Male.EffectiveTolerance);
                Male.MinorMin = Male.MinorMin_A(Male.MinorMax, Male.MinorTolerance);

                // MODEL TO            
                Male.ModelTo = Male.CalculateModelto_A(Male.MajorMax, Male.MajorMin);

                // DIAGNOSTICS DATA
                DiagnosticsData.GetMajorMax = Male.MajorMax;
                DiagnosticsData.GetMajorTol = Male.MajorTolerance;
                DiagnosticsData.GetMajorMin = Male.MajorMin;

                DiagnosticsData.GetEffMax = Male.EffectiveMax;
                DiagnosticsData.GetEffTol = Male.EffectiveTolerance;
                DiagnosticsData.GetEffMin = Male.EffectiveMin;

                DiagnosticsData.GetMinorMax = Male.MinorMax;
                DiagnosticsData.GetMinorTol = Male.MinorTolerance;
                DiagnosticsData.GetMinorMin = Male.MinorMin;

                // MAJOR
                txt_majorMax.Text = Male.MajorMax.ToString("F4");
                txt_majorToler.Text = Male.MajorTolerance.ToString("F4");
                txt_majorMin.Text = Male.MajorMin.ToString("F4");

                // EFFECTIVE
                txt_effMax.Text = Male.EffectiveMax.ToString("F4");
                txt_effToler.Text = Male.EffectiveTolerance.ToString("F4");
                txt_effMin.Text = Male.EffectiveMin.ToString("F4");

                // MINOR
                txt_minorMax.Text = Male.MinorMax.ToString("F4");
                txt_minorToler.Text = Male.MinorTolerance.ToString("F4");
                txt_minorMin.Text = Male.MinorMin.ToString("F4");

                // MODEL TO
                txt_modelTo.Text = Male.ModelTo.ToString("F4");


                //========================
                // CALCULATE DMAX AND DMIN
                //========================

                Male.DMax = Male.DMax_A(Male.MinorMin);
                Male.DMin = Male.DMin_A(Male.MinorMin);

                txt_dMax.Text = Male.DMax.ToString("F3");
                txt_dMin.Text = Male.DMin.ToString("F3");

                // MODEL TO D BASED ON DMAX AND DMIN
                Male.ModelToD = Male.CalculateModeltoD(Male.DMax, Male.DMin);
                txt_modelToD.Text = Male.ModelToD.ToString("F3");


                //===========================================
                // CALCULATE RADII BASED ON TPI AND UCUTWIDTH
                //===========================================

                Male.Radii = RadiiModel.CalculateRadii(Male.TPI, Male.UCutWidth);
                txt_radii.Text = Male.Radii.ToString("F3");


                //=====================================================
                // CALCULATE WIDTH MAX BASED ON UCUT MAX AND UCUT WIDTH
                //=====================================================

                // Calculate UCut Max based on UCut Width selection - 1p 1.5p 3p
                Male.UCutMax = UCutWidthModel.CalculateUWidth(Male.TPI, Male.UCutWidth);

                // Calculate UCut Width Max based on UCut Max
                Male.UCutWidthMax = Male.CalculateWidthMax(Male.UCutMax);
                txt_widthMax.Text = Male.UCutWidthMax.ToString("F3");

                // Calculate UCut Width Min based on UCut Max
                Male.UCutWidthMin = Male.CalculateWidthMin(Male.UCutMax);
                txt_widthMin.Text = Male.UCutWidthMin.ToString("F3");

                // Calculate ModelTo for Width based on Width Max and Width Min
                Male.ModelToWidth = Male.CalculateModeltoWidth(Male.UCutWidthMax, Male.UCutWidthMin);
                txt_modelToWidth.Text = Male.ModelToWidth.ToString("F3");



                //===================
                // POPULATE TEXTBOXES
                //===================

          

                // Populate Thread Designation Textbox
                txt_threadDesignation.Text = ThreadDesignationModel.GetDesignationModel(Male.BasicDia, Male.TPI);

                // Populate Allowance Textbox
                txt_allowance.Text = Male.PopulateAllowance();

                // Populate Results Textbox
                txt_results.Text = string.Join("", Male.resultList());

            }
            else
            {
                // Calculate Female 1B 2B 3B

                // MAJOR             
                Female.MajorMax = Female.MajorMax_B();
                Female.MajorTolerance = Female.MajorTolerance_B();
                Female.MajorMin = Female.MajorMin_B();

                // EFFECTIVE            
                Female.EffectiveMin = Female.EffectiveMin_B();
                Female.EffectiveTolerance = Female.EffectiveTolerance_B();
                Female.EffectiveMax = Female.EffectiveMax_B();

                // MINOR             
                Female.MinorMin = Female.MinorMin_B();
                Female.MinorTolerance = Female.MinorTollerance_B();
                Female.MinorMax = Female.MinorMax_B(Female.MinorMin, Female.MinorTolerance);

                // MODEL TO              
                Female.ModelTo = Female.CalculateModelto_B(Female.MinorMax, Female.MinorMin);

                // DIAGNOSTICS DATA
                DiagnosticsData.GetMajorMax_Female = Female.MajorMax;
                DiagnosticsData.GetMajorTol_Female = Female.MajorTolerance;
                DiagnosticsData.GetMajorMin = Female.MajorMin;

                DiagnosticsData.GetEffMin = Female.EffectiveMin;
                DiagnosticsData.GetEffMax = Female.EffectiveMax;
                DiagnosticsData.GetEffTol = Female.EffectiveTolerance;

                DiagnosticsData.GetMinorMin = Female.MinorMin;
                DiagnosticsData.GetMinorMax = Female.MinorMax;
                DiagnosticsData.GetMinorTol = Female.MinorTolerance;


                // Populate Text Boxes
                // MAJOR
                txt_majorMax.Text = Female.MajorMax;
                txt_majorToler.Text = Female.MajorTolerance;
                txt_majorMin.Text = Female.MajorMin.ToString("F4");

                // EFFECTIVE
                txt_effMin.Text = Female.EffectiveMin.ToString("F4");
                txt_effToler.Text = Female.EffectiveTolerance.ToString("F4");
                txt_effMax.Text = Female.EffectiveMax.ToString("F4");

                // MINOR
                txt_minorMin.Text = Female.MinorMin.ToString("F4");
                txt_minorToler.Text = Female.MinorTolerance.ToString("F4");
                txt_minorMax.Text = Female.MinorMax.ToString("F4");

                // MODEL TO
                txt_modelTo.Text = Female.ModelTo.ToString("F4");


                //========================
                // CALCULATE DMAX AND DMIN
                //========================

                Female.DMax = Female.DMax_B(Female.BasicDia);
                Female.DMin = Female.DMin_B(Female.BasicDia);

                txt_dMax.Text = Female.DMax.ToString("F3");
                txt_dMin.Text = Female.DMin.ToString("F3");

                // MODEL TO D BASED ON DMAX AND DMIN
                Female.ModelToD = Female.CalculateModeltoD(Female.DMax, Female.DMin);
                txt_modelToD.Text = Female.ModelToD.ToString("F3");


                //===========================================
                // CALCULATE RADII BASED ON TPI AND UCUTWIDTH
                //===========================================

                Female.Radii = RadiiModel.CalculateRadii(Female.TPI, Female.UCutWidth);
                txt_radii.Text = Female.Radii.ToString("F3");


                //=====================================================
                // CALCULATE WIDTH MAX BASED ON UCUT MAX AND UCUT WIDTH
                //=====================================================

                // Calculate UCut Max based on UCut Width selection - 1p 1.5p 3p
                Female.UCutMax = UCutWidthModel.CalculateUWidth(Female.TPI, Female.UCutWidth);

                // Calculate UCut Width Max based on UCut Max
                Female.UCutWidthMax = Female.CalculateWidthMax(Female.UCutMax);
                txt_widthMax.Text = Female.UCutWidthMax.ToString("F3");

                // Calculate UCut Width Min based on UCut Max
                Female.UCutWidthMin = Female.CalculateWidthMin(Female.UCutMax);
                txt_widthMin.Text = Female.UCutWidthMin.ToString("F3");

                // Calculate ModelTo for Width based on Width Max and Width Min
                Female.ModelToWidth = Female.CalculateModeltoWidth(Female.UCutWidthMax, Female.UCutWidthMin);
                txt_modelToWidth.Text = Female.ModelToWidth.ToString("F3");


                // Populate Thread Designation text box    
                //Formula.GetThreadDesignation = Female.PopulateThreadDesignation(Female.BasicDia, Female.TPI);
                txt_threadDesignation.Text = ThreadDesignationModel.GetDesignationModel(Female.BasicDia, Female.TPI);


                // Populate Allowance text box
                txt_allowance.Text = Female.PopulateAllowance();

                // Populate results text box
                txt_results.Text = string.Join("", Female.resultList());

            }

            #endregion

        }

        #endregion



        //==================================================================================================
        // HANDLE OTHER EVENTS - COPY, TIMERS, ALLOWANCE FORM, ABOUT MENU, ADMIN LOGIN MENU AND CLOSE BUTTON
        //==================================================================================================

        #region Copy Button

        /// <summary>
        /// Copy btn for copying results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copy_Click(object sender, EventArgs e)
        {

            Clipboard.Clear();

            if (txt_results.Text != "")
            {
                Clipboard.SetText(txt_results.Text.Replace("\t", "")); // Replace all tabs with white spaces after copying to clipboard - SIEMENS NX does not like tabs
                lbl_copy.ForeColor = Color.Green;
                lbl_copy.Visible = true;
                lbl_copy.Text = "COPIED TO CLIPBOARD !";
            }
            else
            {
                Clipboard.Clear();
                lbl_copy.ForeColor = Color.Red;
                lbl_copy.Visible = true;
                lbl_copy.Text = "RESULTS TEXTBOX IS EMPTY !";
            }

        }

        #endregion

        #region Timer for Arrows Animation

        /// <summary>
        /// Timer for arrows animation on program start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_start_Tick(object sender, EventArgs e)
        {
            // Initiate Start Here arrow
            if (cmb_basicDia.SelectedIndex == -1)
            {
                pictureBox1.Visible = !pictureBox1.Visible;
                timer_start.Start();
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        /// <summary>
        /// Timer for arrow animation on allowance section on program start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_allowance_Tick(object sender, EventArgs e)
        {
            // Initiate Allowance arrow
            if (cmb_basicDia.SelectedIndex == -1)
            {
                pictureBox2.Visible = !pictureBox2.Visible;
                timer_allowance.Start();
            }
            else
            {
                pictureBox2.Visible = false;
            }
        }

        #endregion

        #region Open allowance form on button click

        /// <summary>
        /// Open Allowance form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_allowances_Click(object sender, EventArgs e)
        {
            Allowances Allowancesform = new Allowances();
            Allowancesform.Show();
        }

        #endregion

        #region About Strip Menu

        /// <summary>
        /// About menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox About = new AboutBox();
            About.Show();
        }

        #endregion

        #region Admin Login Strip Menu

        /// <summary>
        /// Admin login menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
        }

        #endregion

        #region Close the app

        /// <summary>
        /// Close application button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region UNUSED OPTION for collecting program usage statistics

        //private string userName = Environment.UserName;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            //try
            //{
            //    if (e.CloseReason == CloseReason.UserClosing)
            //        using (StreamWriter writer = new StreamWriter(@"\\xxxxx\Thread Calculator\Calculator Logs\CalcLog.txt", true))
            //        {
            //            writer.WriteLine(userName + " - " + DateTime.Now);

            //        }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    Application.Exit();

            //}
        }


        #endregion

      
    }

}

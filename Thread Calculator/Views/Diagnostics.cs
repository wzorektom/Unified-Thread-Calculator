using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadCalculatorClassLibrary;

namespace Thread_Calculator
{
    public partial class Diagnostics : Form
    {
        public Diagnostics()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            txt_basicDia.Text = DiagnosticsData.GetBasicDia.ToString();
            txt_le.Text = DiagnosticsData.GetLe.ToString();
            txt_pitch.Text = DiagnosticsData.GetPitch.ToString();
            txt_allowance.Text = DiagnosticsData.GetAllowance.ToString();
            txt_triangle.Text = DiagnosticsData.GetTriangle.ToString();
            txt_basicEffDia.Text = DiagnosticsData.GetBasicEffDia.ToString();

            


            if (DiagnosticsData.GetThreadClass == "1A" || DiagnosticsData.GetThreadClass == "2A" || DiagnosticsData.GetThreadClass == "3A")
            {
                txt_majorMax.Text = DiagnosticsData.GetMajorMax.ToString("F4");
                txt_majorTol.Text = DiagnosticsData.GetMajorTol.ToString("F4");
                txt_majorMin.Text = DiagnosticsData.GetMajorMin.ToString("F4");

                txt_effMax.Text = DiagnosticsData.GetEffMax.ToString("F4");
                txt_effTol.Text = DiagnosticsData.GetEffTol.ToString("F4");
                txt_effMin.Text = DiagnosticsData.GetEffMin.ToString("F4");

                txt_minorMax.Text = DiagnosticsData.GetMinorMax.ToString("F4");
                txt_minorTol.Text = DiagnosticsData.GetMinorTol.ToString("F4");
                txt_minorMin.Text = DiagnosticsData.GetMinorMin.ToString("F4");

                txt_12tpi.Text = "";
                txt_13_80tpi.Text = "";
                txt_minorTolBase.Text = "";

                if ((DiagnosticsData.GetNoCoating == "Yes") && DiagnosticsData.GetBasicDia < 0.5)
                {
                    chk_greaterThan05.Enabled = false;
                    chk_otherCoating.Enabled = false;
                    chk_ps309.Enabled = false;
                    chk_femaleThread.Enabled = false;
                }
                else if ((DiagnosticsData.GetNoCoating == "Yes") && DiagnosticsData.GetBasicDia >= 0.5)
                {
                    chk_greaterThan05.Enabled = true;
                    chk_otherCoating.Enabled = false;
                    chk_ps309.Enabled = false;
                    chk_femaleThread.Enabled = false;
                }
                else if ((DiagnosticsData.GetPS309 == "Yes" ) && (DiagnosticsData.GetBasicDia < 0.5 || DiagnosticsData.GetBasicDia >= 0.5))
                {
                    chk_greaterThan05.Enabled = false;
                    chk_otherCoating.Enabled = false;
                    chk_ps309.Enabled = true;
                    chk_femaleThread.Enabled = false;
                }
                else if ((DiagnosticsData.GetOther == "Yes") && (DiagnosticsData.GetBasicDia < 0.5 || DiagnosticsData.GetBasicDia >= 0.5))
                {
                    chk_greaterThan05.Enabled = false;
                    chk_otherCoating.Enabled = true;
                    chk_ps309.Enabled = false;
                    chk_femaleThread.Enabled = false;
                }



            }
            else
            {
                txt_majorMax.Text = DiagnosticsData.GetMajorMax_Female;
                txt_majorTol.Text = DiagnosticsData.GetMajorTol_Female;
                txt_majorMin.Text = DiagnosticsData.GetMajorMin.ToString("F4");

                txt_effMax.Text = DiagnosticsData.GetEffMax.ToString("F4");
                txt_effTol.Text = DiagnosticsData.GetEffTol.ToString("F4");
                txt_effMin.Text = DiagnosticsData.GetEffMin.ToString("F4");

                txt_minorMax.Text = DiagnosticsData.GetMinorMax.ToString("F4");
                txt_minorTol.Text = DiagnosticsData.GetMinorTol.ToString("F4");
                txt_minorMin.Text = DiagnosticsData.GetMinorMin.ToString("F4");

                if (DiagnosticsData.GetThreadClass == "1B" || DiagnosticsData.GetThreadClass == "2B")
                {
                    txt_13_80tpi.Text = DiagnosticsData.Get13to80TPI.ToString();
                    txt_minorTolBase.Text = "";
                    txt_12tpi.Text = "";
                }
                else
                {
                    if (DiagnosticsData.GetTPI <=12)
                    {
                        if (DiagnosticsData.GetMinorToleranceBase > DiagnosticsData.Get12TPI)
                        {
                            txt_minorTolBase.Text = DiagnosticsData.GetMinorToleranceBase.ToString();
                            txt_13_80tpi.Text = "";
                            txt_12tpi.Text = "";
                        }
                        else
                        {
                            txt_12tpi.Text = DiagnosticsData.Get12TPI.ToString();
                            txt_minorTolBase.Text = "";
                            txt_13_80tpi.Text = "";
                        }
                    }
                    else // (TPI >= 13)
                    {
                        if (DiagnosticsData.GetMinorToleranceBase > DiagnosticsData.Get13to80TPI)
                        {
                            txt_minorTolBase.Text = DiagnosticsData.GetMinorToleranceBase.ToString();
                            txt_13_80tpi.Text = "";
                            txt_12tpi.Text = "";
                        }
                        else
                        {
                            txt_13_80tpi.Text = DiagnosticsData.Get13to80TPI.ToString();
                            txt_minorTolBase.Text = "";
                            txt_12tpi.Text = "";
                        }
                    }
                }


                
                
                

                if ((DiagnosticsData.GetNoCoating == "Yes") && DiagnosticsData.GetBasicDia < 0.5)
                {
                    chk_greaterThan05.Enabled = false;
                    chk_otherCoating.Enabled = false;
                    chk_ps309.Enabled = false;
                    chk_femaleThread.Enabled = true;
                }
                else if ((DiagnosticsData.GetNoCoating == "Yes") && DiagnosticsData.GetBasicDia >= 0.5)
                {
                    chk_greaterThan05.Enabled = false;
                    chk_otherCoating.Enabled = false;
                    chk_ps309.Enabled = false;
                    chk_femaleThread.Enabled = false;
                }
                else if ((DiagnosticsData.GetPS309 == "Yes") && DiagnosticsData.GetBasicDia < 0.5)
                {
                    chk_greaterThan05.Enabled = false;
                    chk_otherCoating.Enabled = false;
                    chk_ps309.Enabled = false;
                    chk_femaleThread.Enabled = true;
                }             
                else if ((DiagnosticsData.GetPS309 == "Yes") && DiagnosticsData.GetBasicDia >= 0.5)
                {
                    chk_greaterThan05.Enabled = false;
                    chk_otherCoating.Enabled = false;
                    chk_ps309.Enabled = false;
                    chk_femaleThread.Enabled = false;
                }
                else if ((DiagnosticsData.GetOther == "Yes") && DiagnosticsData.GetBasicDia < 0.5)
                {
                    chk_greaterThan05.Enabled = false;
                    chk_otherCoating.Enabled = false;
                    chk_ps309.Enabled = false;
                    chk_femaleThread.Enabled = true;
                }
                else if ((DiagnosticsData.GetOther == "Yes") && DiagnosticsData.GetBasicDia >= 0.5)
                {
                    chk_greaterThan05.Enabled = false;
                    chk_otherCoating.Enabled = false;
                    chk_ps309.Enabled = false;
                    chk_femaleThread.Enabled = false;
                }
               
            }


            
        }


        

        private void chk_greaterThan05_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_greaterThan05.Checked == true & DiagnosticsData.GetBasicDia >= 0.5)
            {
                txt_majorMax.Text = (DiagnosticsData.GetMajorMax + DiagnosticsData.All_2Thou).ToString("F4");
                txt_majorTol.Text = DiagnosticsData.GetMajorTol.ToString("F4");
                txt_majorMin.Text = (DiagnosticsData.GetMajorMin + DiagnosticsData.All_2Thou).ToString("F4");

                txt_effMax.Text = (DiagnosticsData.GetEffMax + DiagnosticsData.All_2Thou).ToString("F4");
                txt_effTol.Text = DiagnosticsData.GetEffTol.ToString("F4");
                txt_effMin.Text = (DiagnosticsData.GetEffMin + DiagnosticsData.All_2Thou).ToString("F4");

                txt_minorMax.Text = (DiagnosticsData.GetMinorMax + DiagnosticsData.All_2Thou).ToString("F4");
                txt_minorTol.Text = DiagnosticsData.GetMinorTol.ToString("F4");
                txt_minorMin.Text = (DiagnosticsData.GetMinorMin + DiagnosticsData.All_2Thou).ToString("F4");
            }
            else
            {
                btn_getData.PerformClick();
            }
        }



        private void chk_otherCoating_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_otherCoating.Checked == true)
            {
                txt_majorMax.Text = (DiagnosticsData.GetMajorMax + DiagnosticsData.All_4Thou).ToString("F4");
                txt_majorTol.Text = DiagnosticsData.GetMajorTol.ToString("F4");
                txt_majorMin.Text = (DiagnosticsData.GetMajorMin + DiagnosticsData.All_4Thou).ToString("F4");

                txt_effMax.Text = (DiagnosticsData.GetEffMax + DiagnosticsData.All_4Thou).ToString("F4");
                txt_effTol.Text = DiagnosticsData.GetEffTol.ToString("F4");
                txt_effMin.Text = (DiagnosticsData.GetEffMin + DiagnosticsData.All_4Thou).ToString("F4");

                txt_minorMax.Text = (DiagnosticsData.GetMinorMax + DiagnosticsData.All_4Thou).ToString("F4");
                txt_minorTol.Text = DiagnosticsData.GetMinorTol.ToString("F4");
                txt_minorMin.Text = (DiagnosticsData.GetMinorMin + DiagnosticsData.All_4Thou).ToString("F4");
            }
            else
            {
                btn_getData.PerformClick();
            }
        }


        

        private void chk_ps309_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ps309.Checked == true)
            {
                txt_majorMax.Text = (DiagnosticsData.GetMajorMax + DiagnosticsData.All_9Thou).ToString("F4");
                txt_majorTol.Text = DiagnosticsData.GetMajorTol.ToString("F4");
                txt_majorMin.Text = (DiagnosticsData.GetMajorMin + DiagnosticsData.All_9Thou).ToString("F4");

                txt_effMax.Text = (DiagnosticsData.GetEffMax + DiagnosticsData.All_9Thou).ToString("F4");
                txt_effTol.Text = DiagnosticsData.GetEffTol.ToString("F4");
                txt_effMin.Text = (DiagnosticsData.GetEffMin + DiagnosticsData.All_9Thou).ToString("F4");

                txt_minorMax.Text = (DiagnosticsData.GetMinorMax + DiagnosticsData.All_9Thou).ToString("F4");
                txt_minorTol.Text = DiagnosticsData.GetMinorTol.ToString("F4");
                txt_minorMin.Text = (DiagnosticsData.GetMinorMin + DiagnosticsData.All_9Thou).ToString("F4");
            }
            else
            {
                btn_getData.PerformClick();
            }
        }



        private void chk_femaleThread_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_femaleThread.Checked == true)
            {
                txt_majorMax.Text = DiagnosticsData.GetMajorMax_Female;
                txt_majorTol.Text = DiagnosticsData.GetMajorTol_Female;
                txt_majorMin.Text = (DiagnosticsData.GetMajorMin - DiagnosticsData.All_2Thou).ToString("F4");

                txt_effMax.Text = (DiagnosticsData.GetEffMax - DiagnosticsData.All_2Thou).ToString("F4");
                txt_effTol.Text = DiagnosticsData.GetEffTol.ToString("F4");
                txt_effMin.Text = (DiagnosticsData.GetEffMin - DiagnosticsData.All_2Thou).ToString("F4");

                txt_minorMax.Text = (DiagnosticsData.GetMinorMax - DiagnosticsData.All_2Thou).ToString("F4");
                txt_minorTol.Text = DiagnosticsData.GetMinorTol.ToString("F4");
                txt_minorMin.Text = (DiagnosticsData.GetMinorMin - DiagnosticsData.All_2Thou).ToString("F4");
            }
            else
            {
                btn_getData.PerformClick();
            }
            
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_allowances_Click(object sender, EventArgs e)
        {
            Reference_Table Reftbl = new Reference_Table();
            Reftbl.Show();
        }
    }

}

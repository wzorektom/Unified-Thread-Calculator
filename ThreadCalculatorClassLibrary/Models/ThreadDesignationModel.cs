using System;
using System.Collections.Generic;
using System.Linq;


namespace ThreadCalculatorClassLibrary
{
    public class ThreadDesignationModel
    {

        public double BasicDia { get; set; }
        public double Tpi { get; set; }


        // FINISH THIS BASED ON FORMULA CLASS DESIGNATION METHOD


        private string _UNC = "UNC";
        private string _UNF = "UNF";
        private string _UNEF = "UNEF";
        private string _UN = "UN";
        private string _Designation;

        public string UNC
        {
            get { return _UNC; }
            set { _UNC = value; }
        }

        public string UNF
        {
            get { return _UNF; }
            set { _UNF = value; }
        }

        public string UNEF
        {
            get { return _UNEF; }
            set { _UNEF = value; }
        }

        public string UN
        {
            get { return _UN; }
            set { _UN = value; }
        }

        public string Designation
        {
            get { return _Designation; }
            set { _Designation = value; }
        }


        public List<ThreadDesignationModel> PopulateThreadDesignation()
        {
            List<ThreadDesignationModel> output = new List<ThreadDesignationModel>
            {
                //new ThreadDesignationModel { BasicDia = 0.0600, Tpi = 80, _Designation = UNF }, to small to calculate - no info about TPI and UCut Width in BS1936:1952

                new ThreadDesignationModel { BasicDia = 0.0730, Tpi = 64, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.0730, Tpi = 72, _Designation = UNF},

                new ThreadDesignationModel { BasicDia = 0.0860, Tpi = 56, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.0860, Tpi = 64, _Designation = UNF},

                new ThreadDesignationModel { BasicDia = 0.0990, Tpi = 48, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.0990, Tpi = 56, _Designation = UNF},

                new ThreadDesignationModel { BasicDia = 0.1120, Tpi = 40, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.1120, Tpi = 48, _Designation = UNF},

                new ThreadDesignationModel { BasicDia = 0.1250, Tpi = 40, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.1250, Tpi = 44, _Designation = UNF},

                new ThreadDesignationModel { BasicDia = 0.1380, Tpi = 32, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.1380, Tpi = 40, _Designation = UNF},

                new ThreadDesignationModel { BasicDia = 0.1640, Tpi = 32, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.1640, Tpi = 36, _Designation = UNF},

                new ThreadDesignationModel { BasicDia = 0.1900, Tpi = 24, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.1900, Tpi = 32, _Designation = UNF},

                new ThreadDesignationModel { BasicDia = 0.2160, Tpi = 24, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.2160, Tpi = 28, _Designation = UNF},
                new ThreadDesignationModel { BasicDia = 0.2160, Tpi = 32, _Designation = UNEF},




                new ThreadDesignationModel { BasicDia = 0.2500, Tpi = 20, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.2500, Tpi = 28, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 0.2500, Tpi = 32, _Designation = UNEF},

                new ThreadDesignationModel { BasicDia = 0.3125, Tpi = 18, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.3125, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.3125, Tpi = 24, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 0.3125, Tpi = 28, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.3125, Tpi = 32, _Designation = UNEF },
             
                new ThreadDesignationModel { BasicDia = 0.3750, Tpi = 16, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.3750, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.3750, Tpi = 24, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 0.3750, Tpi = 28, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.3750, Tpi = 32, _Designation = UNEF },
   
                new ThreadDesignationModel { BasicDia = 0.4375, Tpi = 14, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.4375, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.4375, Tpi = 20, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 0.4375, Tpi = 28, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 0.4375, Tpi = 32, _Designation = UN },
                  
                new ThreadDesignationModel { BasicDia = 0.5000, Tpi = 13, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.5000, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.5000, Tpi = 20, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 0.5000, Tpi = 28, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 0.5000, Tpi = 32, _Designation = UN },
              
                new ThreadDesignationModel { BasicDia = 0.5625, Tpi = 12, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.5625, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.5625, Tpi = 18, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 0.5625, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.5625, Tpi = 24, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 0.5625, Tpi = 28, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.5625, Tpi = 32, _Designation = UN },
          
                new ThreadDesignationModel { BasicDia = 0.6250, Tpi = 11, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.6250, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.6250, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.6250, Tpi = 18, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 0.6250, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.6250, Tpi = 24, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 0.6250, Tpi = 28, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.6250, Tpi = 32, _Designation = UN },
                 
                new ThreadDesignationModel { BasicDia = 0.6875, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.6875, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.6875, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.6875, Tpi = 24, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 0.6875, Tpi = 28, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.6875, Tpi = 32, _Designation = UN },
              
                new ThreadDesignationModel { BasicDia = 0.7500, Tpi = 10, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.7500, Tpi = 16, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 0.7500, Tpi = 20, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 0.7500, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.7500, Tpi = 28, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.7500, Tpi = 32, _Designation = UN },
                 
                new ThreadDesignationModel { BasicDia = 0.8125, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.8125, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.8125, Tpi = 20, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 0.8125, Tpi = 28, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.8125, Tpi = 32, _Designation = UN },
        
                new ThreadDesignationModel { BasicDia = 0.8750, Tpi = 9, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 0.8750, Tpi = 14, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 0.8750, Tpi = 20, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 0.8750, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.8750, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.8750, Tpi = 28, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.8750, Tpi = 32, _Designation = UN },
                    
                new ThreadDesignationModel { BasicDia = 0.9375, Tpi = 20, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 0.9375, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.9375, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.9375, Tpi = 28, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 0.9375, Tpi = 32, _Designation = UN },
                 
                new ThreadDesignationModel { BasicDia = 1.000, Tpi = 8, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 1.000, Tpi = 12, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 1.000, Tpi = 20, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.000, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.000, Tpi = 28, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.000, Tpi = 32, _Designation = UN },
         
                new ThreadDesignationModel { BasicDia = 1.0625, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.0625, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.0625, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.0625, Tpi = 18, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.0625, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.0625, Tpi = 28, _Designation = UN },
               
                new ThreadDesignationModel { BasicDia = 1.1250, Tpi = 7, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 1.1250, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.1250, Tpi = 12, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 1.1250, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.1250, Tpi = 18, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.1250, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.1250, Tpi = 28, _Designation = UN },
               
                new ThreadDesignationModel { BasicDia = 1.1875, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.1875, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.1875, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.1875, Tpi = 18, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.1875, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.1875, Tpi = 28, _Designation = UN },
                  
                new ThreadDesignationModel { BasicDia = 1.2500, Tpi = 7, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 1.2500, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.2500, Tpi = 12, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 1.2500, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.2500, Tpi = 18, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.2500, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.2500, Tpi = 28, _Designation = UN },
               
                new ThreadDesignationModel { BasicDia = 1.3125, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.3125, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.3125, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.3125, Tpi = 18, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.3125, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.3125, Tpi = 28, _Designation = UN },
                   
                new ThreadDesignationModel { BasicDia = 1.3750, Tpi = 6, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 1.3750, Tpi = 12, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 1.3750, Tpi = 18, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.3750, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.3750, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.3750, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.3750, Tpi = 28, _Designation = UN },
                   
                new ThreadDesignationModel { BasicDia = 1.4375, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.4375, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.4375, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.4375, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.4375, Tpi = 18, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.4375, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.4375, Tpi = 28, _Designation = UN },
                   
                new ThreadDesignationModel { BasicDia = 1.5000, Tpi = 6, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 1.5000, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.5000, Tpi = 12, _Designation = UNF },
                new ThreadDesignationModel { BasicDia = 1.5000, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.5000, Tpi = 18, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.5000, Tpi = 20, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.5000, Tpi = 28, _Designation = UN },
                
                new ThreadDesignationModel { BasicDia = 1.5625, Tpi = 18, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.5625, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.5625, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.5625, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.5625, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.5625, Tpi = 20, _Designation = UN },
                
                new ThreadDesignationModel { BasicDia = 1.6250, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.6250, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.6250, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.6250, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.6250, Tpi = 18, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.6250, Tpi = 20, _Designation = UN },
           
                new ThreadDesignationModel { BasicDia = 1.6875, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.6875, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.6875, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.6875, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.6875, Tpi = 18, _Designation = UNEF },
                new ThreadDesignationModel { BasicDia = 1.6875, Tpi = 20, _Designation = UN },
                  
                new ThreadDesignationModel { BasicDia = 1.7500, Tpi = 5, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 1.7500, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.7500, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.7500, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.7500, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.7500, Tpi = 20, _Designation = UN },
                 
                new ThreadDesignationModel { BasicDia = 1.8125, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.8125, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.8125, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.8125, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.8125, Tpi = 20, _Designation = UN },
                
                new ThreadDesignationModel { BasicDia = 1.8750, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.8750, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.8750, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.8750, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.8750, Tpi = 20, _Designation = UN },
         
                new ThreadDesignationModel { BasicDia = 1.9375, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.9375, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.9375, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.9375, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 1.9375, Tpi = 20, _Designation = UN },
                   
                new ThreadDesignationModel { BasicDia = 2.0000, Tpi = 4.5, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 2.0000, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.0000, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.0000, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.0000, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.0000, Tpi = 20, _Designation = UN },
                  
                new ThreadDesignationModel { BasicDia = 2.1250, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.1250, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.1250, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.1250, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.1250, Tpi = 20, _Designation = UN },
                 
                new ThreadDesignationModel { BasicDia = 2.2500, Tpi = 4.5, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 2.2500, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.2500, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.2500, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.2500, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.2500, Tpi = 20, _Designation = UN },
                   
                new ThreadDesignationModel { BasicDia = 2.3750, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.3750, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.3750, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.3750, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.3750, Tpi = 20, _Designation = UN },
                 
                new ThreadDesignationModel { BasicDia = 2.5000, Tpi = 4, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 2.5000, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.5000, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.5000, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.5000, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.5000, Tpi = 20, _Designation = UN },
          
                new ThreadDesignationModel { BasicDia = 2.6250, Tpi = 4, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.6250, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.6250, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.6250, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.6250, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.6250, Tpi = 20, _Designation = UN },
                
                new ThreadDesignationModel { BasicDia = 2.7500, Tpi = 4, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 2.7500, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.7500, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.7500, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.7500, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.7500, Tpi = 20, _Designation = UN },
      
                new ThreadDesignationModel { BasicDia = 2.8750, Tpi = 4, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.8750, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.8750, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.8750, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.8750, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 2.8750, Tpi = 20, _Designation = UN },
                 
                new ThreadDesignationModel { BasicDia = 3.0000, Tpi = 4, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 3.0000, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.0000, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.0000, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.0000, Tpi = 16, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.0000, Tpi = 20, _Designation = UN },
                 
                new ThreadDesignationModel { BasicDia = 3.1250, Tpi = 4, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 3.1250, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.1250, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.1250, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.1250, Tpi = 16, _Designation = UN },
                 
                new ThreadDesignationModel { BasicDia = 3.2500, Tpi = 4, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 3.2500, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.2500, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.2500, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.2500, Tpi = 16, _Designation = UN },
                 
                new ThreadDesignationModel { BasicDia = 3.3750, Tpi = 4, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.3750, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.3750, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.3750, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.3750, Tpi = 16, _Designation = UN },
               
                new ThreadDesignationModel { BasicDia = 3.5000, Tpi = 4, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 3.5000, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.5000, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.5000, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.5000, Tpi = 16, _Designation = UN },
                  
                new ThreadDesignationModel { BasicDia = 3.6250, Tpi = 4, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.6250, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.6250, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.6250, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.6250, Tpi = 16, _Designation = UN },
      
                new ThreadDesignationModel { BasicDia = 3.7500, Tpi = 4, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 3.7500, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.7500, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.7500, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.7500, Tpi = 16, _Designation = UN },
               
                new ThreadDesignationModel { BasicDia = 3.8750, Tpi = 4, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.8750, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.8750, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.8750, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 3.8750, Tpi = 16, _Designation = UN },
                
                new ThreadDesignationModel { BasicDia = 4.0000, Tpi = 4, _Designation = UNC },
                new ThreadDesignationModel { BasicDia = 4.0000, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.0000, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.0000, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.0000, Tpi = 16, _Designation = UN },
              
                new ThreadDesignationModel { BasicDia = 4.1250, Tpi = 4, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.1250, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.1250, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.1250, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.1250, Tpi = 16, _Designation = UN },
                  
                new ThreadDesignationModel { BasicDia = 4.2500, Tpi = 4, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.2500, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.2500, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.2500, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.2500, Tpi = 16, _Designation = UN },
            
                new ThreadDesignationModel { BasicDia = 4.3750, Tpi = 4, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.3750, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.3750, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.3750, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.3750, Tpi = 16, _Designation = UN },
                   
                new ThreadDesignationModel { BasicDia = 4.5000, Tpi = 4, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.5000, Tpi = 6, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.5000, Tpi = 8, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.5000, Tpi = 12, _Designation = UN },
                new ThreadDesignationModel { BasicDia = 4.5000, Tpi = 16, _Designation = UN }



            };
            return output;
        }

        public string GetDesignationModel(double basicDia, double tpi)
        {

            List<ThreadDesignationModel> values = PopulateThreadDesignation();
            ThreadDesignationModel result = values.Where(x => x.BasicDia == basicDia && x.Tpi == tpi).FirstOrDefault();

            return result.Designation;


        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainaN_Assign2
{
    internal class SchoolInfo
    {
        //read-only auto property
        public string SchoolName
        {
            get;
        }
        public int MaxEnroll { get; }
        public int PrevYrEnroll { get; }
        public double FundsPerStud
        {
            get;
        }

        //read-write auto propertues
        public int NumStudsLeaving
        {
            get;
            set;
        }
        public int NumStudsJoining { get; set; }

        // read-only computed properties
        // get {return}
        public int CurrYrEnroll
        {
            get
            {
                return PrevYrEnroll + NumStudsJoining - NumStudsLeaving;
            }
        }
        public double TotalFunding
        {
            get
            {
                return FundsPerStud * CurrYrEnroll;
            }
        }


        // constructor
        public  SchoolInfo (string schoolName, int maxEnroll, int prevYrEnroll, double fundsPerStud, int numStudsLeaving, int numStudsJoining)
        {
            SchoolName = schoolName;
            MaxEnroll = maxEnroll;
            PrevYrEnroll = prevYrEnroll;
            FundsPerStud = fundsPerStud;
            NumStudsLeaving = numStudsLeaving;
            NumStudsJoining = numStudsJoining;
        }

        //override string
        public override string ToString()
        {
            string school = string.Format("{0}",SchoolName) + "\t" + string.Format("{0,5}", MaxEnroll) + "\t" + string.Format("{0,15}", PrevYrEnroll) + "\t" 
                + string.Format("{0,18:C}", FundsPerStud) + "\t" + string.Format("{0,20}", NumStudsLeaving) + "\t" + string.Format("{0,25}", NumStudsJoining) + "\t" 
                + string.Format("{0,37}", CurrYrEnroll) + "\t" + string.Format("{0,47:C}",TotalFunding);
            return school;
        }
    }
}

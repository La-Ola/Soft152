using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computing_Coursework
{
    //creating class
    class District
    {
        //declaring attributes
        public string DistName;
        public int numNaighbsInDistrict;
        public Neighbour[] libAllNeighbs = new Neighbour[0];        

        //constructor
        public District(string districtName, string numNaighbourhoodsInDistrict)
        {
            this.DistName = districtName;
            SetnumNaighbsInDistrict(numNaighbourhoodsInDistrict);
        }

        //getters and setters start
        public string GetDistName()
        {
            return DistName;
        }
        public void SetDistName(string districtName)
        {
            this.DistName = districtName;
        }

        public int GetnumNaighbsInDistrict()
        {
            return numNaighbsInDistrict;
        }
        public void SetnumNaighbsInDistrict(string numNaighbourhoodsInDistrict)
        {
            try
            {
                numNaighbsInDistrict = Convert.ToInt32(numNaighbourhoodsInDistrict);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" +
                        e.Message + " Please input a valid number neighbourhoods");
            }
        }
        public Neighbour[] GetNeighbLib()
        {
            return libAllNeighbs;
        }
        public void SetNeighblib(Neighbour[] inlibNeighbs)
        {
            libAllNeighbs = inlibNeighbs;
        }

    }

}

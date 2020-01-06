using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computing_Coursework
{
    public partial class AddNeighb : Form
    {
        public AddNeighb()
        {
            InitializeComponent();
        }

        private void TXTdistName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTnewNeighbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTamountOfProps_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNsubName_Click(object sender, EventArgs e)
        {
            string districtAssign = TXTdistname.Text;
            for (int i = 0; i <= DistrictDATA.libDistrict.Length ; i++)
            {
                if (districtAssign == DistrictDATA.libDistrict[i].GetDistName())
                {
                    string newNeighbName = TXTnewNeighbName.Text;
                    int newNeighbProps = Convert.ToInt32(TXTamountOfProps.Text);
                    int distNum = DistrictDATA.libDistrict[i].GetnumNaighbsInDistrict();

                    District district = new District(districtAssign, distNum.ToString());
                    Neighbour neighbour = new Neighbour(newNeighbName, newNeighbProps);
                    
                    //get length of array
                    int lengthOf = DistrictDATA.libDistrict[i].GetNeighbLib().Length;
                    //makes array one bigger
                    Array.Resize(ref district.libAllNeighbs, lengthOf + 1);
                    //adds new neighbourhood to District array
                    DistrictDATA.libDistrict[i].GetNeighbLib()[lengthOf] = neighbour;
                }
            }
            
            
        }
    }
}

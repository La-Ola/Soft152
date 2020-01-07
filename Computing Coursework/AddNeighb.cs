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

        private void TXTnewNeighbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNsubName_Click(object sender, EventArgs e)
        {
            string districtAssign = TXTdistname.Text;
            for (int i = 0; i < DistrictDATA.libDistrict.Length ; i++)
            {
                
                if (districtAssign.ToString().ToLower() == DistrictDATA.libDistrict[i].GetDistName().ToLower())
                {
                    string newNeighbName = TXTnewNeighbName.Text;
                    int newNeighbProps = 0;

                    int distNumUp = DistrictDATA.libDistrict[i].GetnumNaighbsInDistrict() + 1;
                    DistrictDATA.libDistrict[i].SetnumNaighbsInDistrict(distNumUp.ToString());

                    Neighbour neighbour = new Neighbour(newNeighbName, newNeighbProps);
                    
                    //get length of array
                    int lengthOf = DistrictDATA.libDistrict[i].libAllNeighbs.Length;
                    //makes array one bigger
                    Array.Resize(ref DistrictDATA.libDistrict[i].libAllNeighbs, lengthOf + 1);
                    //adds new neighbourhood to District array
                    DistrictDATA.libDistrict[i].libAllNeighbs[lengthOf] = neighbour;

                   
                }
            }
            this.Hide();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Computing_Coursework
{
    public partial class AddDis : Form
    {
        public AddDis()
        {
            InitializeComponent();
        }

        private void addDis_Load(object sender, EventArgs e)
        {

        }

        private void TXTdist_TextChanged(object sender, EventArgs e)
        {

        }
   
        private void BTNsubName_Click(object sender, EventArgs e)
        {
            string newDistName = TXTDist.Text;
            int newDistNeighbs = 0;

            District district = new District(newDistName, newDistNeighbs.ToString());
            Debug.WriteLine(newDistName);
            //get length of array
            int lengthOf = DistrictDATA.libDistrict.Length;
            //makes array one bigger
            Array.Resize(ref DistrictDATA.libDistrict, lengthOf + 1);
            //adds new neighbourhood to District array
            DistrictDATA.libDistrict[lengthOf] = district;

            this.Hide();
        } 
    }
}

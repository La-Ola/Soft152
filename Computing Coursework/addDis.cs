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
    public partial class AddDis : Form
    {
        public AddDis()
        {
            InitializeComponent();
        }

        private void addDis_Load(object sender, EventArgs e)
        {

        }

        private void TXTdistname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTDistNeighbs_TextChanged(object sender, EventArgs e)
        {

        }
   
        private void BTNsubName_Click(object sender, EventArgs e)
        {
            string newDistName = TXTdistname.Text;
            string newDistNeighbs = TXTDistNeighbs.Text;

            District district = new District(newDistName, newDistNeighbs.ToString());
        } 
    }
}

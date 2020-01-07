using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Computing_Coursework
{
    public partial class AddProp : Form
    {
        public AddProp()
        {
            InitializeComponent();
        }

        private void TXTDisName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTNeighbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTNewProp_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void TXTHostName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTPropID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTHostID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTMinNight_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTAvail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTPropPHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTRoomType_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTPricePNight_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTLat_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTLong_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNsubName_Click(object sender, EventArgs e)
        {
            string districtAssign = TXTDisName.Text;
            string neighbAssign = TXTNeighbName.Text;
            for (int i = 0; i < DistrictDATA.libDistrict.Length; i++)
            {
                if (districtAssign.ToString().ToLower() == DistrictDATA.libDistrict[i].GetDistName().ToLower())
                {
                    for (int j = 0; j < DistrictDATA.libDistrict[i].libAllNeighbs.Length; j++)
                    {
                        if (neighbAssign.ToString().ToLower() == DistrictDATA.libDistrict[i].libAllNeighbs[j].GetneighbName().ToLower())
                        {
                            int propID = Convert.ToInt32(TXTPropID.Text);
                            string propName = TXTNewProp.Text;
                            int hostID = Convert.ToInt32(TXTHostID.Text);
                            string hostName = TXTHostName.Text;
                            int propertyForHost = Convert.ToInt32(TXTPropPHost.Text);
                            double latitude = Convert.ToDouble(TXTLat.Text);
                            double longitude = Convert.ToDouble(TXTLong.Text);
                            string roomType = TXTRoomType.Text;
                            double price = Convert.ToDouble(TXTPricePNight.Text);
                            int minimumNights = Convert.ToInt32(TXTMinNight.Text);
                            int availability = Convert.ToInt32(TXTAvail.Text);

                            int propNumUp = DistrictDATA.libDistrict[i].libAllNeighbs[j].GetnumPropsInNeighbs() + 1;
                            DistrictDATA.libDistrict[i].libAllNeighbs[j].SetnumPropsInNeighbs(propNumUp);

                            Property prop = new Property(propID, hostID, propertyForHost, minimumNights, availability,
                                    propName, hostName, roomType, latitude, longitude, price);

                            //get length of array
                            int lengthOf = DistrictDATA.libDistrict[i].libAllNeighbs[j].libAllProperties.Length;
                            //makes array one bigger
                            Array.Resize(ref DistrictDATA.libDistrict[i].libAllNeighbs[j].libAllProperties, lengthOf + 1);
                            //adds new neighbourhood to District array
                            DistrictDATA.libDistrict[i].libAllNeighbs[j].libAllProperties[lengthOf] = prop;
                        }
                    }     
                }
            }
            this.Hide();
        }

        
    }
}

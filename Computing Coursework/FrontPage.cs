using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Computing_Coursework
{
    public partial class FrontPage : Form
    {
        

        public FrontPage()
        {
            //initializes form
            InitializeComponent();
            //foes straight to collectdata method that pulls in the data
            collectData();
        }

        private void listViewDISTRICT_SelectIndexChanged(object sender, EventArgs e)
        {
            //gets the positional value of the selected district (event listener)
            int districtIndex = listViewDISTRICT.SelectedIndex;
            //runs function to show neighbourhoods baised on the selceted district
            showNeighbs(districtIndex);
            //runs function to show properties of selcted district.
            showDistInfo(districtIndex);
        }

        private void listViewNEIGHB_SelectIndexChanged(object sender, EventArgs e)
        {
            //gets the positional value of the selected district (event listener)
            int districtIndex = listViewDISTRICT.SelectedIndex;
            //gets the positional value of the selected neighbourhood (event listener)
            int neighborhoodIndex = listViewNEIGHB.SelectedIndex;
            //runs function to show properties of selcted district and neighbourhood.
            showProp(districtIndex, neighborhoodIndex);
            //runs function to show properties of selcted neighbourhood.
            showNeighbInfo(districtIndex, neighborhoodIndex);
        }
        
        private void listViewPROP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gets the positional value of the selected district (event listener)
            int districtIndex = listViewDISTRICT.SelectedIndex;
            //gets the positional value of the selected neighbourhood (event listener)
            int neighborhoodIndex = listViewNEIGHB.SelectedIndex;
            //gets the positional value of the selected property (event listener)
            int propIndex = listViewPROP.SelectedIndex;
            //runs function to show properties of selcted property.
            showPropInfo(districtIndex, neighborhoodIndex, propIndex);
        }

        //search bar
        private void TXTBoxsearch_TextChanged(object sender, EventArgs e)
        {
            lstboxDisplay.Items.Clear();
            int lengthOfSearch = TXTBoxsearch.TextLength;
            //counts from bottom up
            try
            {
                for (int i = DistrictDATA.libDistrict.Length - 1; i >= 0; i--)                
                {
                    //uses substring as a way to filter information instead of using contains()
                    //compares whats entered into the textbox against the first x letters of each item in the array
                    if (DistrictDATA.libDistrict[i].GetDistName().ToString().ToLower().Substring(0, lengthOfSearch) == TXTBoxsearch.Text.ToLower())
                    {
                        lstboxDisplay.Items.Add("District: " +DistrictDATA.libDistrict[i].GetDistName());
                    }
                }

                for (int i = DistrictDATA.libDistrict.Length - 1; i >= 0; i--)
                {
                    for (int j = DistrictDATA.libDistrict[i].GetNeighbLib().Length - 1; j >= 0; j--)
                    {
                        if (DistrictDATA.libDistrict[i].GetNeighbLib()[j].GetneighbName().ToString().ToLower().Substring(0, lengthOfSearch) == TXTBoxsearch.Text.ToLower())
                        {
                            lstboxDisplay.Items.Add("Neighbourhood: " +DistrictDATA.libDistrict[i].GetNeighbLib()[j].GetneighbName());
                            lstboxDisplay.Items.Add("   Via: " +DistrictDATA.libDistrict[i].GetDistName());
                        }
                    }             
                }

                for (int i = DistrictDATA.libDistrict.Length - 1; i >= 0; i--)
                {
                    for (int j = DistrictDATA.libDistrict[i].GetNeighbLib().Length - 1; j >= 0; j--)
                    {
                        for (int k = DistrictDATA.libDistrict[i].GetNeighbLib()[j].GetPropLib().Length - 1; k >= 0; k--)
                        {
                            if (DistrictDATA.libDistrict[i].GetNeighbLib()[j].GetPropLib()[k].GetpropName().ToString().ToLower().Substring(0, lengthOfSearch) == TXTBoxsearch.Text.ToLower())
                            {
                                    lstboxDisplay.Items.Add("Property: " +DistrictDATA.libDistrict[i].GetNeighbLib()[j].GetPropLib()[k].GetpropName());
                                    lstboxDisplay.Items.Add("   Via: " +DistrictDATA.libDistrict[i].GetDistName() +" , "+DistrictDATA.libDistrict[i].GetNeighbLib()[j].GetneighbName());
                            }

                        }
                    }
                }
            }
            catch
            {
                lstboxDisplay.Items.Add(" ");
            }          
        }

        private void btnEDITDIST_Click(object sender, EventArgs e)
        {

        }

        private void btnADDDIST_Click(object sender, EventArgs e)
        {
            Form adddis = new AddDis();
            adddis.ShowDialog();
        }

        private void btnEDITNEIGHB_Click(object sender, EventArgs e)
        {

        }

        private void btnADDNEIGHB_Click(object sender, EventArgs e)
        {
            Form addneigh = new AddNeighb();
            addneigh.ShowDialog();
        }

        //property delete button
        private void btnDELPROP_Click(object sender, EventArgs e)
        {
            //gets the positional value of the selected property (event listeners)
            int propIndex = listViewPROP.SelectedIndex;
            int neighborhoodIndex = listViewNEIGHB.SelectedIndex;
            int districtIndex = listViewDISTRICT.SelectedIndex;

            // loopes through overwrites the selected property
            for (int i = propIndex; i < DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib().Length -1 ; i++)
            {
                DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[i] = DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[i + 1];  
            }
            //changes the properties to adjust for deletion
            int LowerProp = DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetnumPropsInNeighbs() - 1;
            DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].SetnumPropsInNeighbs(LowerProp);
            //updates the listboxes
            showNeighbs(districtIndex);
            showProp(districtIndex, neighborhoodIndex);
            listViewPROP.SelectedItem = listViewPROP.Items[0];

        }

        private void btnEDITPROP_Click(object sender, EventArgs e)
        {

        }

        private void btnADDPROP_Click(object sender, EventArgs e)
        {

        }
        
        private void lstboxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void collectData()
        {
            //cals streamreader and creates space for mini dat
            using (StreamReader read = new StreamReader("maxiDat.txt"))
            {
                //steps up array number in while loop
                DistrictDATA.libDistrict = new District[0];


                //while loop goes through whole text file //end of stream
                while (!read.EndOfStream)
                {
                    //reads line by line
                    string districtName = read.ReadLine();
                    int numNaighbourhoodsInDistrict = Convert.ToInt32(read.ReadLine());
                    //adds district to array
                    District district = new District(districtName, numNaighbourhoodsInDistrict.ToString());



                    //for loop to collect neighbourhoods
                    for (int neighbNum = 0; neighbNum < numNaighbourhoodsInDistrict; neighbNum++)
                    {
                        string neighbourhoodName = read.ReadLine();
                        int numPropertiesInNeighbourhood = Convert.ToInt32(read.ReadLine());
                        //adds data to neighb array
                        Neighbour neighbour = new Neighbour(neighbourhoodName, numPropertiesInNeighbourhood);

                        //get length of array
                        int lengthD = district.libAllNeighbs.Length;
                        //makes array one bigger
                        Array.Resize(ref district.libAllNeighbs, lengthD + 1);
                        //adds properties to neighb array
                        district.libAllNeighbs[lengthD] = neighbour;

                        // for loop to collect properties
                        for (int propNum = 0; propNum < numPropertiesInNeighbourhood; propNum++)
                        {
                            int propertyID = Convert.ToInt32(read.ReadLine());
                            string propertyName = read.ReadLine();
                            int hostID = Convert.ToInt32(read.ReadLine());
                            string hostName = read.ReadLine();
                            int propertyForHost = Convert.ToInt32(read.ReadLine());
                            double latitude = Convert.ToDouble(read.ReadLine());
                            double longitude = Convert.ToDouble(read.ReadLine());
                            string roomType = read.ReadLine();
                            double price = Convert.ToDouble(read.ReadLine());
                            int minimumNights = Convert.ToInt32(read.ReadLine());
                            int availability = Convert.ToInt32(read.ReadLine());

                            //adds to property array
                            Property property = new Property(propertyID, hostID, propertyForHost, minimumNights, availability,
                                    propertyName, hostName, roomType, latitude, longitude, price);

                            //get length of array
                            int lengthN = neighbour.libAllProperties.Length;
                            //makes array one bigger
                            Array.Resize(ref neighbour.libAllProperties, lengthN + 1);
                            //adds properties to neighb array
                            neighbour.libAllProperties[lengthN] = property;

                        }

                    }
                    //must be below so it can add the other arrays first
                    //get length of array
                    int length = DistrictDATA.libDistrict.Length;
                    //makes array one bigger
                    Array.Resize(ref DistrictDATA.libDistrict, length + 1);
                    //adds properties to neighb array
                    DistrictDATA.libDistrict[length] = district;


                }
                //calls methods htat displays district, neighbourhood, and property             
                showDist();
                //passes through 0 so that the first element is auto selected
                showNeighbs(0);
                showProp(0, 0);
                //closes streamreader
                read.Close();
            }
            
        }
        private void showDist()
        {

            listViewDISTRICT.Items.Clear();
            //goes through each district 
            foreach (District district in DistrictDATA.libDistrict)
            {
                //writes in each districts name using its getter
                listViewDISTRICT.Items.Add(district.GetDistName());
            }
            listViewDISTRICT.SelectedItem = listViewDISTRICT.Items[0];
        }

        private void showNeighbs(int districtIndex)
        {
            listViewNEIGHB.Items.Clear();

            if (DistrictDATA.libDistrict[districtIndex].numNaighbsInDistrict != 0)
            {
                foreach (Neighbour neighb in DistrictDATA.libDistrict[districtIndex].GetNeighbLib())
                {
                    listViewNEIGHB.Items.Add(neighb.GetneighbName());
                    listViewNEIGHB.SelectedItem = listViewNEIGHB.Items[0];
                }

            }
            else
            {
                listViewNEIGHB.Items.Add("No Neighbouhoods Available");
            }               
           
        }

        private void showProp(int districtIndex, int neighborhoodIndex)
        {
            listViewPROP.Items.Clear();
            if (DistrictDATA.libDistrict[districtIndex].GetnumNaighbsInDistrict() != 0)
            {
                foreach (Property prop in DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib())
                {
                    listViewPROP.Items.Add(prop.GetpropName());
                    listViewPROP.SelectedItem = listViewPROP.Items[0];
                }
            }
            else
            {
                listViewPROP.Items.Add("No Properties Available");
            }
                                
                    
            
        }

        //used to show information about district
        private void showDistInfo(int districtIndex)
        {
            lstboxDisplay.Items.Clear();
            lstboxDisplay.Items.Add("District Name: " + DistrictDATA.libDistrict[districtIndex].GetDistName());
            lstboxDisplay.Items.Add("Number of Neighbourhoods: " + DistrictDATA.libDistrict[districtIndex].GetnumNaighbsInDistrict());

        }

        //used to show information about neighbourhoods
        private void showNeighbInfo(int districtIndex, int neighborhoodIndex)
        {
            lstboxDisplay.Items.Clear();
            lstboxDisplay.Items.Add("Neighbourhood Name: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetneighbName());
            lstboxDisplay.Items.Add("Number of Pproperties: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetnumPropsInNeighbs());

        }

        //used to show information about properties
        private void showPropInfo(int districtIndex, int neighborhoodIndex, int propIndex)
        {
            //clears all items in box then displayes the data
            lstboxDisplay.Items.Clear();
            lstboxDisplay.Items.Add("Property ID: " +DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[propIndex].GetpropID());
            lstboxDisplay.Items.Add("Property Name: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[propIndex].GetpropName());
            lstboxDisplay.Items.Add("Host ID: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[propIndex].GethostID());
            lstboxDisplay.Items.Add("Host Name: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[propIndex].GethostName());
            lstboxDisplay.Items.Add("Properties per Host: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[propIndex].GetpropForHost());
            lstboxDisplay.Items.Add("Latitude: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[propIndex].Getlatit());
            lstboxDisplay.Items.Add("Longitude: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[propIndex].Getlongit());
            lstboxDisplay.Items.Add("Room Type: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[propIndex].GetroomType());
            lstboxDisplay.Items.Add("Price per Night: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[propIndex].Getprice());
            lstboxDisplay.Items.Add("Minimum Nights: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[propIndex].GetminNights());
            lstboxDisplay.Items.Add("Availability: " + DistrictDATA.libDistrict[districtIndex].GetNeighbLib()[neighborhoodIndex].GetPropLib()[propIndex].Getavailability()+ "/365");

        }

        private void FrontPage_Load(object sender, EventArgs e)
        {

        }

        private void FrontPage_Activated(object sender, EventArgs e)
        {
            //gets the positional value of the selected district (event listener)
            int districtIndex = listViewDISTRICT.SelectedIndex;
            //gets the positional value of the selected neighbourhood (event listener)
            int neighborhoodIndex = listViewNEIGHB.SelectedIndex;
            showDist();
            showNeighbs(districtIndex);
            showProp(districtIndex, neighborhoodIndex);
        }
    }
}

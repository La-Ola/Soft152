using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computing_Coursework
{
    //create class
    class Neighbour
    {
        //create attributes
        public string neighbName;
        public int numPropsInNeighbs;
        public Property[] libAllProperties = new Property[0];

        //create constructors
        public Neighbour(string neighbourhoodName, int numPropertiesInNeighbourhood, Property[] inlibProperty)
        {
            this.neighbName = neighbourhoodName;
            SetnumPropsInNeighbs(numPropertiesInNeighbourhood);
            libAllProperties = inlibProperty;  
        }

        public Neighbour(string neighbourhoodName, int numPropertiesInNeighbourhood)
        {
            this.neighbName = neighbourhoodName;
            SetnumPropsInNeighbs(numPropertiesInNeighbourhood);
        }

        //creates getters and setters
        public string GetneighbName()
        {
            return neighbName;
        }
        public void SetneighbName(string neighbourhoodName)
        {
            this.neighbName = neighbourhoodName;
        }

        public int GetnumPropsInNeighbs()
        {
            return numPropsInNeighbs;
        }
        public void SetnumPropsInNeighbs(int numPropertiesInNeighbourhood)
        {
           
            numPropsInNeighbs = numPropertiesInNeighbourhood;
            
        }
        public Property[] GetPropLib()
        {
            return libAllProperties;
        }
        public void SetProperty(Property[] inlibProperty)
        {
            libAllProperties = inlibProperty;
        }
    }
}

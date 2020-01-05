using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computing_Coursework
{
    //creates class
    class Property
    {
        //creates attributes-initialiser 
        public int propID, hostID, propForHost, minNights, availability;
        public string propName, hostName, roomType;
        public double latit, longit, price;

        //creates constructors
        public Property(int propertyID, int hostID, int propertyForHost, int minimumNights,
            int availability, string propertyName, string hostName, string roomType, double latitude,
            double longitude, double price)
        {
            this.propID = propertyID;
            this.hostID = hostID;
            this.propForHost = propertyForHost;
            this.minNights = minimumNights;
            this.availability = availability;
            this.propName = propertyName;
            this.hostName = hostName;
            this.roomType = roomType;
            this.latit = latitude;
            this.longit = longitude;
            this.price = price;

        }

        //creates getters and setters
        public int GetpropID()
        {
            return propID;
        }
        public void SetpropID(int propertyID)
        {
            this.propID = propertyID;
        }

        public int GethostID()
        {
            return hostID;
        }
        public void SethostID(int hostID)
        {
            this.hostID = hostID;
        }

        public int GetpropForHost()
        {
            return propForHost;
        }
        public void SetpropForHost(int propertyForHost)
        {
            this.propForHost = propertyForHost;
        }

        public int GetminNights()
        {
            return minNights;
        }
        public void SetminNights(int minimumNights)
        {
            this.minNights = minimumNights;
        }

        public int Getavailability()
        {
            return availability;
        }
        public void Setavailability(int availability)
        {
            this.availability = availability;
        }

        public string GetpropName()
        {
            return propName;
        }
        public void SetpropName(string propertyName)
        {
            this.propName = propertyName;
        }

        public string GethostName()
        {
            return hostName;
        }
        public void SethostName(string hostName)
        {
            this.hostName = hostName;
        }

        public string GetroomType()
        {
            return roomType;
        }
        public void SetroomType(string roomType)
        {
            this.roomType = roomType;
        }

        public double Getlatit()
        {
            return latit;
        }
        public void Setlatit(double latitude)
        {
            this.latit = latitude;
        }

        public double Getlongit()
        {
            return longit;
        }
        public void Setlongit(double longitude)
        {
            this.longit = longitude;
        }

        public double Getprice()
        {
            return price;
        }
        public void Setprice(double price)
        {
            this.price = price;
        }

    }
}

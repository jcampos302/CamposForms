using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Unit
    {
        // Private Values
        private string osName;
        private string hostname;
        private List<string> ipAddresses;
        private List<string> users;
        

        // Public Values
        public string OsName
        {
            get { return osName; }
            set { osName = value; }
        }
        public string Hostname
        {
            get { return hostname; }
            set { hostname = value; }
        }
        public List<string> IpAddresses
        {
            get { return ipAddresses; }
            set { ipAddresses = value; }
        }
        public List<string> Users
        {
           get { return users; }
           set { users = value; }
        }
        
        
        // Constructors
        public Unit()
        {
            OsName = "";
            Hostname = "";
            IpAddresses = new List<string>();
            Users = new List<string>();
        }
        public Unit(string osName, string hostname,
            List<string> ipAddresses, List<string> users)
        {
            OsName = osName;
            Hostname = hostname;
            IpAddresses = ipAddresses;
            Users = users;
        
        }
        


    }
}

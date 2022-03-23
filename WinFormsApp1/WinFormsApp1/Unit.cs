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
        private string osVersion;
        private string kernel;
        private string architecture;
        private string hostname;
        private List<Unit> ipAddresses;
        private List<Unit> macAddresses;
        private List<Unit> users;
        private string motherboard;
        private string cpu;
        private string gpu;

        // Public Values
        public string OsName
        {
            get { return osName; }
            set { osName = value; }
        }
        public string OsVersion
        {
            get { return osVersion; }
            set { osVersion = value; }
        }
        public string Kernel
        {
            get { return kernel; }
            set { kernel = value; }
        }
        public string Architecture
        {
            get { return architecture; }
            set { architecture = value; }
        }
        public string Hostname
        {
            get { return hostname; }
            set { hostname = value; }
        }
        public List<Unit> IpAddresses
        {
            get { return ipAddresses; }
            set { ipAddresses = value; }
        }
        public List<Unit> MacAddresses
        {
            get { return macAddresses; }
            set { macAddresses = value; }
        }
        public List<Unit> Users
        {
           get { return users; }
           set { users = value; }
        }
        public string Motherboard
        {
            get { return motherboard; }
            set { motherboard = value; }
        }
        public string CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }
        public string GPU
        {
            get { return gpu; }
            set { gpu = value; }
        }
        
        // Constructors
        public Unit()
        {
            OsName = "";
            OsVersion = "";
            Kernel = "";
            Architecture = "";
            Hostname = "";
            IpAddresses = new List<Unit>();
            MacAddresses = new List<Unit>();
            Users = new List<Unit>();
            Motherboard = "";
            CPU = "";
            GPU = "";
        }
        public Unit(string osName, string osVersion, string kernel, string architecture, string hsotname,
            List<Unit> ipAddresses, List<Unit> macAddresses, List<Unit> users, string motherboard, string cpu,
            string gpu)
        {
            OsName = osName;
            OsVersion = osVersion;
            Kernel = kernel;
            Architecture = architecture;
            Hostname = hsotname;
            IpAddresses = ipAddresses;
            MacAddresses = macAddresses;
            Users = users;
            Motherboard = motherboard;
            CPU = cpu;
            GPU = gpu;
        }
        


    }
}

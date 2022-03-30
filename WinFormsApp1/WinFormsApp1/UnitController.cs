using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net;


namespace WinFormsApp1
{
    public class UnitController
    {
        // Object value for unit
        private Unit unit;

        // Contructors 
        public UnitController()
        {
            unit = null;
        }
        public UnitController(Unit unit)
        {
            this.unit = unit;
        }
        
        // Creates object
        public void CreateUnit(string osInfo, string hostName, List<string> ipaddresses, List<string> users)
        {    
            unit = new Unit(osInfo, hostName, ipaddresses, users);   
        }
        
        // Returns Unit Obj
        public Unit GetUnit()
        {
            return unit;
        }

        // Gets Windows Usernames and Domain
        public List<string> GetUsernames()
        {
            // Lists of Users
            List<string> users = new List<string>();
            string user = "";

            // Queues for Windows32 Accounts
            // Needs System.Managment
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            // Parse through list of Users
            foreach (ManagementObject result in searcher.Get())
            {
                user = String.Format("{0}\\{1}\\{}", result["Domain"], result["Name"], result["SID"]);
                users.Add(user);
            }
           
            return users;
        }

        // Get OS Info
        public string getOsInfo()
        {
            // Gets OS version
            var osInfo = Environment.OSVersion;
            string os = String.Format("Platform: {0:G},\n" +
                "Version: {1}, \nMajor: {2}, Mirnor: {3},\n" +
                "Service Pack: {4}\n", osInfo.Platform, osInfo.VersionString, osInfo.Version.Major,
                osInfo.Version.Minor, osInfo.ServicePack);

            return os;
        }

        // Hostname
        public string getHostname()
        {
            return Dns.GetHostName();
        }

        // Uses hostname to get IP addresses on Unit
        // Would like to update to include MAC address and other device infomation.
        public List<string> getIpAddresses(string hostName)
        {

            List<string> ipaddresses = new List<string>();
            for (int i = 0; i < Dns.GetHostByName(hostName).AddressList.Length; i++)
            {
                if (Dns.GetHostByName(hostName).AddressList[i].ToString().Length <= 16)
                {
                    ipaddresses.Add("Ipv4: " + Dns.GetHostByName(hostName).AddressList[i].ToString());
                }
                else
                {
                    ipaddresses.Add("Ipv6: " + Dns.GetHostByName(hostName).AddressList[i].ToString());
                }
                
            }
            return ipaddresses;

            
        }

    }
}

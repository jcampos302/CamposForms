using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Management;
using System.Net.NetworkInformation;
using System.Net;

namespace WinFormsApp1
{
    public class UnitController
    {
        public UnitController()
        {

        }

        public List<string> getUsernames()
        {
            List<string> users = new List<string>();
            string user = "";

            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            foreach (ManagementObject envVar in searcher.Get())
            {
                user = String.Format("{0}\\{1}", envVar["Domain"], envVar["Name"]);
                users.Add(user);
            }
            return users;
            //return domain;
        }

        public string getOsInfo()
        {
            var osInfo = Environment.OSVersion;
            string os = String.Format("Platform: {0:G},\n" +
                "Version: {1}, \nMajor: {2}, Mirnor: {3},\n" +
                "Service Pack: {4}\n", osInfo.Platform, osInfo.VersionString, osInfo.Version.Major,
                osInfo.Version.Minor, osInfo.ServicePack);

            return os;
        }

        public string getHostname()
        {
            return Dns.GetHostName();
        }

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

       
        public string addUnit(string osInfo, string hostName, List<string> ipaddresses, List<string> users)
        {
            Unit unit = new Unit(osInfo,hostName,ipaddresses,users);
            return unit.ToString();
        }

       


    }
}

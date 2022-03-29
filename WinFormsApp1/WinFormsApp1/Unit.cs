using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    [Serializable]
    [XmlInclude(typeof(Unit))]
    public class Unit
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
        public string printList(List<string> list)
        {
            string result = "";
            foreach (string item in list)
            {
                result = result + item + "\n";
            }
            return result;
        }

        // Probably too complicated ToString()
        public override string ToString()
        {
            if (OsName != "")
            {
                if (Hostname != "")
                {
                    if (Users != null)
                    {
                        return String.Format("{0}\n{1}\n{2}\n{3}",OsName,Hostname,printList(IpAddresses), printList(Users));
                    }
                    else
                    {
                        return String.Format("{0}\n{1}\n{2}",OsName,Hostname,printList(IpAddresses));
                    }
                }
                if (Users != null)
                {
                    return String.Format("{0}\n{1}", OsName, printList(Users));
                }
                else
                {
                    return String.Format("{0}", osName);
                }
            }
            if (Hostname != "")
            {
                if (Users != null)
                {
                    return String.Format("{0}\n{1}\n{2}", Hostname, printList(IpAddresses), printList(Users));
                }
                else
                {
                    return String.Format("{0}\n{1}", Hostname, printList(IpAddresses));
                }
            }
            if (Users != null)
            {
                return String.Format("{0}", printList(Users));
            }
            else
            {
                return String.Format("here");
            }
        }



    }
}

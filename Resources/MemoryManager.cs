using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Globalization;
using Microsoft.VisualBasic.Devices;

namespace MemoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Process curr = Process.GetCurrentProcess();

            Console.WriteLine("Name of the process to track (Type 'self' to track this process) : ");
            string process = Console.ReadLine();


            while (true)
            {
                if (process == "self")
                    curr = Process.GetCurrentProcess();
                else
                {
                    try
                    {
                        Process[] procs;
                        procs = Process.GetProcessesByName(process);
                        curr = procs[0];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Press any key to quit");
                        Console.ReadKey(true);
                        Environment.Exit(1);
                    }
                }

                ComputerInfo CI = new ComputerInfo();

                float physMemUsageProto = ((float)curr.WorkingSet64 / (float)CI.TotalPhysicalMemory) * 100;
                float physMemUsage = (float)Math.Round(physMemUsageProto, 2);

                float virtMemUsageProto = ((float)curr.VirtualMemorySize64 / (float)CI.TotalVirtualMemory) * 100;
                float virtMemUsage = (float)Math.Round(virtMemUsageProto, 2);

                object[] categories = new object[7] { "Process name", "Id", "Private memory", "WorkingSet", "Virtual memory", "Phys mem usage", "Virt mem usage" };
                object[] parametersCurrProc = new object[7] { curr.ProcessName, curr.Id, curr.PrivateMemorySize64, curr.WorkingSet64, curr.VirtualMemorySize64, physMemUsage + " %", virtMemUsage
                + " %" };

                object[] categoriesM = new object[6] { "Machine name", "Address", "Av. physical memory", "Tot. physical memory", "Av. virtual memory", "Tot. virtual memory" };
                object[] parametersComputer = new object[6] { Environment.MachineName, "::1", CI.AvailablePhysicalMemory, CI.TotalPhysicalMemory, CI.AvailableVirtualMemory, CI.TotalVirtualMemory };

                Console.Clear();

                Console.WriteLine("=========Process=========");
                for (int i = 0; i < categories.Length; i++)
                {
                    Console.WriteLine("{0} : {1}", categories[i], parametersCurrProc[i]);
                }

                Console.WriteLine("\n\n");

                Console.WriteLine("=========Computer=========");
                for (int i = 0; i < categoriesM.Length; i++)
                {
                    Console.WriteLine("{0} : {1}", categoriesM[i], parametersComputer[i]);
                }

                Console.WriteLine("\n\n\n\n\n'Av.' = Available ; 'Tot.' = Total \n'Phys' = Physical ; 'Virt' = Virtual");
                Thread.Sleep(1000);
            }
        }
    }
}

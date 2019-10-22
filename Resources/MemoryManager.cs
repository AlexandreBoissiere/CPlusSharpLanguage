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
            while (true)
            {
                Process curr = Process.GetCurrentProcess();
                ComputerInfo CI = new ComputerInfo();

                object[] categories = new object[5] { "Process name", "Id", "Private memory", "WorkingSet", "Virtual memory" };
                object[] separators = new object[5] { "=============", "=====", "==============", "=============", "===============" };
                object[] parametersCurrProc = new object[5] { curr.ProcessName, curr.Id, curr.PrivateMemorySize64, curr.WorkingSet64, curr.VirtualMemorySize64 };

                object[] categoriesM = new object[6] { "Machine name", "Address", "Av. physical memory", "Tot. physical memory", "Av. virtual memory", "Tot. virtual memory"};
                object[] separatorsM = new object[6] { "===============", "=======", "===================", "====================", "===================", "===================="};
                object[] parametersComputer = new object[6] { Environment.MachineName, "::1", CI.AvailablePhysicalMemory, CI.TotalPhysicalMemory, CI.AvailableVirtualMemory, CI.TotalVirtualMemory };

                Console.Clear();

                Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "{0,-10}    {1,-10}{2,-10}   {3,-10}\t   {4,-10}", categories));
                Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "{0,-10}   {1,-10}{2,-10}   {3,-10}   {4,-10}", separators));
                Console.WriteLine(string.Format(CultureInfo.CurrentCulture,"{0,-10}   {1,-10}{2,-10}       {3,-10}\t   {4,-10}", parametersCurrProc));

                Console.WriteLine("\n\n");

                Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "{0,-10}      {1,-10}{2,-10}   {3,-10}\t {4,-10}   {5,-10}", categoriesM));
                Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "{0,-10}   {1,-10}{2,-10}   {3,-10}   {4,-10}  {5,-10}", separatorsM));
                Console.WriteLine(string.Format(CultureInfo.CurrentCulture, "{0,-10}   {1,-10}{2,-10}       \t  {3,-10}\t         {4,-10}\t      {5,-10}", parametersComputer));

                Console.WriteLine("\n\n\n\n\n'Av.' = Available ; 'Tot.' = Total");
                Thread.Sleep(1000);
            }
        }
    }
}

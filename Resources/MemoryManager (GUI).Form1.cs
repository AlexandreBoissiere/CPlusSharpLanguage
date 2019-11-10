using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using System.Net;

namespace MemoryManager__GUI_
{
    public partial class Form1 : Form
    {
        private string userProcess = "";
        private Process userProcessManager;
        private Process[] userProcessAlias;

        ComputerInfo CI;


        delegate void VoidDelegateInvokeLabel();
        VoidDelegateInvokeLabel ProcessNameText;
        VoidDelegateInvokeLabel ProcessIdText;
        VoidDelegateInvokeLabel ProcessPrivateMemText;
        VoidDelegateInvokeLabel ProcessWorkingSetText;
        VoidDelegateInvokeLabel ProcessVirtualMemText;
        VoidDelegateInvokeLabel ProcessPhysMemUsageText;
        VoidDelegateInvokeLabel ProcessVirtMemUsageText;

        delegate void VoidDelegateInvokeProgressBar();
        VoidDelegateInvokeProgressBar PhysMemUsageByProc_ProgBarDelegate;

        private Thread AutoChangeProcessNameLabelText;
        private Thread AutoChangeProcessIdLabelText;
        private Thread AutoChangeProcessPrivateMemText;
        private Thread AutoChangeProcessWorkingSetText;
        private Thread AutoChangeProcessVirtualMemText;
        private Thread AutoChangeProcessPhysMemUsageText;
        private Thread AutoChangeProcessVirtMemUsageText;

        private Thread AutoChangePhysMemUsageByProc_ProgBarValue;

        private Thread AutoChangeMachineNameText;
        private Thread AutochangeIPAddressText;
        private Thread AutoChangeAvPhysMemText;
        private Thread AutoChangeTotPhysMemText;
        private Thread AutoChangeAvVirtMemText;
        private Thread AutoChangeTotVirtMemText;
        private Thread AutoChangePhysMemUsageText;
        private Thread AutoChangeVirtMemUsageText;

        private Thread AutoChangePhysMemUsageProgBar;
        private Thread AutoChangeAvPhysMemProgBar;
        private Thread AutoChangeVirtMemUsageProgBar;
        private Thread AutoChangeAvVirtMemProgBar;

        public Form1()
        {
            InitializeComponent();

            AutoChangeProcessNameLabelText = new Thread(new ThreadStart(ChangeProcessNameTextThread));
            AutoChangeProcessIdLabelText = new Thread(new ThreadStart(ChangeProcessIdTextThread));
            AutoChangeProcessPrivateMemText = new Thread(new ThreadStart(ChangeProcessPrivateMemTextThread));
            AutoChangeProcessWorkingSetText = new Thread(new ThreadStart(ChangeProcessWorkingSetTextThread));
            AutoChangeProcessVirtualMemText = new Thread(new ThreadStart(ChangeProcessVirtualMemTextThread));
            AutoChangeProcessPhysMemUsageText = new Thread(new ThreadStart(ChangeProcessPhysMemUsageTextThread));
            AutoChangeProcessVirtMemUsageText = new Thread(new ThreadStart(ChangeProcessVirtMemUsageTextThread));
            AutoChangePhysMemUsageByProc_ProgBarValue = new Thread(new ThreadStart(ChangePhysMemUsageByProc_ProgBarThread));
            AutoChangeMachineNameText = new Thread(new ThreadStart(ChangeMachineNameTextThread));
            AutochangeIPAddressText = new Thread(new ThreadStart(ChangeIPAddressTextThread));
            AutoChangeAvPhysMemText = new Thread(new ThreadStart(ChangeAvPhysMemTextThread));
            AutoChangeTotPhysMemText = new Thread(new ThreadStart(ChangeTotPhysMemTextThread));
            AutoChangeAvVirtMemText = new Thread(new ThreadStart(ChangeAvVirtMemTextThread));
            AutoChangeTotVirtMemText = new Thread(new ThreadStart(ChangeTotVirtMemTextThread));
            AutoChangePhysMemUsageText = new Thread(new ThreadStart(ChangePhysMemUsageTextThread));
            AutoChangeVirtMemUsageText = new Thread(new ThreadStart(ChangeVirtMemUsageTextThread));
            AutoChangePhysMemUsageProgBar = new Thread(new ThreadStart(ChangePhysMemTotUsage_ProgBarThread));
            AutoChangeAvPhysMemProgBar = new Thread(new ThreadStart(ChangeAvPhysMem_ProgBarThread));
            AutoChangeVirtMemUsageProgBar = new Thread(new ThreadStart(ChangeVirtMemTotUsage_ProgBarThread));
            AutoChangeAvVirtMemProgBar = new Thread(new ThreadStart(ChangeAvVirtMem_ProgBarThread));
        }

        private void RestartThreads()
        {
            AutoChangeProcessNameLabelText.Abort();
            AutoChangeProcessNameLabelText = new Thread(new ThreadStart(ChangeProcessNameTextThread));
            AutoChangeProcessNameLabelText.Start();

            AutoChangeProcessIdLabelText.Abort();
            AutoChangeProcessIdLabelText = new Thread(new ThreadStart(ChangeProcessIdTextThread));
            AutoChangeProcessIdLabelText.Start();

            AutoChangeProcessPrivateMemText.Abort();
            AutoChangeProcessPrivateMemText = new Thread(new ThreadStart(ChangeProcessPrivateMemTextThread));
            AutoChangeProcessPrivateMemText.Start();

            AutoChangeProcessWorkingSetText.Abort();
            AutoChangeProcessWorkingSetText = new Thread(new ThreadStart(ChangeProcessWorkingSetTextThread));
            AutoChangeProcessWorkingSetText.Start();

            AutoChangeProcessVirtualMemText.Abort();
            AutoChangeProcessVirtualMemText = new Thread(new ThreadStart(ChangeProcessVirtualMemTextThread));
            AutoChangeProcessVirtualMemText.Start();

            AutoChangeProcessPhysMemUsageText.Abort();
            AutoChangeProcessPhysMemUsageText = new Thread(new ThreadStart(ChangeProcessPhysMemUsageTextThread));
            AutoChangeProcessPhysMemUsageText.Start();

            AutoChangeProcessVirtMemUsageText.Abort();
            AutoChangeProcessVirtMemUsageText = new Thread(new ThreadStart(ChangeProcessVirtMemUsageTextThread));
            AutoChangeProcessVirtMemUsageText.Start();

            AutoChangePhysMemUsageByProc_ProgBarValue.Abort();
            AutoChangePhysMemUsageByProc_ProgBarValue = new Thread(new ThreadStart(ChangePhysMemUsageByProc_ProgBarThread));
            AutoChangePhysMemUsageByProc_ProgBarValue.Start();
        }

        private void StopThreads()
        {
            AutoChangeProcessNameLabelText.Abort();
            AutoChangeProcessIdLabelText.Abort();
            AutoChangeProcessPrivateMemText.Abort();
            AutoChangeProcessWorkingSetText.Abort();
            AutoChangeProcessVirtualMemText.Abort();
            AutoChangeProcessPhysMemUsageText.Abort();
            AutoChangeProcessVirtMemUsageText.Abort();
            AutoChangePhysMemUsageByProc_ProgBarValue.Abort();
            AutoChangeMachineNameText.Abort();
            AutochangeIPAddressText.Abort();
            AutoChangeAvPhysMemText.Abort();
            AutoChangeTotPhysMemText.Abort();
            AutoChangeAvVirtMemText.Abort();
            AutoChangeTotVirtMemText.Abort();
            AutoChangePhysMemUsageText.Abort();
            AutoChangeVirtMemUsageText.Abort();
            AutoChangePhysMemUsageProgBar.Abort();
            AutoChangeAvPhysMemProgBar.Abort();
            AutoChangeVirtMemUsageProgBar.Abort();
            AutoChangeAvVirtMemProgBar.Abort();
        }

        private void StartThreads()
        {
            AutoChangeProcessNameLabelText.Start();
            AutoChangeProcessIdLabelText.Start();
            AutoChangeProcessPrivateMemText.Start();
            AutoChangeProcessWorkingSetText.Start();
            AutoChangeProcessVirtualMemText.Start();
            AutoChangeProcessPhysMemUsageText.Start();
            AutoChangeProcessVirtMemUsageText.Start();
            AutoChangePhysMemUsageByProc_ProgBarValue.Start();
            AutoChangeMachineNameText.Start();
            AutochangeIPAddressText.Start();
            AutoChangeAvPhysMemText.Start();
            AutoChangeTotPhysMemText.Start();
            AutoChangeAvVirtMemText.Start();
            AutoChangeTotVirtMemText.Start();
            AutoChangePhysMemUsageText.Start();
            AutoChangeVirtMemUsageText.Start();
            AutoChangePhysMemUsageProgBar.Start();
            AutoChangeAvPhysMemProgBar.Start();
            AutoChangeVirtMemUsageProgBar.Start();
            AutoChangeAvVirtMemProgBar.Start();
        }

        private void ChangeProcessNameText()
        {
             if (userProcess != "")
             {
                 userProcessAlias = Process.GetProcessesByName(userProcess);
                 userProcessManager = userProcessAlias[0];
                 ProcessNameLabel.Text = "Process name : " + userProcessManager.ProcessName;
             }
             else
             {
                 userProcessManager = Process.GetCurrentProcess();
                 ProcessNameLabel.Text = "Process name : " + userProcessManager.ProcessName;
             }
        }
        private void ChangeProcessNameTextThread()
        {
            while (true)
            {
                ProcessNameText = new VoidDelegateInvokeLabel(ChangeProcessNameText);
                if (ProcessNameLabel.InvokeRequired)
                {
                    ProcessNameLabel.Invoke(ProcessNameText);
                }
                else
                {
                    ChangeProcessNameText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeProcessIdText()
        {
            if (userProcess != "")
            {
                userProcessAlias = Process.GetProcessesByName(userProcess);
                userProcessManager = userProcessAlias[0];
                ProcessIdLabel.Text = "Id : " + userProcessManager.Id;
            }
            else
            {
                userProcessManager = Process.GetCurrentProcess();
                ProcessIdLabel.Text = "Id : " + userProcessManager.Id;
            }
        }
        private void ChangeProcessIdTextThread()
        {
            while (true)
            {
                ProcessIdText = new VoidDelegateInvokeLabel(ChangeProcessIdText);
                if (ProcessIdLabel.InvokeRequired)
                {
                    ProcessIdLabel.Invoke(ProcessIdText);
                }
                else
                {
                    ChangeProcessIdText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeProcessPrivateMemText()
        {
            if (userProcess != "")
            {
                userProcessAlias = Process.GetProcessesByName(userProcess);
                userProcessManager = userProcessAlias[0];
                ProcessPrivateMemLabel.Text = "Private memory : " + userProcessManager.PrivateMemorySize64;
            }
            else
            {
                userProcessManager = Process.GetCurrentProcess();
                ProcessPrivateMemLabel.Text = "Private memory : " + userProcessManager.PrivateMemorySize64;
            }
        }
        private void ChangeProcessPrivateMemTextThread()
        {
            while (true)
            {
                ProcessPrivateMemText = new VoidDelegateInvokeLabel(ChangeProcessPrivateMemText);
                if (ProcessPrivateMemLabel.InvokeRequired)
                {
                    ProcessPrivateMemLabel.Invoke(ProcessPrivateMemText);
                }
                else
                {
                    ChangeProcessPrivateMemText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeProcessWorkingSetText()
        {
            if (userProcess != "")
            {
                userProcessAlias = Process.GetProcessesByName(userProcess);
                userProcessManager = userProcessAlias[0];
                ProcessWorkingSetLabel.Text = "WorkingSet : " + userProcessManager.WorkingSet64;
            }
            else
            {
                userProcessManager = Process.GetCurrentProcess();
                ProcessWorkingSetLabel.Text = "WorkingSet : " + userProcessManager.WorkingSet64;
            }
        }
        private void ChangeProcessWorkingSetTextThread()
        {
            while (true)
            {
                ProcessWorkingSetText = new VoidDelegateInvokeLabel(ChangeProcessWorkingSetText);
                if (ProcessWorkingSetLabel.InvokeRequired)
                {
                    ProcessWorkingSetLabel.Invoke(ProcessWorkingSetText);
                }
                else
                {
                    ChangeProcessWorkingSetText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeProcessVirtualMemText()
        {
            if (userProcess != "")
            {
                userProcessAlias = Process.GetProcessesByName(userProcess);
                userProcessManager = userProcessAlias[0];
                ProcessVirtualMemLabel.Text = "Virtual memory : " + userProcessManager.VirtualMemorySize64;
            }
            else
            {
                userProcessManager = Process.GetCurrentProcess();
                ProcessVirtualMemLabel.Text = "Virtual memory : " + userProcessManager.VirtualMemorySize64;
            }
        }
        private void ChangeProcessVirtualMemTextThread()
        {
            while (true)
            {
                ProcessVirtualMemText = new VoidDelegateInvokeLabel(ChangeProcessVirtualMemText);
                if (ProcessVirtualMemLabel.InvokeRequired)
                {
                    ProcessVirtualMemLabel.Invoke(ProcessVirtualMemText);
                }
                else
                {
                    ChangeProcessVirtualMemText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeProcessPhysMemUsageText()
        {
            CI = new ComputerInfo();
            float usage = (float)Math.Round(((float)userProcessManager.WorkingSet64 / (float)CI.TotalPhysicalMemory) * 100, 2);
            if (userProcess != "")
            {
                userProcessAlias = Process.GetProcessesByName(userProcess);
                userProcessManager = userProcessAlias[0];
                ProcessPhysMemUsageLabel.Text = "Physical memory usage : " + usage + " %";
            }
            else
            {
                userProcessManager = Process.GetCurrentProcess();
                ProcessPhysMemUsageLabel.Text = "Physical memory usage : " + usage + " %";
            }
        }
        private void ChangeProcessPhysMemUsageTextThread()
        {
            while (true)
            {
                ProcessPhysMemUsageText = new VoidDelegateInvokeLabel(ChangeProcessPhysMemUsageText);
                if (ProcessPhysMemUsageLabel.InvokeRequired)
                {
                    ProcessPhysMemUsageLabel.Invoke(ProcessPhysMemUsageText);
                }
                else
                {
                    ChangeProcessPhysMemUsageText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeProcessVirtMemUsageText()
        {
            CI = new ComputerInfo();
            float usage = (float)Math.Round(((float)userProcessManager.VirtualMemorySize64 / (float)CI.TotalVirtualMemory) * 100, 2);
            if (userProcess != "")
            {
                userProcessAlias = Process.GetProcessesByName(userProcess);
                userProcessManager = userProcessAlias[0];
                ProcessVirtMemUsageLabel.Text = "Virtual memory usage : " + usage + " %";
            }
            else
            {
                userProcessManager = Process.GetCurrentProcess();
                ProcessVirtMemUsageLabel.Text = "Virtual memory usage : " + usage + " %";
            }
        }
        private void ChangeProcessVirtMemUsageTextThread()
        {
            while (true)
            {
                ProcessVirtMemUsageText = new VoidDelegateInvokeLabel(ChangeProcessVirtMemUsageText);
                if (ProcessVirtMemUsageLabel.InvokeRequired)
                {
                    ProcessVirtMemUsageLabel.Invoke(ProcessVirtMemUsageText);
                }
                else
                {
                    ChangeProcessVirtMemUsageText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangePhysMemUsageByProc_ProgBar()
        {
            string Svalue_Base = ProcessPhysMemUsageLabel.Text;
            Svalue_Base = Svalue_Base.Trim( new char[] { 'P', 'h', 'y', 's', 'i', 'c', 'a', 'l', 'm', 'e', 'm', 'o', 'r', 'y', 'u', 's', 'a', 'g', 'e', ' ', ':', ' ', '%' });
            double Dvalue = double.Parse(Svalue_Base);
            PhysMemUsageByProc_ProgBar.Value = (int)Math.Round(Dvalue);
        }
        private void ChangePhysMemUsageByProc_ProgBarThread()
        {
            while (true)
            {
                PhysMemUsageByProc_ProgBarDelegate = new VoidDelegateInvokeProgressBar(ChangePhysMemUsageByProc_ProgBar);
                if (PhysMemUsageByProc_ProgBar.InvokeRequired)
                {
                    PhysMemUsageByProc_ProgBar.Invoke(PhysMemUsageByProc_ProgBarDelegate);
                }
                else
                {
                    ChangePhysMemUsageByProc_ProgBar();
                }
                Thread.Sleep(1000);
            }
        }


        private void ChangeMachineNameText()
        {
            CI = new ComputerInfo();
            MachineName.Text = "Machine name : " + Environment.MachineName;
        }
        private void ChangeMachineNameTextThread()
        {
            while (true)
            {
                if (MachineName.InvokeRequired)
                {
                    MachineName.Invoke(new VoidDelegateInvokeLabel(ChangeMachineNameText));
                }
                else
                {
                    ChangeMachineNameText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeIPAddressText()
        {
            CI = new ComputerInfo();
            IPAddress.Text = "Address (IPv6) : " + Convert.ToString(Dns.GetHostEntry(Dns.GetHostName()).AddressList[0]);
        }
        private void ChangeIPAddressTextThread()
        {
            while (true)
            {
                if (IPAddress.InvokeRequired)
                {
                    IPAddress.Invoke(new VoidDelegateInvokeLabel(ChangeIPAddressText));
                }
                else
                {
                    ChangeIPAddressText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeAvPhysMemText()
        {
            CI = new ComputerInfo();
            AvPhysMem.Text = "Available physical memory : " + CI.AvailablePhysicalMemory;
        }
        private void ChangeAvPhysMemTextThread()
        {
            while (true)
            {
                if (AvPhysMem.InvokeRequired)
                {
                    AvPhysMem.Invoke(new VoidDelegateInvokeLabel(ChangeAvPhysMemText));
                }
                else
                {
                    ChangeAvPhysMemText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeTotPhysMemText()
        {
            CI = new ComputerInfo();
            TotPhysMem.Text = "Total physical memory : " + CI.TotalPhysicalMemory;
        }
        private void ChangeTotPhysMemTextThread()
        {
            while (true)
            {
                if (TotPhysMem.InvokeRequired)
                {
                    TotPhysMem.Invoke(new VoidDelegateInvokeLabel(ChangeTotPhysMemText));
                }
                else
                {
                    ChangeTotPhysMemText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeAvVirtMemText()
        {
            CI = new ComputerInfo();
            AvVirtMem.Text = "Available virtual memory : " + CI.AvailableVirtualMemory;
        }
        private void ChangeAvVirtMemTextThread()
        {
            while (true)
            {
                if (AvVirtMem.InvokeRequired)
                {
                    AvVirtMem.Invoke(new VoidDelegateInvokeLabel(ChangeAvVirtMemText));
                }
                else
                {
                    ChangeAvVirtMemText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeTotVirtMemText()
        {
            CI = new ComputerInfo();
            TotVirtMem.Text = "Total virtual memory : " + CI.TotalVirtualMemory;
        }
        private void ChangeTotVirtMemTextThread()
        {
            while (true)
            {
                if (TotVirtMem.InvokeRequired)
                {
                    TotVirtMem.Invoke(new VoidDelegateInvokeLabel(ChangeTotVirtMemText));
                }
                else
                {
                    ChangeTotVirtMemText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangePhysMemUsageText()
        {
            CI = new ComputerInfo();
            decimal MemUsage = (decimal)CI.TotalPhysicalMemory - (decimal)CI.AvailablePhysicalMemory;
            PhysMemUsage.Text = "Physical memory usage : " + Math.Round((MemUsage / (decimal)CI.TotalPhysicalMemory) * 100) + " %";
        }
        private void ChangePhysMemUsageTextThread()
        {
            while (true)
            {
                if (PhysMemUsage.InvokeRequired)
                {
                    PhysMemUsage.Invoke(new VoidDelegateInvokeLabel(ChangePhysMemUsageText));
                }
                else
                {
                    ChangePhysMemUsageText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeVirtMemUsageText()
        {
            CI = new ComputerInfo();
            decimal MemUsage = (decimal)CI.TotalVirtualMemory - (decimal)CI.AvailableVirtualMemory;
            VirtMemUsage.Text = "Virtual memory usage : " + Math.Round((MemUsage / (decimal)CI.TotalVirtualMemory) * 100) + " %";
        }
        private void ChangeVirtMemUsageTextThread()
        {
            while (true)
            {
                if (VirtMemUsage.InvokeRequired)
                {
                    VirtMemUsage.Invoke(new VoidDelegateInvokeLabel(ChangeVirtMemUsageText));
                }
                else
                {
                    ChangeVirtMemUsageText();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangePhysMemTotUsage_ProgBar()
        {
            string Svalue_Base = PhysMemUsage.Text;
            Svalue_Base = Svalue_Base.Trim( new char[] { 'P', 'h', 'y', 's', 'i', 'c', 'a', 'l', 'm', 'e', 'm', 'o', 'r', 'y', 'u', 's', 'a', 'g', 'e', ' ', ':', ' ', '%' });
            double Dvalue = double.Parse(Svalue_Base);
            PhysMemUsageProgBar.Value = (int)Math.Round(Dvalue);
        }
        private void ChangePhysMemTotUsage_ProgBarThread()
        {
            while (true)
            {
                if (PhysMemUsageProgBar.InvokeRequired)
                {
                    PhysMemUsageProgBar.Invoke(new VoidDelegateInvokeProgressBar(ChangePhysMemTotUsage_ProgBar));
                }
                else
                {
                    ChangePhysMemTotUsage_ProgBar();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeAvPhysMem_ProgBar()
        {
            CI = new ComputerInfo();
            decimal Dvalue = ((decimal)CI.AvailablePhysicalMemory / (decimal)CI.TotalPhysicalMemory) * 100;
            AvPhysMemProgBar.Value = (int)Math.Round(Dvalue);
        }
        private void ChangeAvPhysMem_ProgBarThread()
        {
            while (true)
            {
                if (AvPhysMemProgBar.InvokeRequired)
                {
                    AvPhysMemProgBar.Invoke(new VoidDelegateInvokeProgressBar(ChangeAvPhysMem_ProgBar));
                }
                else
                {
                    ChangeAvPhysMem_ProgBar();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeVirtMemTotUsage_ProgBar()
        {
            string Svalue_Base = VirtMemUsage.Text;
            Svalue_Base = Svalue_Base.Trim( new char[] { 'V', 'i', 'r', 't', 'u', 'a', 'l', 'm', 'e', 'm', 'o', 'r', 'y', 'u', 's', 'a', 'g', 'e', ' ', ':', ' ', '%' });
            double Dvalue = double.Parse(Svalue_Base);
            VirtMemUsageProgBar.Value = (int)Math.Round(Dvalue);
        }
        private void ChangeVirtMemTotUsage_ProgBarThread()
        {
            while (true)
            {
                if (VirtMemUsageProgBar.InvokeRequired)
                {
                    VirtMemUsageProgBar.Invoke(new VoidDelegateInvokeProgressBar(ChangeVirtMemTotUsage_ProgBar));
                }
                else
                {
                    ChangeVirtMemTotUsage_ProgBar();
                }
                Thread.Sleep(1000);
            }
        }

        private void ChangeAvVirtMem_ProgBar()
        {
            CI = new ComputerInfo();
            decimal Dvalue = ((decimal)CI.AvailableVirtualMemory / (decimal)CI.TotalVirtualMemory) * 100;
            AvVirtMemProgBar.Value = (int)Math.Round(Dvalue);
        }
        private void ChangeAvVirtMem_ProgBarThread()
        {
            while (true)
            {
                if (AvVirtMemProgBar.InvokeRequired)
                {
                    AvVirtMemProgBar.Invoke(new VoidDelegateInvokeProgressBar(ChangeAvVirtMem_ProgBar));
                }
                else
                {
                    ChangeAvVirtMem_ProgBar();
                }
                Thread.Sleep(1000);
            }
        }

        private void TrackingButton_Click(object sender, EventArgs e)
        {
            if (ProcessNameTextBox.Text == "self")
            {
                userProcess = "";
            }
            else
            {
                userProcess = ProcessNameTextBox.Text;
            }

            if (AutoChangeProcessNameLabelText.IsAlive) // Si ce Thread est en vie, alors les autres aussi.
            {
                RestartThreads();
            }
            else
            {
                StartThreads();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopThreads();
        }
    }
}

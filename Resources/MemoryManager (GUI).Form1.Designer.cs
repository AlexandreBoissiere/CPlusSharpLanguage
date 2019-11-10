namespace MemoryManager__GUI_
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProcessVirtMemUsageLabel = new System.Windows.Forms.Label();
            this.ProcessPhysMemUsageLabel = new System.Windows.Forms.Label();
            this.ProcessVirtualMemLabel = new System.Windows.Forms.Label();
            this.ProcessWorkingSetLabel = new System.Windows.Forms.Label();
            this.ProcessPrivateMemLabel = new System.Windows.Forms.Label();
            this.ProcessIdLabel = new System.Windows.Forms.Label();
            this.ProcessNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VirtMemUsage = new System.Windows.Forms.Label();
            this.PhysMemUsage = new System.Windows.Forms.Label();
            this.TotVirtMem = new System.Windows.Forms.Label();
            this.AvVirtMem = new System.Windows.Forms.Label();
            this.TotPhysMem = new System.Windows.Forms.Label();
            this.AvPhysMem = new System.Windows.Forms.Label();
            this.IPAddress = new System.Windows.Forms.Label();
            this.MachineName = new System.Windows.Forms.Label();
            this.ProcessNameHelpIndicatorLabel = new System.Windows.Forms.Label();
            this.ProcessNameTextBox = new System.Windows.Forms.TextBox();
            this.TrackingButton = new System.Windows.Forms.Button();
            this.PhysMemUsageByProc_ProgBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PhysMemUsageProgBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.AvPhysMemProgBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.VirtMemUsageProgBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.AvVirtMemProgBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProcessVirtMemUsageLabel);
            this.groupBox1.Controls.Add(this.ProcessPhysMemUsageLabel);
            this.groupBox1.Controls.Add(this.ProcessVirtualMemLabel);
            this.groupBox1.Controls.Add(this.ProcessWorkingSetLabel);
            this.groupBox1.Controls.Add(this.ProcessPrivateMemLabel);
            this.groupBox1.Controls.Add(this.ProcessIdLabel);
            this.groupBox1.Controls.Add(this.ProcessNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process";
            // 
            // ProcessVirtMemUsageLabel
            // 
            this.ProcessVirtMemUsageLabel.AutoSize = true;
            this.ProcessVirtMemUsageLabel.Location = new System.Drawing.Point(7, 148);
            this.ProcessVirtMemUsageLabel.Name = "ProcessVirtMemUsageLabel";
            this.ProcessVirtMemUsageLabel.Size = new System.Drawing.Size(153, 17);
            this.ProcessVirtMemUsageLabel.TabIndex = 6;
            this.ProcessVirtMemUsageLabel.Text = "Virtual memory usage :";
            // 
            // ProcessPhysMemUsageLabel
            // 
            this.ProcessPhysMemUsageLabel.AutoSize = true;
            this.ProcessPhysMemUsageLabel.Location = new System.Drawing.Point(7, 127);
            this.ProcessPhysMemUsageLabel.Name = "ProcessPhysMemUsageLabel";
            this.ProcessPhysMemUsageLabel.Size = new System.Drawing.Size(165, 17);
            this.ProcessPhysMemUsageLabel.TabIndex = 5;
            this.ProcessPhysMemUsageLabel.Text = "Physical memory usage :";
            // 
            // ProcessVirtualMemLabel
            // 
            this.ProcessVirtualMemLabel.AutoSize = true;
            this.ProcessVirtualMemLabel.Location = new System.Drawing.Point(7, 106);
            this.ProcessVirtualMemLabel.Name = "ProcessVirtualMemLabel";
            this.ProcessVirtualMemLabel.Size = new System.Drawing.Size(114, 17);
            this.ProcessVirtualMemLabel.TabIndex = 4;
            this.ProcessVirtualMemLabel.Text = "Virtual memory : ";
            // 
            // ProcessWorkingSetLabel
            // 
            this.ProcessWorkingSetLabel.AutoSize = true;
            this.ProcessWorkingSetLabel.Location = new System.Drawing.Point(7, 85);
            this.ProcessWorkingSetLabel.Name = "ProcessWorkingSetLabel";
            this.ProcessWorkingSetLabel.Size = new System.Drawing.Size(93, 17);
            this.ProcessWorkingSetLabel.TabIndex = 3;
            this.ProcessWorkingSetLabel.Text = "WorkingSet : ";
            // 
            // ProcessPrivateMemLabel
            // 
            this.ProcessPrivateMemLabel.AutoSize = true;
            this.ProcessPrivateMemLabel.Location = new System.Drawing.Point(7, 64);
            this.ProcessPrivateMemLabel.Name = "ProcessPrivateMemLabel";
            this.ProcessPrivateMemLabel.Size = new System.Drawing.Size(118, 17);
            this.ProcessPrivateMemLabel.TabIndex = 2;
            this.ProcessPrivateMemLabel.Text = "Private memory : ";
            // 
            // ProcessIdLabel
            // 
            this.ProcessIdLabel.AutoSize = true;
            this.ProcessIdLabel.Location = new System.Drawing.Point(7, 43);
            this.ProcessIdLabel.Name = "ProcessIdLabel";
            this.ProcessIdLabel.Size = new System.Drawing.Size(27, 17);
            this.ProcessIdLabel.TabIndex = 1;
            this.ProcessIdLabel.Text = "Id :";
            // 
            // ProcessNameLabel
            // 
            this.ProcessNameLabel.AutoSize = true;
            this.ProcessNameLabel.Location = new System.Drawing.Point(7, 22);
            this.ProcessNameLabel.Name = "ProcessNameLabel";
            this.ProcessNameLabel.Size = new System.Drawing.Size(106, 17);
            this.ProcessNameLabel.TabIndex = 0;
            this.ProcessNameLabel.Text = "Process name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VirtMemUsage);
            this.groupBox2.Controls.Add(this.PhysMemUsage);
            this.groupBox2.Controls.Add(this.TotVirtMem);
            this.groupBox2.Controls.Add(this.AvVirtMem);
            this.groupBox2.Controls.Add(this.TotPhysMem);
            this.groupBox2.Controls.Add(this.AvPhysMem);
            this.groupBox2.Controls.Add(this.IPAddress);
            this.groupBox2.Controls.Add(this.MachineName);
            this.groupBox2.Location = new System.Drawing.Point(505, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computer";
            // 
            // VirtMemUsage
            // 
            this.VirtMemUsage.AutoSize = true;
            this.VirtMemUsage.Location = new System.Drawing.Point(7, 169);
            this.VirtMemUsage.Name = "VirtMemUsage";
            this.VirtMemUsage.Size = new System.Drawing.Size(153, 17);
            this.VirtMemUsage.TabIndex = 7;
            this.VirtMemUsage.Text = "Virtual memory usage :";
            // 
            // PhysMemUsage
            // 
            this.PhysMemUsage.AutoSize = true;
            this.PhysMemUsage.Location = new System.Drawing.Point(7, 148);
            this.PhysMemUsage.Name = "PhysMemUsage";
            this.PhysMemUsage.Size = new System.Drawing.Size(165, 17);
            this.PhysMemUsage.TabIndex = 6;
            this.PhysMemUsage.Text = "Physical memory usage :";
            // 
            // TotVirtMem
            // 
            this.TotVirtMem.AutoSize = true;
            this.TotVirtMem.Location = new System.Drawing.Point(7, 126);
            this.TotVirtMem.Name = "TotVirtMem";
            this.TotVirtMem.Size = new System.Drawing.Size(136, 17);
            this.TotVirtMem.TabIndex = 5;
            this.TotVirtMem.Text = "Total virtual memory";
            // 
            // AvVirtMem
            // 
            this.AvVirtMem.AutoSize = true;
            this.AvVirtMem.Location = new System.Drawing.Point(7, 105);
            this.AvVirtMem.Name = "AvVirtMem";
            this.AvVirtMem.Size = new System.Drawing.Size(169, 17);
            this.AvVirtMem.TabIndex = 4;
            this.AvVirtMem.Text = "Available virtual memory :";
            // 
            // TotPhysMem
            // 
            this.TotPhysMem.AutoSize = true;
            this.TotPhysMem.Location = new System.Drawing.Point(7, 84);
            this.TotPhysMem.Name = "TotPhysMem";
            this.TotPhysMem.Size = new System.Drawing.Size(157, 17);
            this.TotPhysMem.TabIndex = 3;
            this.TotPhysMem.Text = "Total physical memory :";
            // 
            // AvPhysMem
            // 
            this.AvPhysMem.AutoSize = true;
            this.AvPhysMem.Location = new System.Drawing.Point(7, 63);
            this.AvPhysMem.Name = "AvPhysMem";
            this.AvPhysMem.Size = new System.Drawing.Size(182, 17);
            this.AvPhysMem.TabIndex = 2;
            this.AvPhysMem.Text = "Available physical memory :";
            // 
            // IPAddress
            // 
            this.IPAddress.AutoSize = true;
            this.IPAddress.Location = new System.Drawing.Point(7, 42);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(109, 17);
            this.IPAddress.TabIndex = 1;
            this.IPAddress.Text = "Address (IPv6) :";
            // 
            // MachineName
            // 
            this.MachineName.AutoSize = true;
            this.MachineName.Location = new System.Drawing.Point(7, 21);
            this.MachineName.Name = "MachineName";
            this.MachineName.Size = new System.Drawing.Size(108, 17);
            this.MachineName.TabIndex = 0;
            this.MachineName.Text = "Machine name :";
            // 
            // ProcessNameHelpIndicatorLabel
            // 
            this.ProcessNameHelpIndicatorLabel.AutoSize = true;
            this.ProcessNameHelpIndicatorLabel.Location = new System.Drawing.Point(12, 465);
            this.ProcessNameHelpIndicatorLabel.Name = "ProcessNameHelpIndicatorLabel";
            this.ProcessNameHelpIndicatorLabel.Size = new System.Drawing.Size(310, 34);
            this.ProcessNameHelpIndicatorLabel.TabIndex = 2;
            this.ProcessNameHelpIndicatorLabel.Text = "Process name (type \'self\' to track this process) :\r\n\r\n";
            // 
            // ProcessNameTextBox
            // 
            this.ProcessNameTextBox.Location = new System.Drawing.Point(327, 462);
            this.ProcessNameTextBox.Name = "ProcessNameTextBox";
            this.ProcessNameTextBox.Size = new System.Drawing.Size(354, 22);
            this.ProcessNameTextBox.TabIndex = 3;
            // 
            // TrackingButton
            // 
            this.TrackingButton.Location = new System.Drawing.Point(687, 461);
            this.TrackingButton.Name = "TrackingButton";
            this.TrackingButton.Size = new System.Drawing.Size(75, 24);
            this.TrackingButton.TabIndex = 4;
            this.TrackingButton.Text = "Track";
            this.TrackingButton.UseVisualStyleBackColor = true;
            this.TrackingButton.Click += new System.EventHandler(this.TrackingButton_Click);
            // 
            // PhysMemUsageByProc_ProgBar
            // 
            this.PhysMemUsageByProc_ProgBar.Location = new System.Drawing.Point(13, 249);
            this.PhysMemUsageByProc_ProgBar.Name = "PhysMemUsageByProc_ProgBar";
            this.PhysMemUsageByProc_ProgBar.Size = new System.Drawing.Size(283, 23);
            this.PhysMemUsageByProc_ProgBar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Physical memory usage by this process (view) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Physical memory usage by all processes (view) :";
            // 
            // PhysMemUsageProgBar
            // 
            this.PhysMemUsageProgBar.Location = new System.Drawing.Point(515, 238);
            this.PhysMemUsageProgBar.Name = "PhysMemUsageProgBar";
            this.PhysMemUsageProgBar.Size = new System.Drawing.Size(283, 23);
            this.PhysMemUsageProgBar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Available physical memory (view) :";
            // 
            // AvPhysMemProgBar
            // 
            this.AvPhysMemProgBar.Location = new System.Drawing.Point(515, 284);
            this.AvPhysMemProgBar.Name = "AvPhysMemProgBar";
            this.AvPhysMemProgBar.Size = new System.Drawing.Size(283, 23);
            this.AvPhysMemProgBar.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Virtual memory usage by all processes (view) :";
            // 
            // VirtMemUsageProgBar
            // 
            this.VirtMemUsageProgBar.Location = new System.Drawing.Point(515, 330);
            this.VirtMemUsageProgBar.Name = "VirtMemUsageProgBar";
            this.VirtMemUsageProgBar.Size = new System.Drawing.Size(283, 23);
            this.VirtMemUsageProgBar.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Available virtual memory (view) :";
            // 
            // AvVirtMemProgBar
            // 
            this.AvVirtMemProgBar.Location = new System.Drawing.Point(515, 380);
            this.AvVirtMemProgBar.Name = "AvVirtMemProgBar";
            this.AvVirtMemProgBar.Size = new System.Drawing.Size(283, 23);
            this.AvVirtMemProgBar.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 508);
            this.Controls.Add(this.AvVirtMemProgBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VirtMemUsageProgBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AvPhysMemProgBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhysMemUsageProgBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhysMemUsageByProc_ProgBar);
            this.Controls.Add(this.TrackingButton);
            this.Controls.Add(this.ProcessNameTextBox);
            this.Controls.Add(this.ProcessNameHelpIndicatorLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MemoryManager (GUI)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ProcessIdLabel;
        private System.Windows.Forms.Label ProcessNameLabel;
        private System.Windows.Forms.Label ProcessPrivateMemLabel;
        private System.Windows.Forms.Label ProcessVirtualMemLabel;
        private System.Windows.Forms.Label ProcessWorkingSetLabel;
        private System.Windows.Forms.Label ProcessPhysMemUsageLabel;
        private System.Windows.Forms.Label ProcessVirtMemUsageLabel;
        private System.Windows.Forms.Label ProcessNameHelpIndicatorLabel;
        private System.Windows.Forms.TextBox ProcessNameTextBox;
        private System.Windows.Forms.Button TrackingButton;
        private System.Windows.Forms.ProgressBar PhysMemUsageByProc_ProgBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MachineName;
        private System.Windows.Forms.Label IPAddress;
        private System.Windows.Forms.Label AvPhysMem;
        private System.Windows.Forms.Label TotPhysMem;
        private System.Windows.Forms.Label TotVirtMem;
        private System.Windows.Forms.Label AvVirtMem;
        private System.Windows.Forms.Label VirtMemUsage;
        private System.Windows.Forms.Label PhysMemUsage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PhysMemUsageProgBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar AvPhysMemProgBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar VirtMemUsageProgBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar AvVirtMemProgBar;
    }
}


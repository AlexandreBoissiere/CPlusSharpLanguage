namespace VisualTextCompiler
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
            this.InputCodeText = new System.Windows.Forms.TextBox();
            this.PreCompiledText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FontBox = new System.Windows.Forms.ComboBox();
            this.CompileAllButton = new System.Windows.Forms.Button();
            this.CompileButton = new System.Windows.Forms.Button();
            this.PrecompileButton = new System.Windows.Forms.Button();
            this.SavingButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputCodeText
            // 
            this.InputCodeText.AcceptsReturn = true;
            this.InputCodeText.AcceptsTab = true;
            this.InputCodeText.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCodeText.Location = new System.Drawing.Point(26, 49);
            this.InputCodeText.Margin = new System.Windows.Forms.Padding(4);
            this.InputCodeText.Multiline = true;
            this.InputCodeText.Name = "InputCodeText";
            this.InputCodeText.Size = new System.Drawing.Size(1183, 309);
            this.InputCodeText.TabIndex = 0;
            // 
            // PreCompiledText
            // 
            this.PreCompiledText.Location = new System.Drawing.Point(26, 396);
            this.PreCompiledText.Margin = new System.Windows.Forms.Padding(4);
            this.PreCompiledText.Multiline = true;
            this.PreCompiledText.Name = "PreCompiledText";
            this.PreCompiledText.ReadOnly = true;
            this.PreCompiledText.Size = new System.Drawing.Size(1183, 75);
            this.PreCompiledText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your C+# code : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "(PreCompiled) C# code : ";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(26, 509);
            this.Status.Margin = new System.Windows.Forms.Padding(4);
            this.Status.Multiline = true;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Size = new System.Drawing.Size(1183, 67);
            this.Status.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 487);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status :  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Controls.Add(this.SavingButton);
            this.groupBox1.Controls.Add(this.FontBox);
            this.groupBox1.Controls.Add(this.CompileAllButton);
            this.groupBox1.Controls.Add(this.CompileButton);
            this.groupBox1.Controls.Add(this.PrecompileButton);
            this.groupBox1.Location = new System.Drawing.Point(1234, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 221);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // FontBox
            // 
            this.FontBox.FormattingEnabled = true;
            this.FontBox.Items.AddRange(new object[] {
            "Arial",
            "Microsoft Sans Serif"});
            this.FontBox.Location = new System.Drawing.Point(6, 121);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(205, 26);
            this.FontBox.TabIndex = 7;
            this.FontBox.Text = "Font (Default : Arial)";
            // 
            // CompileAllButton
            // 
            this.CompileAllButton.Location = new System.Drawing.Point(5, 88);
            this.CompileAllButton.Name = "CompileAllButton";
            this.CompileAllButton.Size = new System.Drawing.Size(205, 27);
            this.CompileAllButton.TabIndex = 2;
            this.CompileAllButton.Text = "Compile all";
            this.CompileAllButton.UseVisualStyleBackColor = true;
            this.CompileAllButton.Click += new System.EventHandler(this.CompileAllButton_Click);
            // 
            // CompileButton
            // 
            this.CompileButton.Location = new System.Drawing.Point(5, 55);
            this.CompileButton.Name = "CompileButton";
            this.CompileButton.Size = new System.Drawing.Size(205, 27);
            this.CompileButton.TabIndex = 1;
            this.CompileButton.Text = "Compile C# Code";
            this.CompileButton.UseVisualStyleBackColor = true;
            this.CompileButton.Click += new System.EventHandler(this.CompileButton_Click);
            // 
            // PrecompileButton
            // 
            this.PrecompileButton.Location = new System.Drawing.Point(5, 22);
            this.PrecompileButton.Name = "PrecompileButton";
            this.PrecompileButton.Size = new System.Drawing.Size(205, 27);
            this.PrecompileButton.TabIndex = 0;
            this.PrecompileButton.Text = "Precompile C+# code";
            this.PrecompileButton.UseVisualStyleBackColor = true;
            this.PrecompileButton.Click += new System.EventHandler(this.PrecompileButton_click);
            // 
            // SavingButton
            // 
            this.SavingButton.Location = new System.Drawing.Point(5, 154);
            this.SavingButton.Name = "SavingButton";
            this.SavingButton.Size = new System.Drawing.Size(205, 27);
            this.SavingButton.TabIndex = 8;
            this.SavingButton.Text = "Save";
            this.SavingButton.UseVisualStyleBackColor = true;
            this.SavingButton.Click += new System.EventHandler(this.SavingButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(5, 187);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(205, 27);
            this.openButton.TabIndex = 9;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PreCompiledText);
            this.Controls.Add(this.InputCodeText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "VisualTextCompiler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputCodeText;
        private System.Windows.Forms.TextBox PreCompiledText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CompileAllButton;
        private System.Windows.Forms.Button CompileButton;
        private System.Windows.Forms.Button PrecompileButton;
        private System.Windows.Forms.ComboBox FontBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button SavingButton;
    }
}


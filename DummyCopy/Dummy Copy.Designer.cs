namespace DummyCopy {
    partial class CopyDummy {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyDummy));
            this.textBoxSourceDummy = new System.Windows.Forms.TextBox();
            this.textBoxEndValue = new System.Windows.Forms.TextBox();
            this.textBoxStartValue = new System.Windows.Forms.TextBox();
            this.textBoxDestinationFolder = new System.Windows.Forms.TextBox();
            this.labelEndValue = new System.Windows.Forms.Label();
            this.labelStartValue = new System.Windows.Forms.Label();
            this.buttonDestFolder = new System.Windows.Forms.Button();
            this.buttonSourceDummy = new System.Windows.Forms.Button();
            this.buttonCreateDummys = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxDummyName = new System.Windows.Forms.TextBox();
            this.labelDummyName = new System.Windows.Forms.Label();
            this.labelExtension = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSourceDummy
            // 
            this.textBoxSourceDummy.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSourceDummy.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxSourceDummy.Location = new System.Drawing.Point(12, 33);
            this.textBoxSourceDummy.Name = "textBoxSourceDummy";
            this.textBoxSourceDummy.Size = new System.Drawing.Size(356, 20);
            this.textBoxSourceDummy.TabIndex = 0;
            // 
            // textBoxEndValue
            // 
            this.textBoxEndValue.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxEndValue.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxEndValue.Location = new System.Drawing.Point(597, 12);
            this.textBoxEndValue.MaxLength = 3;
            this.textBoxEndValue.Name = "textBoxEndValue";
            this.textBoxEndValue.Size = new System.Drawing.Size(35, 20);
            this.textBoxEndValue.TabIndex = 1;
            this.textBoxEndValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStartValue
            // 
            this.textBoxStartValue.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxStartValue.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxStartValue.Location = new System.Drawing.Point(481, 12);
            this.textBoxStartValue.MaxLength = 3;
            this.textBoxStartValue.Name = "textBoxStartValue";
            this.textBoxStartValue.Size = new System.Drawing.Size(35, 20);
            this.textBoxStartValue.TabIndex = 2;
            this.textBoxStartValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDestinationFolder
            // 
            this.textBoxDestinationFolder.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDestinationFolder.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxDestinationFolder.Location = new System.Drawing.Point(12, 60);
            this.textBoxDestinationFolder.Name = "textBoxDestinationFolder";
            this.textBoxDestinationFolder.Size = new System.Drawing.Size(356, 20);
            this.textBoxDestinationFolder.TabIndex = 3;
            // 
            // labelEndValue
            // 
            this.labelEndValue.AutoSize = true;
            this.labelEndValue.Location = new System.Drawing.Point(638, 15);
            this.labelEndValue.Name = "labelEndValue";
            this.labelEndValue.Size = new System.Drawing.Size(56, 13);
            this.labelEndValue.TabIndex = 4;
            this.labelEndValue.Text = "End Value";
            // 
            // labelStartValue
            // 
            this.labelStartValue.AutoSize = true;
            this.labelStartValue.Location = new System.Drawing.Point(522, 15);
            this.labelStartValue.Name = "labelStartValue";
            this.labelStartValue.Size = new System.Drawing.Size(59, 13);
            this.labelStartValue.TabIndex = 5;
            this.labelStartValue.Text = "Start Value";
            // 
            // buttonDestFolder
            // 
            this.buttonDestFolder.Location = new System.Drawing.Point(374, 58);
            this.buttonDestFolder.Name = "buttonDestFolder";
            this.buttonDestFolder.Size = new System.Drawing.Size(101, 23);
            this.buttonDestFolder.TabIndex = 6;
            this.buttonDestFolder.Text = "Destination Folder";
            this.buttonDestFolder.UseVisualStyleBackColor = true;
            this.buttonDestFolder.Click += new System.EventHandler(this.ButtonDestFolder_Click);
            // 
            // buttonSourceDummy
            // 
            this.buttonSourceDummy.Location = new System.Drawing.Point(374, 31);
            this.buttonSourceDummy.Name = "buttonSourceDummy";
            this.buttonSourceDummy.Size = new System.Drawing.Size(101, 23);
            this.buttonSourceDummy.TabIndex = 7;
            this.buttonSourceDummy.Text = "Source Dummy";
            this.buttonSourceDummy.UseVisualStyleBackColor = true;
            this.buttonSourceDummy.Click += new System.EventHandler(this.ButtonSourceDummy_Click);
            // 
            // buttonCreateDummys
            // 
            this.buttonCreateDummys.Location = new System.Drawing.Point(481, 39);
            this.buttonCreateDummys.Name = "buttonCreateDummys";
            this.buttonCreateDummys.Size = new System.Drawing.Size(207, 36);
            this.buttonCreateDummys.TabIndex = 8;
            this.buttonCreateDummys.Text = "Create Army of Dummys";
            this.buttonCreateDummys.UseVisualStyleBackColor = true;
            this.buttonCreateDummys.Click += new System.EventHandler(this.ButtonCreateDummys_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "dummy";
            this.openFileDialog.Filter = "All Files (*.*)|*.*";
            // 
            // textBoxDummyName
            // 
            this.textBoxDummyName.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDummyName.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxDummyName.Location = new System.Drawing.Point(12, 7);
            this.textBoxDummyName.Name = "textBoxDummyName";
            this.textBoxDummyName.Size = new System.Drawing.Size(104, 20);
            this.textBoxDummyName.TabIndex = 9;
            // 
            // labelDummyName
            // 
            this.labelDummyName.AutoSize = true;
            this.labelDummyName.Location = new System.Drawing.Point(122, 10);
            this.labelDummyName.Name = "labelDummyName";
            this.labelDummyName.Size = new System.Drawing.Size(73, 13);
            this.labelDummyName.TabIndex = 10;
            this.labelDummyName.Text = "Dummy Name";
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(265, 10);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(53, 13);
            this.labelExtension.TabIndex = 11;
            this.labelExtension.Text = "Extension";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxExtension.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxExtension.Location = new System.Drawing.Point(215, 7);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(44, 20);
            this.textBoxExtension.TabIndex = 12;
            // 
            // CopyDummy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 87);
            this.Controls.Add(this.textBoxExtension);
            this.Controls.Add(this.labelExtension);
            this.Controls.Add(this.labelDummyName);
            this.Controls.Add(this.textBoxDummyName);
            this.Controls.Add(this.buttonCreateDummys);
            this.Controls.Add(this.buttonSourceDummy);
            this.Controls.Add(this.buttonDestFolder);
            this.Controls.Add(this.labelStartValue);
            this.Controls.Add(this.labelEndValue);
            this.Controls.Add(this.textBoxDestinationFolder);
            this.Controls.Add(this.textBoxStartValue);
            this.Controls.Add(this.textBoxEndValue);
            this.Controls.Add(this.textBoxSourceDummy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CopyDummy";
            this.Text = "Dummy Copy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSourceDummy;
        private System.Windows.Forms.TextBox textBoxEndValue;
        private System.Windows.Forms.TextBox textBoxStartValue;
        private System.Windows.Forms.TextBox textBoxDestinationFolder;
        private System.Windows.Forms.Label labelEndValue;
        private System.Windows.Forms.Label labelStartValue;
        private System.Windows.Forms.Button buttonDestFolder;
        private System.Windows.Forms.Button buttonSourceDummy;
        private System.Windows.Forms.Button buttonCreateDummys;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxDummyName;
        private System.Windows.Forms.Label labelDummyName;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.TextBox textBoxExtension;
    }
}


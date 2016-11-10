namespace imagemagic
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbFilter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImageSelect = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbGRB = new System.Windows.Forms.RadioButton();
            this.rbGrayScale = new System.Windows.Forms.RadioButton();
            this.rbChannel = new System.Windows.Forms.RadioButton();
            this.rbMultiplyAndClamp = new System.Windows.Forms.RadioButton();
            this.rbQuantiz = new System.Windows.Forms.RadioButton();
            this.rbInvert = new System.Windows.Forms.RadioButton();
            this.rbThreshold = new System.Windows.Forms.RadioButton();
            this.rbClamp = new System.Windows.Forms.RadioButton();
            this.lbAuthors = new System.Windows.Forms.Label();
            this.lbLink = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).BeginInit();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbOriginal
            // 
            this.pbOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOriginal.Location = new System.Drawing.Point(12, 218);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(300, 301);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 0;
            this.pbOriginal.TabStop = false;
            // 
            // pbFilter
            // 
            this.pbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFilter.Location = new System.Drawing.Point(318, 218);
            this.pbFilter.Name = "pbFilter";
            this.pbFilter.Size = new System.Drawing.Size(300, 301);
            this.pbFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilter.TabIndex = 1;
            this.pbFilter.TabStop = false;
            this.pbFilter.Click += new System.EventHandler(this.pbFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtered:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnImageSelect
            // 
            this.btnImageSelect.Location = new System.Drawing.Point(461, 12);
            this.btnImageSelect.Name = "btnImageSelect";
            this.btnImageSelect.Size = new System.Drawing.Size(157, 23);
            this.btnImageSelect.TabIndex = 4;
            this.btnImageSelect.Text = "Bild auswählen";
            this.btnImageSelect.UseVisualStyleBackColor = true;
            this.btnImageSelect.Click += new System.EventHandler(this.btnImageSelect_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Enabled = false;
            this.txtImagePath.Location = new System.Drawing.Point(12, 14);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(443, 20);
            this.txtImagePath.TabIndex = 5;
            this.txtImagePath.Text = "...";
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.dateTimePicker1);
            this.gbFilters.Controls.Add(this.rbGRB);
            this.gbFilters.Controls.Add(this.rbGrayScale);
            this.gbFilters.Controls.Add(this.rbChannel);
            this.gbFilters.Controls.Add(this.rbMultiplyAndClamp);
            this.gbFilters.Controls.Add(this.rbQuantiz);
            this.gbFilters.Controls.Add(this.rbInvert);
            this.gbFilters.Controls.Add(this.rbThreshold);
            this.gbFilters.Controls.Add(this.rbClamp);
            this.gbFilters.Enabled = false;
            this.gbFilters.Location = new System.Drawing.Point(12, 43);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(606, 146);
            this.gbFilters.TabIndex = 6;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            this.gbFilters.Enter += new System.EventHandler(this.gbFilters_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(390, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // rbGRB
            // 
            this.rbGRB.AutoSize = true;
            this.rbGRB.Location = new System.Drawing.Point(127, 66);
            this.rbGRB.Name = "rbGRB";
            this.rbGRB.Size = new System.Drawing.Size(40, 17);
            this.rbGRB.TabIndex = 7;
            this.rbGRB.TabStop = true;
            this.rbGRB.Text = "grb";
            this.rbGRB.UseVisualStyleBackColor = true;
            this.rbGRB.CheckedChanged += new System.EventHandler(this.rbGRB_CheckedChanged);
            // 
            // rbGrayScale
            // 
            this.rbGrayScale.AutoSize = true;
            this.rbGrayScale.Location = new System.Drawing.Point(127, 42);
            this.rbGrayScale.Name = "rbGrayScale";
            this.rbGrayScale.Size = new System.Drawing.Size(70, 17);
            this.rbGrayScale.TabIndex = 6;
            this.rbGrayScale.TabStop = true;
            this.rbGrayScale.Text = "grayscale";
            this.rbGrayScale.UseVisualStyleBackColor = true;
            this.rbGrayScale.CheckedChanged += new System.EventHandler(this.rbGrayScale_CheckedChanged);
            // 
            // rbChannel
            // 
            this.rbChannel.AutoSize = true;
            this.rbChannel.Location = new System.Drawing.Point(127, 19);
            this.rbChannel.Name = "rbChannel";
            this.rbChannel.Size = new System.Drawing.Size(63, 17);
            this.rbChannel.TabIndex = 5;
            this.rbChannel.TabStop = true;
            this.rbChannel.Text = "channel";
            this.rbChannel.UseVisualStyleBackColor = true;
            this.rbChannel.CheckedChanged += new System.EventHandler(this.rbChannel_CheckedChanged);
            // 
            // rbMultiplyAndClamp
            // 
            this.rbMultiplyAndClamp.AutoSize = true;
            this.rbMultiplyAndClamp.Location = new System.Drawing.Point(6, 113);
            this.rbMultiplyAndClamp.Name = "rbMultiplyAndClamp";
            this.rbMultiplyAndClamp.Size = new System.Drawing.Size(105, 17);
            this.rbMultiplyAndClamp.TabIndex = 4;
            this.rbMultiplyAndClamp.TabStop = true;
            this.rbMultiplyAndClamp.Text = "multiplyandclamp";
            this.rbMultiplyAndClamp.UseVisualStyleBackColor = true;
            this.rbMultiplyAndClamp.CheckedChanged += new System.EventHandler(this.rbMultiplyAndClamp_CheckedChanged);
            // 
            // rbQuantiz
            // 
            this.rbQuantiz.AutoSize = true;
            this.rbQuantiz.Location = new System.Drawing.Point(6, 89);
            this.rbQuantiz.Name = "rbQuantiz";
            this.rbQuantiz.Size = new System.Drawing.Size(59, 17);
            this.rbQuantiz.TabIndex = 3;
            this.rbQuantiz.TabStop = true;
            this.rbQuantiz.Text = "quantiz";
            this.rbQuantiz.UseVisualStyleBackColor = true;
            this.rbQuantiz.CheckedChanged += new System.EventHandler(this.rbQuantiz_CheckedChanged);
            // 
            // rbInvert
            // 
            this.rbInvert.AutoSize = true;
            this.rbInvert.Location = new System.Drawing.Point(6, 65);
            this.rbInvert.Name = "rbInvert";
            this.rbInvert.Size = new System.Drawing.Size(51, 17);
            this.rbInvert.TabIndex = 2;
            this.rbInvert.TabStop = true;
            this.rbInvert.Text = "invert";
            this.rbInvert.UseVisualStyleBackColor = true;
            this.rbInvert.CheckedChanged += new System.EventHandler(this.rbInvert_CheckedChanged);
            // 
            // rbThreshold
            // 
            this.rbThreshold.AutoSize = true;
            this.rbThreshold.Location = new System.Drawing.Point(6, 42);
            this.rbThreshold.Name = "rbThreshold";
            this.rbThreshold.Size = new System.Drawing.Size(68, 17);
            this.rbThreshold.TabIndex = 1;
            this.rbThreshold.TabStop = true;
            this.rbThreshold.Text = "threshold";
            this.rbThreshold.UseVisualStyleBackColor = true;
            this.rbThreshold.CheckedChanged += new System.EventHandler(this.rbThreshold_CheckedChanged);
            // 
            // rbClamp
            // 
            this.rbClamp.AutoSize = true;
            this.rbClamp.Location = new System.Drawing.Point(6, 19);
            this.rbClamp.Name = "rbClamp";
            this.rbClamp.Size = new System.Drawing.Size(53, 17);
            this.rbClamp.TabIndex = 0;
            this.rbClamp.TabStop = true;
            this.rbClamp.Text = "clamp";
            this.rbClamp.UseVisualStyleBackColor = true;
            this.rbClamp.CheckedChanged += new System.EventHandler(this.rbClamp_CheckedChanged);
            // 
            // lbAuthors
            // 
            this.lbAuthors.AutoSize = true;
            this.lbAuthors.Location = new System.Drawing.Point(9, 527);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(303, 13);
            this.lbAuthors.TabIndex = 7;
            this.lbAuthors.Text = "ImageMagic 0.1v. | Thomas Siller und Patrick Obermüller. 2016";
            this.lbAuthors.Click += new System.EventHandler(this.lbAuthors_Click);
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.Location = new System.Drawing.Point(470, 527);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(148, 13);
            this.lbLink.TabIndex = 9;
            this.lbLink.TabStop = true;
            this.lbLink.Text = "http://www.fh-salzburg.ac.at/";
            this.lbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLink_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 551);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.lbAuthors);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.btnImageSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFilter);
            this.Controls.Add(this.pbOriginal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ImageMagic";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).EndInit();
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImageSelect;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.RadioButton rbThreshold;
        private System.Windows.Forms.RadioButton rbClamp;
        private System.Windows.Forms.RadioButton rbInvert;
        private System.Windows.Forms.RadioButton rbQuantiz;
        private System.Windows.Forms.RadioButton rbMultiplyAndClamp;
        private System.Windows.Forms.RadioButton rbChannel;
        private System.Windows.Forms.RadioButton rbGrayScale;
        private System.Windows.Forms.RadioButton rbGRB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbAuthors;
        private System.Windows.Forms.LinkLabel lbLink;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer progressTimer;
    }
}


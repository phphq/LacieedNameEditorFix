namespace LacieedNameEditorFix.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblDf1 = new System.Windows.Forms.Label();
            this.lblDf2 = new System.Windows.Forms.Label();
            this.btndf1 = new System.Windows.Forms.Button();
            this.btndf2 = new System.Windows.Forms.Button();
            this.tbdf1 = new System.Windows.Forms.TextBox();
            this.tbdf2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbNovaHQ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNovaHQ)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDf1
            // 
            this.lblDf1.AutoSize = true;
            this.lblDf1.Location = new System.Drawing.Point(7, 38);
            this.lblDf1.Name = "lblDf1";
            this.lblDf1.Size = new System.Drawing.Size(52, 13);
            this.lblDf1.TabIndex = 0;
            this.lblDf1.Text = "DF1 Path";
            // 
            // lblDf2
            // 
            this.lblDf2.AutoSize = true;
            this.lblDf2.Location = new System.Drawing.Point(7, 70);
            this.lblDf2.Name = "lblDf2";
            this.lblDf2.Size = new System.Drawing.Size(52, 13);
            this.lblDf2.TabIndex = 1;
            this.lblDf2.Text = "DF2 Path";
            // 
            // btndf1
            // 
            this.btndf1.Location = new System.Drawing.Point(332, 32);
            this.btndf1.Name = "btndf1";
            this.btndf1.Size = new System.Drawing.Size(65, 23);
            this.btndf1.TabIndex = 2;
            this.btndf1.Text = "Browse...";
            this.btndf1.UseVisualStyleBackColor = true;
            this.btndf1.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btndf2
            // 
            this.btndf2.Location = new System.Drawing.Point(332, 64);
            this.btndf2.Name = "btndf2";
            this.btndf2.Size = new System.Drawing.Size(65, 23);
            this.btndf2.TabIndex = 3;
            this.btndf2.Text = "Browse...";
            this.btndf2.UseVisualStyleBackColor = true;
            this.btndf2.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbdf1
            // 
            this.tbdf1.Location = new System.Drawing.Point(65, 35);
            this.tbdf1.Name = "tbdf1";
            this.tbdf1.Size = new System.Drawing.Size(261, 20);
            this.tbdf1.TabIndex = 4;
            // 
            // tbdf2
            // 
            this.tbdf2.Location = new System.Drawing.Point(65, 67);
            this.tbdf2.Name = "tbdf2";
            this.tbdf2.Size = new System.Drawing.Size(261, 20);
            this.tbdf2.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(261, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseMnemonic = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(332, 105);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(7, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(390, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "This program fixes the registry so the lacieed name editor can find your game fil" +
    "es.";
            // 
            // pbNovaHQ
            // 
            this.pbNovaHQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNovaHQ.Location = new System.Drawing.Point(9, 105);
            this.pbNovaHQ.Name = "pbNovaHQ";
            this.pbNovaHQ.Size = new System.Drawing.Size(100, 25);
            this.pbNovaHQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNovaHQ.TabIndex = 9;
            this.pbNovaHQ.TabStop = false;
            this.pbNovaHQ.Tag = "";
            this.pbNovaHQ.Click += new System.EventHandler(this.pbNovaHQ_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 137);
            this.Controls.Add(this.pbNovaHQ);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbdf2);
            this.Controls.Add(this.tbdf1);
            this.Controls.Add(this.btndf2);
            this.Controls.Add(this.btndf1);
            this.Controls.Add(this.lblDf2);
            this.Controls.Add(this.lblDf1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lacieed Name Editor Fix";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNovaHQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDf1;
        private System.Windows.Forms.Label lblDf2;
        private System.Windows.Forms.Button btndf1;
        private System.Windows.Forms.Button btndf2;
        private System.Windows.Forms.TextBox tbdf1;
        private System.Windows.Forms.TextBox tbdf2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pbNovaHQ;
    }
}


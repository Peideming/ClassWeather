namespace WindowsFormsApp3
{
    partial class days7Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(days7Form3));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblShow2 = new System.Windows.Forms.Panel();
            this.lblShow = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.lblShow2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(56, 27);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(193, 46);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CityName";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // lblShow2
            // 
            this.lblShow2.AutoScroll = true;
            this.lblShow2.Controls.Add(this.lblShow);
            this.lblShow2.Location = new System.Drawing.Point(12, 76);
            this.lblShow2.Name = "lblShow2";
            this.lblShow2.Size = new System.Drawing.Size(776, 362);
            this.lblShow2.TabIndex = 5;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.lblShow.Location = new System.Drawing.Point(46, 15);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(148, 31);
            this.lblShow.TabIndex = 6;
            this.lblShow.Text = "CityWeather";
            this.lblShow.Click += new System.EventHandler(this.days7Form3_Load);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(686, 27);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(85, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "语音播报";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.speekbutton_Click);
            // 
            // days7Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.lblShow2);
            this.Controls.Add(this.linkLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "days7Form3";
            this.Opacity = 0.8D;
            this.Text = "天气小组件";
            this.Load += new System.EventHandler(this.days7Form3_Load);
            this.lblShow2.ResumeLayout(false);
            this.lblShow2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel lblShow2;
        private System.Windows.Forms.Label lblShow;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}
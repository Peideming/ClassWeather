namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblShow = new System.Windows.Forms.Label();
            this.linkTittle = new System.Windows.Forms.LinkLabel();
            this.btnGetWeather2 = new MaterialSkin.Controls.MaterialButton();
            this.btSpeek = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShow.Location = new System.Drawing.Point(113, 140);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(464, 31);
            this.lblShow.TabIndex = 2;
            this.lblShow.Text = "实时天气请单击”天气获取“以获取实时天气";
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // linkTittle
            // 
            this.linkTittle.AutoSize = true;
            this.linkTittle.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkTittle.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkTittle.Location = new System.Drawing.Point(115, 87);
            this.linkTittle.Name = "linkTittle";
            this.linkTittle.Size = new System.Drawing.Size(160, 46);
            this.linkTittle.TabIndex = 3;
            this.linkTittle.TabStop = true;
            this.linkTittle.Text = "城市名称";
            this.linkTittle.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // btnGetWeather2
            // 
            this.btnGetWeather2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetWeather2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGetWeather2.Depth = 0;
            this.btnGetWeather2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetWeather2.HighEmphasis = true;
            this.btnGetWeather2.Icon = null;
            this.btnGetWeather2.Location = new System.Drawing.Point(644, 87);
            this.btnGetWeather2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGetWeather2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGetWeather2.Name = "btnGetWeather2";
            this.btnGetWeather2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGetWeather2.Size = new System.Drawing.Size(85, 36);
            this.btnGetWeather2.TabIndex = 4;
            this.btnGetWeather2.Text = "天气获取";
            this.btnGetWeather2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGetWeather2.UseAccentColor = false;
            this.btnGetWeather2.UseVisualStyleBackColor = true;
            this.btnGetWeather2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSpeek
            // 
            this.btSpeek.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSpeek.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btSpeek.Depth = 0;
            this.btSpeek.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSpeek.HighEmphasis = true;
            this.btSpeek.Icon = null;
            this.btSpeek.Location = new System.Drawing.Point(644, 135);
            this.btSpeek.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSpeek.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSpeek.Name = "btSpeek";
            this.btSpeek.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btSpeek.Size = new System.Drawing.Size(85, 36);
            this.btSpeek.TabIndex = 5;
            this.btSpeek.Text = "天气播报";
            this.btSpeek.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btSpeek.UseAccentColor = false;
            this.btSpeek.UseVisualStyleBackColor = true;
            this.btSpeek.Click += new System.EventHandler(this.speekbutton_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(644, 183);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(85, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "关于项目";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.OpenAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(833, 477);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btSpeek);
            this.Controls.Add(this.btnGetWeather2);
            this.Controls.Add(this.linkTittle);
            this.Controls.Add(this.lblShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.Text = "天气小组件";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.LinkLabel linkTittle;
        private MaterialSkin.Controls.MaterialButton btnGetWeather2;
        private MaterialSkin.Controls.MaterialButton btSpeek;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}


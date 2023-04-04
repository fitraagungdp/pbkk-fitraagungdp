namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_close = new System.Windows.Forms.Button();
            this.TbCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_Conditions = new System.Windows.Forms.Label();
            this.lab_Detail = new System.Windows.Forms.Label();
            this.Sunrise = new System.Windows.Forms.Label();
            this.Sunset = new System.Windows.Forms.Label();
            this.lab_Sunset = new System.Windows.Forms.Label();
            this.lab_Sunrise = new System.Windows.Forms.Label();
            this.WinSpeed = new System.Windows.Forms.Label();
            this.lab_Pressure = new System.Windows.Forms.Label();
            this.lab_WindSpeed = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.pic_Icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Snow;
            this.btn_close.Location = new System.Drawing.Point(724, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // TbCity
            // 
            this.TbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCity.Location = new System.Drawing.Point(139, 53);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(289, 31);
            this.TbCity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "City";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_search.Location = new System.Drawing.Point(460, 49);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 37);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lab_Conditions
            // 
            this.lab_Conditions.AutoSize = true;
            this.lab_Conditions.BackColor = System.Drawing.Color.Transparent;
            this.lab_Conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Conditions.Location = new System.Drawing.Point(50, 209);
            this.lab_Conditions.Name = "lab_Conditions";
            this.lab_Conditions.Size = new System.Drawing.Size(190, 33);
            this.lab_Conditions.TabIndex = 4;
            this.lab_Conditions.Text = "Conditions : ";
            // 
            // lab_Detail
            // 
            this.lab_Detail.AutoSize = true;
            this.lab_Detail.BackColor = System.Drawing.Color.Transparent;
            this.lab_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Detail.Location = new System.Drawing.Point(50, 265);
            this.lab_Detail.Name = "lab_Detail";
            this.lab_Detail.Size = new System.Drawing.Size(114, 33);
            this.lab_Detail.TabIndex = 5;
            this.lab_Detail.Text = "Detail :";
            // 
            // Sunrise
            // 
            this.Sunrise.AutoSize = true;
            this.Sunrise.BackColor = System.Drawing.Color.Transparent;
            this.Sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunrise.Location = new System.Drawing.Point(50, 320);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(139, 33);
            this.Sunrise.TabIndex = 6;
            this.Sunrise.Text = "Sunrise ;";
            // 
            // Sunset
            // 
            this.Sunset.AutoSize = true;
            this.Sunset.BackColor = System.Drawing.Color.Transparent;
            this.Sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sunset.Location = new System.Drawing.Point(50, 367);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(138, 33);
            this.Sunset.TabIndex = 7;
            this.Sunset.Text = "Sunset : ";
            // 
            // lab_Sunset
            // 
            this.lab_Sunset.AutoSize = true;
            this.lab_Sunset.BackColor = System.Drawing.Color.Transparent;
            this.lab_Sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Sunset.Location = new System.Drawing.Point(238, 367);
            this.lab_Sunset.Name = "lab_Sunset";
            this.lab_Sunset.Size = new System.Drawing.Size(88, 33);
            this.lab_Sunset.TabIndex = 8;
            this.lab_Sunset.Text = "None";
            // 
            // lab_Sunrise
            // 
            this.lab_Sunrise.AutoSize = true;
            this.lab_Sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lab_Sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Sunrise.Location = new System.Drawing.Point(238, 320);
            this.lab_Sunrise.Name = "lab_Sunrise";
            this.lab_Sunrise.Size = new System.Drawing.Size(88, 33);
            this.lab_Sunrise.TabIndex = 9;
            this.lab_Sunrise.Text = "None";
            // 
            // WinSpeed
            // 
            this.WinSpeed.AutoSize = true;
            this.WinSpeed.BackColor = System.Drawing.Color.Transparent;
            this.WinSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinSpeed.Location = new System.Drawing.Point(414, 209);
            this.WinSpeed.Name = "WinSpeed";
            this.WinSpeed.Size = new System.Drawing.Size(209, 33);
            this.WinSpeed.TabIndex = 10;
            this.WinSpeed.Text = "Wind Speed : ";
            // 
            // lab_Pressure
            // 
            this.lab_Pressure.AutoSize = true;
            this.lab_Pressure.BackColor = System.Drawing.Color.Transparent;
            this.lab_Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Pressure.Location = new System.Drawing.Point(629, 265);
            this.lab_Pressure.Name = "lab_Pressure";
            this.lab_Pressure.Size = new System.Drawing.Size(88, 33);
            this.lab_Pressure.TabIndex = 11;
            this.lab_Pressure.Text = "None";
            // 
            // lab_WindSpeed
            // 
            this.lab_WindSpeed.AutoSize = true;
            this.lab_WindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lab_WindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_WindSpeed.Location = new System.Drawing.Point(629, 209);
            this.lab_WindSpeed.Name = "lab_WindSpeed";
            this.lab_WindSpeed.Size = new System.Drawing.Size(88, 33);
            this.lab_WindSpeed.TabIndex = 12;
            this.lab_WindSpeed.Text = "None";
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pressure.Location = new System.Drawing.Point(414, 265);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(167, 33);
            this.Pressure.TabIndex = 13;
            this.Pressure.Text = "Pressure : ";
            // 
            // pic_Icon
            // 
            this.pic_Icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_Icon.Location = new System.Drawing.Point(56, 110);
            this.pic_Icon.Name = "pic_Icon";
            this.pic_Icon.Size = new System.Drawing.Size(241, 96);
            this.pic_Icon.TabIndex = 14;
            this.pic_Icon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic_Icon);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.lab_WindSpeed);
            this.Controls.Add(this.lab_Pressure);
            this.Controls.Add(this.WinSpeed);
            this.Controls.Add(this.lab_Sunrise);
            this.Controls.Add(this.lab_Sunset);
            this.Controls.Add(this.Sunset);
            this.Controls.Add(this.Sunrise);
            this.Controls.Add(this.lab_Detail);
            this.Controls.Add(this.lab_Conditions);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCity);
            this.Controls.Add(this.btn_close);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lab_Conditions;
        private System.Windows.Forms.Label lab_Detail;
        private System.Windows.Forms.Label Sunrise;
        private System.Windows.Forms.Label Sunset;
        private System.Windows.Forms.Label lab_Sunset;
        private System.Windows.Forms.Label lab_Sunrise;
        private System.Windows.Forms.Label WinSpeed;
        private System.Windows.Forms.Label lab_Pressure;
        private System.Windows.Forms.Label lab_WindSpeed;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.PictureBox pic_Icon;
    }
}


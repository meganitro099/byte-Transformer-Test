namespace byte_Test
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.uint8_0xFF_2 = new System.Windows.Forms.TextBox();
            this.uint8_0xFF_1 = new System.Windows.Forms.TextBox();
            this.uint8_0x52 = new System.Windows.Forms.TextBox();
            this.uint8_0x54 = new System.Windows.Forms.TextBox();
            this.uint8_PacketCounter = new System.Windows.Forms.TextBox();
            this.uint8_teamID = new System.Windows.Forms.TextBox();
            this.float32_rGPS = new System.Windows.Forms.TextBox();
            this.float32_irtifa = new System.Windows.Forms.TextBox();
            this.float32_rBoylam = new System.Windows.Forms.TextBox();
            this.float32_rEnlem = new System.Windows.Forms.TextBox();
            this.float32_yEnlem = new System.Windows.Forms.TextBox();
            this.float32_yGPS = new System.Windows.Forms.TextBox();
            this.uint8_KEY2 = new System.Windows.Forms.TextBox();
            this.uint8_KEY1 = new System.Windows.Forms.TextBox();
            this.uint8_CRC = new System.Windows.Forms.TextBox();
            this.uint8_Durum = new System.Windows.Forms.TextBox();
            this.float32_aci = new System.Windows.Forms.TextBox();
            this.float32_ivmeZ = new System.Windows.Forms.TextBox();
            this.float32_ivmeY = new System.Windows.Forms.TextBox();
            this.float32_ivmeX = new System.Windows.Forms.TextBox();
            this.float32_gyroZ = new System.Windows.Forms.TextBox();
            this.float32_gyroY = new System.Windows.Forms.TextBox();
            this.float32_gyroX = new System.Windows.Forms.TextBox();
            this.float32_yBoylam = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uint8_0xFF_2
            // 
            this.uint8_0xFF_2.Location = new System.Drawing.Point(79, 12);
            this.uint8_0xFF_2.Name = "uint8_0xFF_2";
            this.uint8_0xFF_2.ReadOnly = true;
            this.uint8_0xFF_2.Size = new System.Drawing.Size(61, 20);
            this.uint8_0xFF_2.TabIndex = 5;
            // 
            // uint8_0xFF_1
            // 
            this.uint8_0xFF_1.Location = new System.Drawing.Point(12, 12);
            this.uint8_0xFF_1.Name = "uint8_0xFF_1";
            this.uint8_0xFF_1.ReadOnly = true;
            this.uint8_0xFF_1.Size = new System.Drawing.Size(61, 20);
            this.uint8_0xFF_1.TabIndex = 4;
            // 
            // uint8_0x52
            // 
            this.uint8_0x52.Location = new System.Drawing.Point(213, 12);
            this.uint8_0x52.Name = "uint8_0x52";
            this.uint8_0x52.ReadOnly = true;
            this.uint8_0x52.Size = new System.Drawing.Size(61, 20);
            this.uint8_0x52.TabIndex = 7;
            // 
            // uint8_0x54
            // 
            this.uint8_0x54.Location = new System.Drawing.Point(146, 12);
            this.uint8_0x54.Name = "uint8_0x54";
            this.uint8_0x54.ReadOnly = true;
            this.uint8_0x54.Size = new System.Drawing.Size(61, 20);
            this.uint8_0x54.TabIndex = 6;
            // 
            // uint8_PacketCounter
            // 
            this.uint8_PacketCounter.Location = new System.Drawing.Point(347, 12);
            this.uint8_PacketCounter.Name = "uint8_PacketCounter";
            this.uint8_PacketCounter.Size = new System.Drawing.Size(61, 20);
            this.uint8_PacketCounter.TabIndex = 9;
            // 
            // uint8_teamID
            // 
            this.uint8_teamID.Location = new System.Drawing.Point(280, 12);
            this.uint8_teamID.Name = "uint8_teamID";
            this.uint8_teamID.Size = new System.Drawing.Size(61, 20);
            this.uint8_teamID.TabIndex = 8;
            // 
            // float32_rGPS
            // 
            this.float32_rGPS.Location = new System.Drawing.Point(481, 12);
            this.float32_rGPS.Name = "float32_rGPS";
            this.float32_rGPS.Size = new System.Drawing.Size(61, 20);
            this.float32_rGPS.TabIndex = 11;
            // 
            // float32_irtifa
            // 
            this.float32_irtifa.Location = new System.Drawing.Point(414, 12);
            this.float32_irtifa.Name = "float32_irtifa";
            this.float32_irtifa.Size = new System.Drawing.Size(61, 20);
            this.float32_irtifa.TabIndex = 10;
            // 
            // float32_rBoylam
            // 
            this.float32_rBoylam.Location = new System.Drawing.Point(616, 12);
            this.float32_rBoylam.Name = "float32_rBoylam";
            this.float32_rBoylam.Size = new System.Drawing.Size(61, 20);
            this.float32_rBoylam.TabIndex = 13;
            // 
            // float32_rEnlem
            // 
            this.float32_rEnlem.Location = new System.Drawing.Point(549, 12);
            this.float32_rEnlem.Name = "float32_rEnlem";
            this.float32_rEnlem.Size = new System.Drawing.Size(61, 20);
            this.float32_rEnlem.TabIndex = 12;
            // 
            // float32_yEnlem
            // 
            this.float32_yEnlem.Location = new System.Drawing.Point(748, 12);
            this.float32_yEnlem.Name = "float32_yEnlem";
            this.float32_yEnlem.Size = new System.Drawing.Size(61, 20);
            this.float32_yEnlem.TabIndex = 15;
            // 
            // float32_yGPS
            // 
            this.float32_yGPS.Location = new System.Drawing.Point(681, 12);
            this.float32_yGPS.Name = "float32_yGPS";
            this.float32_yGPS.Size = new System.Drawing.Size(61, 20);
            this.float32_yGPS.TabIndex = 14;
            // 
            // uint8_KEY2
            // 
            this.uint8_KEY2.Location = new System.Drawing.Point(748, 38);
            this.uint8_KEY2.Name = "uint8_KEY2";
            this.uint8_KEY2.ReadOnly = true;
            this.uint8_KEY2.Size = new System.Drawing.Size(61, 20);
            this.uint8_KEY2.TabIndex = 27;
            this.uint8_KEY2.Text = "10";
            // 
            // uint8_KEY1
            // 
            this.uint8_KEY1.Location = new System.Drawing.Point(681, 38);
            this.uint8_KEY1.Name = "uint8_KEY1";
            this.uint8_KEY1.ReadOnly = true;
            this.uint8_KEY1.Size = new System.Drawing.Size(61, 20);
            this.uint8_KEY1.TabIndex = 26;
            this.uint8_KEY1.Text = "13";
            // 
            // uint8_CRC
            // 
            this.uint8_CRC.Location = new System.Drawing.Point(616, 38);
            this.uint8_CRC.Name = "uint8_CRC";
            this.uint8_CRC.Size = new System.Drawing.Size(61, 20);
            this.uint8_CRC.TabIndex = 25;
            // 
            // uint8_Durum
            // 
            this.uint8_Durum.Location = new System.Drawing.Point(549, 38);
            this.uint8_Durum.Name = "uint8_Durum";
            this.uint8_Durum.Size = new System.Drawing.Size(61, 20);
            this.uint8_Durum.TabIndex = 24;
            // 
            // float32_aci
            // 
            this.float32_aci.Location = new System.Drawing.Point(481, 38);
            this.float32_aci.Name = "float32_aci";
            this.float32_aci.Size = new System.Drawing.Size(61, 20);
            this.float32_aci.TabIndex = 23;
            // 
            // float32_ivmeZ
            // 
            this.float32_ivmeZ.Location = new System.Drawing.Point(414, 38);
            this.float32_ivmeZ.Name = "float32_ivmeZ";
            this.float32_ivmeZ.Size = new System.Drawing.Size(61, 20);
            this.float32_ivmeZ.TabIndex = 22;
            // 
            // float32_ivmeY
            // 
            this.float32_ivmeY.Location = new System.Drawing.Point(347, 38);
            this.float32_ivmeY.Name = "float32_ivmeY";
            this.float32_ivmeY.Size = new System.Drawing.Size(61, 20);
            this.float32_ivmeY.TabIndex = 21;
            // 
            // float32_ivmeX
            // 
            this.float32_ivmeX.Location = new System.Drawing.Point(280, 38);
            this.float32_ivmeX.Name = "float32_ivmeX";
            this.float32_ivmeX.Size = new System.Drawing.Size(61, 20);
            this.float32_ivmeX.TabIndex = 20;
            // 
            // float32_gyroZ
            // 
            this.float32_gyroZ.Location = new System.Drawing.Point(213, 38);
            this.float32_gyroZ.Name = "float32_gyroZ";
            this.float32_gyroZ.Size = new System.Drawing.Size(61, 20);
            this.float32_gyroZ.TabIndex = 19;
            // 
            // float32_gyroY
            // 
            this.float32_gyroY.Location = new System.Drawing.Point(146, 38);
            this.float32_gyroY.Name = "float32_gyroY";
            this.float32_gyroY.Size = new System.Drawing.Size(61, 20);
            this.float32_gyroY.TabIndex = 18;
            // 
            // float32_gyroX
            // 
            this.float32_gyroX.Location = new System.Drawing.Point(79, 38);
            this.float32_gyroX.Name = "float32_gyroX";
            this.float32_gyroX.Size = new System.Drawing.Size(61, 20);
            this.float32_gyroX.TabIndex = 17;
            // 
            // float32_yBoylam
            // 
            this.float32_yBoylam.Location = new System.Drawing.Point(12, 38);
            this.float32_yBoylam.Name = "float32_yBoylam";
            this.float32_yBoylam.Size = new System.Drawing.Size(61, 20);
            this.float32_yBoylam.TabIndex = 16;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 179);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(822, 95);
            this.output.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 306);
            this.Controls.Add(this.output);
            this.Controls.Add(this.uint8_KEY2);
            this.Controls.Add(this.uint8_KEY1);
            this.Controls.Add(this.uint8_CRC);
            this.Controls.Add(this.uint8_Durum);
            this.Controls.Add(this.float32_aci);
            this.Controls.Add(this.float32_ivmeZ);
            this.Controls.Add(this.float32_ivmeY);
            this.Controls.Add(this.float32_ivmeX);
            this.Controls.Add(this.float32_gyroZ);
            this.Controls.Add(this.float32_gyroY);
            this.Controls.Add(this.float32_gyroX);
            this.Controls.Add(this.float32_yBoylam);
            this.Controls.Add(this.float32_yEnlem);
            this.Controls.Add(this.float32_yGPS);
            this.Controls.Add(this.float32_rBoylam);
            this.Controls.Add(this.float32_rEnlem);
            this.Controls.Add(this.float32_rGPS);
            this.Controls.Add(this.float32_irtifa);
            this.Controls.Add(this.uint8_PacketCounter);
            this.Controls.Add(this.uint8_teamID);
            this.Controls.Add(this.uint8_0x52);
            this.Controls.Add(this.uint8_0x54);
            this.Controls.Add(this.uint8_0xFF_2);
            this.Controls.Add(this.uint8_0xFF_1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox uint8_0xFF_2;
        private System.Windows.Forms.TextBox uint8_0xFF_1;
        private System.Windows.Forms.TextBox uint8_0x52;
        private System.Windows.Forms.TextBox uint8_0x54;
        private System.Windows.Forms.TextBox uint8_PacketCounter;
        private System.Windows.Forms.TextBox uint8_teamID;
        private System.Windows.Forms.TextBox float32_rGPS;
        private System.Windows.Forms.TextBox float32_irtifa;
        private System.Windows.Forms.TextBox float32_rBoylam;
        private System.Windows.Forms.TextBox float32_rEnlem;
        private System.Windows.Forms.TextBox float32_yEnlem;
        private System.Windows.Forms.TextBox float32_yGPS;
        private System.Windows.Forms.TextBox uint8_KEY2;
        private System.Windows.Forms.TextBox uint8_KEY1;
        private System.Windows.Forms.TextBox uint8_CRC;
        private System.Windows.Forms.TextBox uint8_Durum;
        private System.Windows.Forms.TextBox float32_aci;
        private System.Windows.Forms.TextBox float32_ivmeZ;
        private System.Windows.Forms.TextBox float32_ivmeY;
        private System.Windows.Forms.TextBox float32_ivmeX;
        private System.Windows.Forms.TextBox float32_gyroZ;
        private System.Windows.Forms.TextBox float32_gyroY;
        private System.Windows.Forms.TextBox float32_gyroX;
        private System.Windows.Forms.TextBox float32_yBoylam;
        private System.Windows.Forms.TextBox output;
    }
}


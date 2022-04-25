
namespace Praktikum_W08_S2
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
            this.cBoxTimHome = new System.Windows.Forms.ComboBox();
            this.cBoxTimLawan = new System.Windows.Forms.ComboBox();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblManager1 = new System.Windows.Forms.Label();
            this.lblCaptain1 = new System.Windows.Forms.Label();
            this.lblNamaManager1 = new System.Windows.Forms.Label();
            this.lblNamaCaptain1 = new System.Windows.Forms.Label();
            this.lblNamaCaptain2 = new System.Windows.Forms.Label();
            this.lblNamaManager2 = new System.Windows.Forms.Label();
            this.lblCaptain2 = new System.Windows.Forms.Label();
            this.lblManager2 = new System.Windows.Forms.Label();
            this.lblJumlahCapacity = new System.Windows.Forms.Label();
            this.lblNamaStadium = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.dataGridMatch = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblNamaTanggal = new System.Windows.Forms.Label();
            this.lblJumlahSkor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxTimHome
            // 
            this.cBoxTimHome.FormattingEnabled = true;
            this.cBoxTimHome.Location = new System.Drawing.Point(90, 80);
            this.cBoxTimHome.Name = "cBoxTimHome";
            this.cBoxTimHome.Size = new System.Drawing.Size(175, 24);
            this.cBoxTimHome.TabIndex = 0;
            this.cBoxTimHome.SelectedIndexChanged += new System.EventHandler(this.cBoxTimHome_SelectedIndexChanged);
            // 
            // cBoxTimLawan
            // 
            this.cBoxTimLawan.FormattingEnabled = true;
            this.cBoxTimLawan.Location = new System.Drawing.Point(491, 80);
            this.cBoxTimLawan.Name = "cBoxTimLawan";
            this.cBoxTimLawan.Size = new System.Drawing.Size(175, 24);
            this.cBoxTimLawan.TabIndex = 1;
            this.cBoxTimLawan.SelectedIndexChanged += new System.EventHandler(this.cBoxTimLawan_SelectedIndexChanged);
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(363, 83);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(26, 17);
            this.lblVS.TabIndex = 2;
            this.lblVS.Text = "VS";
            // 
            // lblManager1
            // 
            this.lblManager1.AutoSize = true;
            this.lblManager1.Location = new System.Drawing.Point(87, 136);
            this.lblManager1.Name = "lblManager1";
            this.lblManager1.Size = new System.Drawing.Size(68, 17);
            this.lblManager1.TabIndex = 3;
            this.lblManager1.Text = "Manager:";
            // 
            // lblCaptain1
            // 
            this.lblCaptain1.AutoSize = true;
            this.lblCaptain1.Location = new System.Drawing.Point(87, 179);
            this.lblCaptain1.Name = "lblCaptain1";
            this.lblCaptain1.Size = new System.Drawing.Size(60, 17);
            this.lblCaptain1.TabIndex = 4;
            this.lblCaptain1.Text = "Captain:";
            // 
            // lblNamaManager1
            // 
            this.lblNamaManager1.AutoSize = true;
            this.lblNamaManager1.Location = new System.Drawing.Point(161, 136);
            this.lblNamaManager1.Name = "lblNamaManager1";
            this.lblNamaManager1.Size = new System.Drawing.Size(0, 17);
            this.lblNamaManager1.TabIndex = 5;
            // 
            // lblNamaCaptain1
            // 
            this.lblNamaCaptain1.AutoSize = true;
            this.lblNamaCaptain1.Location = new System.Drawing.Point(161, 179);
            this.lblNamaCaptain1.Name = "lblNamaCaptain1";
            this.lblNamaCaptain1.Size = new System.Drawing.Size(0, 17);
            this.lblNamaCaptain1.TabIndex = 6;
            // 
            // lblNamaCaptain2
            // 
            this.lblNamaCaptain2.AutoSize = true;
            this.lblNamaCaptain2.Location = new System.Drawing.Point(562, 179);
            this.lblNamaCaptain2.Name = "lblNamaCaptain2";
            this.lblNamaCaptain2.Size = new System.Drawing.Size(0, 17);
            this.lblNamaCaptain2.TabIndex = 10;
            // 
            // lblNamaManager2
            // 
            this.lblNamaManager2.AutoSize = true;
            this.lblNamaManager2.Location = new System.Drawing.Point(562, 136);
            this.lblNamaManager2.Name = "lblNamaManager2";
            this.lblNamaManager2.Size = new System.Drawing.Size(0, 17);
            this.lblNamaManager2.TabIndex = 9;
            // 
            // lblCaptain2
            // 
            this.lblCaptain2.AutoSize = true;
            this.lblCaptain2.Location = new System.Drawing.Point(488, 179);
            this.lblCaptain2.Name = "lblCaptain2";
            this.lblCaptain2.Size = new System.Drawing.Size(60, 17);
            this.lblCaptain2.TabIndex = 8;
            this.lblCaptain2.Text = "Captain:";
            // 
            // lblManager2
            // 
            this.lblManager2.AutoSize = true;
            this.lblManager2.Location = new System.Drawing.Point(488, 136);
            this.lblManager2.Name = "lblManager2";
            this.lblManager2.Size = new System.Drawing.Size(68, 17);
            this.lblManager2.TabIndex = 7;
            this.lblManager2.Text = "Manager:";
            // 
            // lblJumlahCapacity
            // 
            this.lblJumlahCapacity.AutoSize = true;
            this.lblJumlahCapacity.Location = new System.Drawing.Point(390, 231);
            this.lblJumlahCapacity.Name = "lblJumlahCapacity";
            this.lblJumlahCapacity.Size = new System.Drawing.Size(0, 17);
            this.lblJumlahCapacity.TabIndex = 14;
            // 
            // lblNamaStadium
            // 
            this.lblNamaStadium.AutoSize = true;
            this.lblNamaStadium.Location = new System.Drawing.Point(390, 201);
            this.lblNamaStadium.Name = "lblNamaStadium";
            this.lblNamaStadium.Size = new System.Drawing.Size(0, 17);
            this.lblNamaStadium.TabIndex = 13;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(318, 231);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(66, 17);
            this.lblCapacity.TabIndex = 12;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(321, 201);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(63, 17);
            this.lblStadium.TabIndex = 11;
            this.lblStadium.Text = "Stadium:";
            // 
            // dataGridMatch
            // 
            this.dataGridMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatch.Location = new System.Drawing.Point(12, 378);
            this.dataGridMatch.Name = "dataGridMatch";
            this.dataGridMatch.RowHeadersWidth = 51;
            this.dataGridMatch.RowTemplate.Height = 24;
            this.dataGridMatch.Size = new System.Drawing.Size(776, 280);
            this.dataGridMatch.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(318, 321);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(64, 17);
            this.lblTanggal.TabIndex = 17;
            this.lblTanggal.Text = "Tanggal:";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(341, 348);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(41, 17);
            this.lblSkor.TabIndex = 18;
            this.lblSkor.Text = "Skor:";
            // 
            // lblNamaTanggal
            // 
            this.lblNamaTanggal.AutoSize = true;
            this.lblNamaTanggal.Location = new System.Drawing.Point(388, 321);
            this.lblNamaTanggal.Name = "lblNamaTanggal";
            this.lblNamaTanggal.Size = new System.Drawing.Size(0, 17);
            this.lblNamaTanggal.TabIndex = 19;
            // 
            // lblJumlahSkor
            // 
            this.lblJumlahSkor.AutoSize = true;
            this.lblJumlahSkor.Location = new System.Drawing.Point(388, 348);
            this.lblJumlahSkor.Name = "lblJumlahSkor";
            this.lblJumlahSkor.Size = new System.Drawing.Size(0, 17);
            this.lblJumlahSkor.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.lblJumlahSkor);
            this.Controls.Add(this.lblNamaTanggal);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridMatch);
            this.Controls.Add(this.lblJumlahCapacity);
            this.Controls.Add(this.lblNamaStadium);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblNamaCaptain2);
            this.Controls.Add(this.lblNamaManager2);
            this.Controls.Add(this.lblCaptain2);
            this.Controls.Add(this.lblManager2);
            this.Controls.Add(this.lblNamaCaptain1);
            this.Controls.Add(this.lblNamaManager1);
            this.Controls.Add(this.lblCaptain1);
            this.Controls.Add(this.lblManager1);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.cBoxTimLawan);
            this.Controls.Add(this.cBoxTimHome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxTimHome;
        private System.Windows.Forms.ComboBox cBoxTimLawan;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblManager1;
        private System.Windows.Forms.Label lblCaptain1;
        private System.Windows.Forms.Label lblNamaManager1;
        private System.Windows.Forms.Label lblNamaCaptain1;
        private System.Windows.Forms.Label lblNamaCaptain2;
        private System.Windows.Forms.Label lblNamaManager2;
        private System.Windows.Forms.Label lblCaptain2;
        private System.Windows.Forms.Label lblManager2;
        private System.Windows.Forms.Label lblJumlahCapacity;
        private System.Windows.Forms.Label lblNamaStadium;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.DataGridView dataGridMatch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblNamaTanggal;
        private System.Windows.Forms.Label lblJumlahSkor;
    }
}


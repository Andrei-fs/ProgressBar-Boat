namespace CargoShipGraphical
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.track_Trucks = new System.Windows.Forms.TrackBar();
            this.track_Trains = new System.Windows.Forms.TrackBar();
            this.track_Cars = new System.Windows.Forms.TrackBar();
            this.track_motorCycles = new System.Windows.Forms.TrackBar();
            this.label_CycleCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_CarCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_TruckCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_TrainCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_shipLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Trucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Trains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CargoShipGraphical.Properties.Resources.cargoship;
            this.pictureBox2.Location = new System.Drawing.Point(54, -35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(881, 359);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(259, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(565, 139);
            this.progressBar1.TabIndex = 2;
            // 
            // track_Trucks
            // 
            this.track_Trucks.Location = new System.Drawing.Point(735, 347);
            this.track_Trucks.Name = "track_Trucks";
            this.track_Trucks.Size = new System.Drawing.Size(213, 56);
            this.track_Trucks.TabIndex = 4;
            this.track_Trucks.Scroll += new System.EventHandler(this.track_Trucks_Scroll);
            // 
            // track_Trains
            // 
            this.track_Trains.Location = new System.Drawing.Point(735, 447);
            this.track_Trains.Name = "track_Trains";
            this.track_Trains.Size = new System.Drawing.Size(213, 56);
            this.track_Trains.TabIndex = 6;
            this.track_Trains.Scroll += new System.EventHandler(this.track_Trains_Scroll);
            // 
            // track_Cars
            // 
            this.track_Cars.Location = new System.Drawing.Point(77, 447);
            this.track_Cars.Name = "track_Cars";
            this.track_Cars.Size = new System.Drawing.Size(213, 56);
            this.track_Cars.TabIndex = 8;
            this.track_Cars.Scroll += new System.EventHandler(this.track_Cars_Scroll);
            // 
            // track_motorCycles
            // 
            this.track_motorCycles.Location = new System.Drawing.Point(77, 347);
            this.track_motorCycles.Name = "track_motorCycles";
            this.track_motorCycles.Size = new System.Drawing.Size(213, 56);
            this.track_motorCycles.TabIndex = 7;
            this.track_motorCycles.Scroll += new System.EventHandler(this.track_motorCycles_Scroll);
            // 
            // label_CycleCount
            // 
            this.label_CycleCount.AutoSize = true;
            this.label_CycleCount.Location = new System.Drawing.Point(123, 338);
            this.label_CycleCount.Name = "label_CycleCount";
            this.label_CycleCount.Size = new System.Drawing.Size(46, 17);
            this.label_CycleCount.TabIndex = 9;
            this.label_CycleCount.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "MotorCycles (3 units)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_CarCount
            // 
            this.label_CarCount.AutoSize = true;
            this.label_CarCount.Location = new System.Drawing.Point(123, 438);
            this.label_CarCount.Name = "label_CarCount";
            this.label_CarCount.Size = new System.Drawing.Size(46, 17);
            this.label_CarCount.TabIndex = 11;
            this.label_CarCount.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 489);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cars (5 units)";
            // 
            // label_TruckCount
            // 
            this.label_TruckCount.AutoSize = true;
            this.label_TruckCount.Location = new System.Drawing.Point(798, 338);
            this.label_TruckCount.Name = "label_TruckCount";
            this.label_TruckCount.Size = new System.Drawing.Size(46, 17);
            this.label_TruckCount.TabIndex = 13;
            this.label_TruckCount.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(798, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Trucks (11 units)";
            // 
            // label_TrainCount
            // 
            this.label_TrainCount.AutoSize = true;
            this.label_TrainCount.Location = new System.Drawing.Point(798, 438);
            this.label_TrainCount.Name = "label_TrainCount";
            this.label_TrainCount.Size = new System.Drawing.Size(46, 17);
            this.label_TrainCount.TabIndex = 15;
            this.label_TrainCount.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(798, 489);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Trains (17 units)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "New Ship";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_shipLabel
            // 
            this.label_shipLabel.AutoSize = true;
            this.label_shipLabel.Location = new System.Drawing.Point(227, 230);
            this.label_shipLabel.Name = "label_shipLabel";
            this.label_shipLabel.Size = new System.Drawing.Size(0, 17);
            this.label_shipLabel.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 39);
            this.label3.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_shipLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_TrainCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_TruckCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_CarCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_CycleCount);
            this.Controls.Add(this.track_Cars);
            this.Controls.Add(this.track_motorCycles);
            this.Controls.Add(this.track_Trains);
            this.Controls.Add(this.track_Trucks);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Load The Ship";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Trucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Trains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_motorCycles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar track_Trucks;
        private System.Windows.Forms.TrackBar track_Trains;
        private System.Windows.Forms.TrackBar track_Cars;
        private System.Windows.Forms.TrackBar track_motorCycles;
        private System.Windows.Forms.Label label_CycleCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_CarCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_TruckCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_TrainCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_shipLabel;
        private System.Windows.Forms.Label label3;
    }
}


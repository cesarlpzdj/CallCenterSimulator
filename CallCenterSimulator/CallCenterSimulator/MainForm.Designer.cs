namespace CallCenterSimulator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SimulateButton = new System.Windows.Forms.Button();
            this.Agente4CheckBox = new System.Windows.Forms.CheckBox();
            this.Agente3CheckBox = new System.Windows.Forms.CheckBox();
            this.Agente2CheckBox = new System.Windows.Forms.CheckBox();
            this.Agente1CheckBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.AclaracionesCheckBox = new System.Windows.Forms.CheckBox();
            this.EntregasCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportacionesCheckBox = new System.Windows.Forms.CheckBox();
            this.DevoulcionesCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DurationMaxNum = new System.Windows.Forms.NumericUpDown();
            this.DurationMinNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfCallsNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.IncomingCallsLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationMaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationMinNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfCallsNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de Call Center";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SimulateButton);
            this.groupBox1.Controls.Add(this.Agente4CheckBox);
            this.groupBox1.Controls.Add(this.Agente3CheckBox);
            this.groupBox1.Controls.Add(this.Agente2CheckBox);
            this.groupBox1.Controls.Add(this.Agente1CheckBox);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.AclaracionesCheckBox);
            this.groupBox1.Controls.Add(this.EntregasCheckBox);
            this.groupBox1.Controls.Add(this.ExportacionesCheckBox);
            this.groupBox1.Controls.Add(this.DevoulcionesCheckBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DurationMaxNum);
            this.groupBox1.Controls.Add(this.DurationMinNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NumberOfCallsNum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // SimulateButton
            // 
            this.SimulateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimulateButton.Location = new System.Drawing.Point(245, 414);
            this.SimulateButton.Name = "SimulateButton";
            this.SimulateButton.Size = new System.Drawing.Size(75, 23);
            this.SimulateButton.TabIndex = 25;
            this.SimulateButton.Text = "Simular";
            this.SimulateButton.UseVisualStyleBackColor = true;
            this.SimulateButton.Click += new System.EventHandler(this.SimulateButton_Click);
            // 
            // Agente4CheckBox
            // 
            this.Agente4CheckBox.AutoSize = true;
            this.Agente4CheckBox.Checked = true;
            this.Agente4CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Agente4CheckBox.Location = new System.Drawing.Point(129, 338);
            this.Agente4CheckBox.Name = "Agente4CheckBox";
            this.Agente4CheckBox.Size = new System.Drawing.Size(64, 17);
            this.Agente4CheckBox.TabIndex = 22;
            this.Agente4CheckBox.Text = "Gerente";
            this.Agente4CheckBox.UseVisualStyleBackColor = true;
            // 
            // Agente3CheckBox
            // 
            this.Agente3CheckBox.AutoSize = true;
            this.Agente3CheckBox.Checked = true;
            this.Agente3CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Agente3CheckBox.Location = new System.Drawing.Point(129, 315);
            this.Agente3CheckBox.Name = "Agente3CheckBox";
            this.Agente3CheckBox.Size = new System.Drawing.Size(69, 17);
            this.Agente3CheckBox.TabIndex = 21;
            this.Agente3CheckBox.Text = "Agente 3";
            this.Agente3CheckBox.UseVisualStyleBackColor = true;
            // 
            // Agente2CheckBox
            // 
            this.Agente2CheckBox.AutoSize = true;
            this.Agente2CheckBox.Checked = true;
            this.Agente2CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Agente2CheckBox.Location = new System.Drawing.Point(129, 292);
            this.Agente2CheckBox.Name = "Agente2CheckBox";
            this.Agente2CheckBox.Size = new System.Drawing.Size(69, 17);
            this.Agente2CheckBox.TabIndex = 20;
            this.Agente2CheckBox.Text = "Agente 2";
            this.Agente2CheckBox.UseVisualStyleBackColor = true;
            // 
            // Agente1CheckBox
            // 
            this.Agente1CheckBox.AutoSize = true;
            this.Agente1CheckBox.Checked = true;
            this.Agente1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Agente1CheckBox.Location = new System.Drawing.Point(129, 269);
            this.Agente1CheckBox.Name = "Agente1CheckBox";
            this.Agente1CheckBox.Size = new System.Drawing.Size(69, 17);
            this.Agente1CheckBox.TabIndex = 19;
            this.Agente1CheckBox.Text = "Agente 1";
            this.Agente1CheckBox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(6, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 28);
            this.label16.TabIndex = 18;
            this.label16.Text = "Personas disponibles";
            // 
            // AclaracionesCheckBox
            // 
            this.AclaracionesCheckBox.AutoSize = true;
            this.AclaracionesCheckBox.Checked = true;
            this.AclaracionesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AclaracionesCheckBox.Location = new System.Drawing.Point(129, 219);
            this.AclaracionesCheckBox.Name = "AclaracionesCheckBox";
            this.AclaracionesCheckBox.Size = new System.Drawing.Size(87, 17);
            this.AclaracionesCheckBox.TabIndex = 17;
            this.AclaracionesCheckBox.Text = "Aclaraciones";
            this.AclaracionesCheckBox.UseVisualStyleBackColor = true;
            // 
            // EntregasCheckBox
            // 
            this.EntregasCheckBox.AutoSize = true;
            this.EntregasCheckBox.Checked = true;
            this.EntregasCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EntregasCheckBox.Location = new System.Drawing.Point(129, 196);
            this.EntregasCheckBox.Name = "EntregasCheckBox";
            this.EntregasCheckBox.Size = new System.Drawing.Size(68, 17);
            this.EntregasCheckBox.TabIndex = 16;
            this.EntregasCheckBox.Text = "Entregas";
            this.EntregasCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportacionesCheckBox
            // 
            this.ExportacionesCheckBox.AutoSize = true;
            this.ExportacionesCheckBox.Checked = true;
            this.ExportacionesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ExportacionesCheckBox.Location = new System.Drawing.Point(129, 173);
            this.ExportacionesCheckBox.Name = "ExportacionesCheckBox";
            this.ExportacionesCheckBox.Size = new System.Drawing.Size(93, 17);
            this.ExportacionesCheckBox.TabIndex = 15;
            this.ExportacionesCheckBox.Text = "Exportaciones";
            this.ExportacionesCheckBox.UseVisualStyleBackColor = true;
            // 
            // DevoulcionesCheckBox
            // 
            this.DevoulcionesCheckBox.AutoSize = true;
            this.DevoulcionesCheckBox.Checked = true;
            this.DevoulcionesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DevoulcionesCheckBox.Location = new System.Drawing.Point(129, 150);
            this.DevoulcionesCheckBox.Name = "DevoulcionesCheckBox";
            this.DevoulcionesCheckBox.Size = new System.Drawing.Size(91, 17);
            this.DevoulcionesCheckBox.TabIndex = 14;
            this.DevoulcionesCheckBox.Text = "Devoluciones";
            this.DevoulcionesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Categorías";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "a";
            // 
            // DurationMaxNum
            // 
            this.DurationMaxNum.Location = new System.Drawing.Point(218, 79);
            this.DurationMaxNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DurationMaxNum.Name = "DurationMaxNum";
            this.DurationMaxNum.Size = new System.Drawing.Size(53, 20);
            this.DurationMaxNum.TabIndex = 5;
            this.DurationMaxNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DurationMinNum
            // 
            this.DurationMinNum.Location = new System.Drawing.Point(129, 79);
            this.DurationMinNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DurationMinNum.Name = "DurationMinNum";
            this.DurationMinNum.Size = new System.Drawing.Size(53, 20);
            this.DurationMinNum.TabIndex = 3;
            this.DurationMinNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rango de duración";
            // 
            // NumberOfCallsNum
            // 
            this.NumberOfCallsNum.Location = new System.Drawing.Point(129, 45);
            this.NumberOfCallsNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfCallsNum.Name = "NumberOfCallsNum";
            this.NumberOfCallsNum.Size = new System.Drawing.Size(142, 20);
            this.NumberOfCallsNum.TabIndex = 1;
            this.NumberOfCallsNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de llamadas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.IncomingCallsLabel);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(356, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 456);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagrama";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(418, 252);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Ocupado";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(236, 352);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Ocupado";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(236, 252);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Ocupado";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(236, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Ocupado";
            // 
            // IncomingCallsLabel
            // 
            this.IncomingCallsLabel.AutoSize = true;
            this.IncomingCallsLabel.Location = new System.Drawing.Point(37, 252);
            this.IncomingCallsLabel.Name = "IncomingCallsLabel";
            this.IncomingCallsLabel.Size = new System.Drawing.Size(106, 13);
            this.IncomingCallsLabel.TabIndex = 1;
            this.IncomingCallsLabel.Text = "x llamadas en espera";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(421, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Gerente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Agente 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Agente 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Agente 1";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CallCenterSimulator.Properties.Resources.manager;
            this.pictureBox6.Location = new System.Drawing.Point(418, 199);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CallCenterSimulator.Properties.Resources.agent_woman;
            this.pictureBox5.Location = new System.Drawing.Point(236, 299);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CallCenterSimulator.Properties.Resources.agent_woman;
            this.pictureBox4.Location = new System.Drawing.Point(236, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CallCenterSimulator.Properties.Resources.agent_man;
            this.pictureBox3.Location = new System.Drawing.Point(236, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Conmutador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CallCenterSimulator.Properties.Resources.router;
            this.pictureBox2.Location = new System.Drawing.Point(60, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CallCenterSimulator.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(566, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // worker
            // 
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Call Center";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationMaxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationMinNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfCallsNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NumberOfCallsNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DurationMaxNum;
        private System.Windows.Forms.NumericUpDown DurationMinNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox AclaracionesCheckBox;
        private System.Windows.Forms.CheckBox EntregasCheckBox;
        private System.Windows.Forms.CheckBox ExportacionesCheckBox;
        private System.Windows.Forms.CheckBox DevoulcionesCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox Agente4CheckBox;
        private System.Windows.Forms.CheckBox Agente3CheckBox;
        private System.Windows.Forms.CheckBox Agente2CheckBox;
        private System.Windows.Forms.CheckBox Agente1CheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button SimulateButton;
        private System.Windows.Forms.Label IncomingCallsLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.ComponentModel.BackgroundWorker worker;
    }
}


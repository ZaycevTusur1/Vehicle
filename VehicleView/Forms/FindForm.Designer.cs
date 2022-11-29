namespace VehicleView.Forms
{
    partial class FindForm
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
            this.DataGridViewFindVehicle = new System.Windows.Forms.DataGridView();
            this.DataGridViewCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewEngineCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewFuelConsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCalc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EngineCopacityMinTextBox = new System.Windows.Forms.TextBox();
            this.EngineCopacityMaxTextBox = new System.Windows.Forms.TextBox();
            this.TankCopacityMinTextBox = new System.Windows.Forms.TextBox();
            this.TankCopacityMaxTextBox = new System.Windows.Forms.TextBox();
            this.FuelConsumptionMinTextBox = new System.Windows.Forms.TextBox();
            this.FuelConsumptionMaxTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFindVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewFindVehicle
            // 
            this.DataGridViewFindVehicle.AllowUserToAddRows = false;
            this.DataGridViewFindVehicle.AllowUserToDeleteRows = false;
            this.DataGridViewFindVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFindVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCount,
            this.DataGridViewName,
            this.DataGridViewEngineCapacity,
            this.DataGridViewFuelConsumption,
            this.DataGridViewCalc});
            this.DataGridViewFindVehicle.Location = new System.Drawing.Point(241, 12);
            this.DataGridViewFindVehicle.Name = "DataGridViewFindVehicle";
            this.DataGridViewFindVehicle.ReadOnly = true;
            this.DataGridViewFindVehicle.RowTemplate.Height = 25;
            this.DataGridViewFindVehicle.Size = new System.Drawing.Size(547, 291);
            this.DataGridViewFindVehicle.TabIndex = 2;
            // 
            // DataGridViewCount
            // 
            this.DataGridViewCount.HeaderText = "Номер";
            this.DataGridViewCount.Name = "DataGridViewCount";
            this.DataGridViewCount.ReadOnly = true;
            // 
            // DataGridViewName
            // 
            this.DataGridViewName.HeaderText = "Название";
            this.DataGridViewName.Name = "DataGridViewName";
            this.DataGridViewName.ReadOnly = true;
            // 
            // DataGridViewEngineCapacity
            // 
            this.DataGridViewEngineCapacity.HeaderText = "Объем двигателя";
            this.DataGridViewEngineCapacity.Name = "DataGridViewEngineCapacity";
            this.DataGridViewEngineCapacity.ReadOnly = true;
            // 
            // DataGridViewFuelConsumption
            // 
            this.DataGridViewFuelConsumption.HeaderText = "Объем бака";
            this.DataGridViewFuelConsumption.Name = "DataGridViewFuelConsumption";
            this.DataGridViewFuelConsumption.ReadOnly = true;
            // 
            // DataGridViewCalc
            // 
            this.DataGridViewCalc.HeaderText = "Расход на 100 км";
            this.DataGridViewCalc.Name = "DataGridViewCalc";
            this.DataGridViewCalc.ReadOnly = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 37);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(223, 23);
            this.NameTextBox.TabIndex = 3;
            // 
            // EngineCopacityMinTextBox
            // 
            this.EngineCopacityMinTextBox.Location = new System.Drawing.Point(12, 103);
            this.EngineCopacityMinTextBox.Name = "EngineCopacityMinTextBox";
            this.EngineCopacityMinTextBox.Size = new System.Drawing.Size(49, 23);
            this.EngineCopacityMinTextBox.TabIndex = 4;
            // 
            // EngineCopacityMaxTextBox
            // 
            this.EngineCopacityMaxTextBox.Location = new System.Drawing.Point(184, 103);
            this.EngineCopacityMaxTextBox.Name = "EngineCopacityMaxTextBox";
            this.EngineCopacityMaxTextBox.Size = new System.Drawing.Size(51, 23);
            this.EngineCopacityMaxTextBox.TabIndex = 5;
            // 
            // TankCopacityMinTextBox
            // 
            this.TankCopacityMinTextBox.Location = new System.Drawing.Point(12, 171);
            this.TankCopacityMinTextBox.Name = "TankCopacityMinTextBox";
            this.TankCopacityMinTextBox.Size = new System.Drawing.Size(49, 23);
            this.TankCopacityMinTextBox.TabIndex = 6;
            // 
            // TankCopacityMaxTextBox
            // 
            this.TankCopacityMaxTextBox.Location = new System.Drawing.Point(184, 171);
            this.TankCopacityMaxTextBox.Name = "TankCopacityMaxTextBox";
            this.TankCopacityMaxTextBox.Size = new System.Drawing.Size(51, 23);
            this.TankCopacityMaxTextBox.TabIndex = 7;
            // 
            // FuelConsumptionMinTextBox
            // 
            this.FuelConsumptionMinTextBox.Location = new System.Drawing.Point(11, 240);
            this.FuelConsumptionMinTextBox.Name = "FuelConsumptionMinTextBox";
            this.FuelConsumptionMinTextBox.Size = new System.Drawing.Size(49, 23);
            this.FuelConsumptionMinTextBox.TabIndex = 8;
            // 
            // FuelConsumptionMaxTextBox
            // 
            this.FuelConsumptionMaxTextBox.Location = new System.Drawing.Point(183, 240);
            this.FuelConsumptionMaxTextBox.Name = "FuelConsumptionMaxTextBox";
            this.FuelConsumptionMaxTextBox.Size = new System.Drawing.Size(51, 23);
            this.FuelConsumptionMaxTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Объем двигателя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Минимум";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Максимум";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Максимум";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Минимум";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Объем бака";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Максимум";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Минимум";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Расход на 100 км";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(12, 269);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(223, 23);
            this.FindButton.TabIndex = 22;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(15, 299);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(219, 23);
            this.RefreshButton.TabIndex = 23;
            this.RefreshButton.Text = "Сбросить фильтр";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FuelConsumptionMaxTextBox);
            this.Controls.Add(this.FuelConsumptionMinTextBox);
            this.Controls.Add(this.TankCopacityMaxTextBox);
            this.Controls.Add(this.TankCopacityMinTextBox);
            this.Controls.Add(this.EngineCopacityMaxTextBox);
            this.Controls.Add(this.EngineCopacityMinTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DataGridViewFindVehicle);
            this.Name = "FindForm";
            this.Text = "FindForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFindVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DataGridViewFindVehicle;
        private DataGridViewTextBoxColumn DataGridViewCount;
        private DataGridViewTextBoxColumn DataGridViewName;
        private DataGridViewTextBoxColumn DataGridViewEngineCapacity;
        private DataGridViewTextBoxColumn DataGridViewFuelConsumption;
        private DataGridViewTextBoxColumn DataGridViewCalc;
        private TextBox NameTextBox;
        private TextBox EngineCopacityMinTextBox;
        private TextBox EngineCopacityMaxTextBox;
        private TextBox TankCopacityMinTextBox;
        private TextBox TankCopacityMaxTextBox;
        private TextBox FuelConsumptionMinTextBox;
        private TextBox FuelConsumptionMaxTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button FindButton;
        private Button RefreshButton;
    }
}
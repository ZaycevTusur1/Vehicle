namespace VehicleView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridViewVehicle = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.DataGridViewCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewEngineCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewFuelConsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCalc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = " Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGridViewVehicle
            // 
            this.DataGridViewVehicle.AllowUserToAddRows = false;
            this.DataGridViewVehicle.AllowUserToDeleteRows = false;
            this.DataGridViewVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCount,
            this.DataGridViewName,
            this.DataGridViewEngineCapacity,
            this.DataGridViewFuelConsumption,
            this.DataGridViewCalc});
            this.DataGridViewVehicle.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewVehicle.Name = "DataGridViewVehicle";
            this.DataGridViewVehicle.ReadOnly = true;
            this.DataGridViewVehicle.RowTemplate.Height = 25;
            this.DataGridViewVehicle.Size = new System.Drawing.Size(547, 291);
            this.DataGridViewVehicle.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(596, 118);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(144, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(596, 147);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(144, 23);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(596, 41);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(144, 23);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(596, 280);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(144, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 318);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DataGridViewVehicle);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private DataGridView DataGridViewVehicle;
        private Button SaveButton;
        private Button OpenButton;
        private Button FindButton;
        private Button RemoveButton;
        private DataGridViewTextBoxColumn DataGridViewCount;
        private DataGridViewTextBoxColumn DataGridViewName;
        private DataGridViewTextBoxColumn DataGridViewEngineCapacity;
        private DataGridViewTextBoxColumn DataGridViewFuelConsumption;
        private DataGridViewTextBoxColumn DataGridViewCalc;
    }
}
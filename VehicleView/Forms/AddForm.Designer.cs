namespace VehicleView.Forms
{
    partial class AddForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.GenereteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTexBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EngineCapacityTExtBox = new System.Windows.Forms.TextBox();
            this.FuelConsumptionLabel = new System.Windows.Forms.Label();
            this.FuelConsumptionTextBox = new System.Windows.Forms.TextBox();
            this.TankCapacityLabel = new System.Windows.Forms.Label();
            this.BatteryCopacityLabel = new System.Windows.Forms.Label();
            this.BatteryCopacityTextBox = new System.Windows.Forms.TextBox();
            this.PowerHeliLabel = new System.Windows.Forms.Label();
            this.PowerHeliTextBox = new System.Windows.Forms.TextBox();
            this.VehicleType = new System.Windows.Forms.ComboBox();
            this.TankCapacityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 415);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(252, 415);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GenereteButton
            // 
            this.GenereteButton.Location = new System.Drawing.Point(103, 415);
            this.GenereteButton.Name = "GenereteButton";
            this.GenereteButton.Size = new System.Drawing.Size(133, 23);
            this.GenereteButton.TabIndex = 2;
            this.GenereteButton.Text = "Случайный данные";
            this.GenereteButton.UseVisualStyleBackColor = true;
            this.GenereteButton.Click += new System.EventHandler(this.GenereteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // NameTexBox
            // 
            this.NameTexBox.Location = new System.Drawing.Point(148, 58);
            this.NameTexBox.Name = "NameTexBox";
            this.NameTexBox.Size = new System.Drawing.Size(149, 23);
            this.NameTexBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Объем двигателя";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EngineCapacityTExtBox
            // 
            this.EngineCapacityTExtBox.Location = new System.Drawing.Point(148, 87);
            this.EngineCapacityTExtBox.Name = "EngineCapacityTExtBox";
            this.EngineCapacityTExtBox.Size = new System.Drawing.Size(149, 23);
            this.EngineCapacityTExtBox.TabIndex = 6;
            // 
            // FuelConsumptionLabel
            // 
            this.FuelConsumptionLabel.AutoSize = true;
            this.FuelConsumptionLabel.Location = new System.Drawing.Point(12, 119);
            this.FuelConsumptionLabel.Name = "FuelConsumptionLabel";
            this.FuelConsumptionLabel.Size = new System.Drawing.Size(95, 15);
            this.FuelConsumptionLabel.TabIndex = 7;
            this.FuelConsumptionLabel.Text = "Базовый расход";
            this.FuelConsumptionLabel.Click += new System.EventHandler(this.FuelConsumptionLabel_Click);
            // 
            // FuelConsumptionTextBox
            // 
            this.FuelConsumptionTextBox.Location = new System.Drawing.Point(148, 116);
            this.FuelConsumptionTextBox.Name = "FuelConsumptionTextBox";
            this.FuelConsumptionTextBox.Size = new System.Drawing.Size(149, 23);
            this.FuelConsumptionTextBox.TabIndex = 8;
            // 
            // TankCapacityLabel
            // 
            this.TankCapacityLabel.AutoSize = true;
            this.TankCapacityLabel.Location = new System.Drawing.Point(12, 149);
            this.TankCapacityLabel.Name = "TankCapacityLabel";
            this.TankCapacityLabel.Size = new System.Drawing.Size(73, 15);
            this.TankCapacityLabel.TabIndex = 9;
            this.TankCapacityLabel.Text = "Объем бака";
            this.TankCapacityLabel.Click += new System.EventHandler(this.TankCapacityLabel_Click);
            // 
            // BatteryCopacityLabel
            // 
            this.BatteryCopacityLabel.AutoSize = true;
            this.BatteryCopacityLabel.Location = new System.Drawing.Point(12, 178);
            this.BatteryCopacityLabel.Name = "BatteryCopacityLabel";
            this.BatteryCopacityLabel.Size = new System.Drawing.Size(99, 15);
            this.BatteryCopacityLabel.TabIndex = 11;
            this.BatteryCopacityLabel.Text = "Емкость батареи";
            // 
            // BatteryCopacityTextBox
            // 
            this.BatteryCopacityTextBox.Location = new System.Drawing.Point(148, 175);
            this.BatteryCopacityTextBox.Name = "BatteryCopacityTextBox";
            this.BatteryCopacityTextBox.Size = new System.Drawing.Size(149, 23);
            this.BatteryCopacityTextBox.TabIndex = 12;
            // 
            // PowerHeliLabel
            // 
            this.PowerHeliLabel.AutoSize = true;
            this.PowerHeliLabel.Location = new System.Drawing.Point(12, 178);
            this.PowerHeliLabel.Name = "PowerHeliLabel";
            this.PowerHeliLabel.Size = new System.Drawing.Size(112, 15);
            this.PowerHeliLabel.TabIndex = 13;
            this.PowerHeliLabel.Text = "Мощность натдува";
            this.PowerHeliLabel.Click += new System.EventHandler(this.PowerHeliLabel_Click);
            // 
            // PowerHeliTextBox
            // 
            this.PowerHeliTextBox.Location = new System.Drawing.Point(148, 175);
            this.PowerHeliTextBox.Name = "PowerHeliTextBox";
            this.PowerHeliTextBox.Size = new System.Drawing.Size(149, 23);
            this.PowerHeliTextBox.TabIndex = 14;
            // 
            // VehicleType
            // 
            this.VehicleType.FormattingEnabled = true;
            this.VehicleType.Items.AddRange(new object[] {
            "Авто",
            "Гибрид",
            "Вертолет"});
            this.VehicleType.Location = new System.Drawing.Point(26, 12);
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Size = new System.Drawing.Size(252, 23);
            this.VehicleType.TabIndex = 15;
            this.VehicleType.SelectedIndexChanged += new System.EventHandler(this.VehicleType_SelectedIndexChanged);
            // 
            // TankCapacityTextBox
            // 
            this.TankCapacityTextBox.Location = new System.Drawing.Point(148, 146);
            this.TankCapacityTextBox.Name = "TankCapacityTextBox";
            this.TankCapacityTextBox.Size = new System.Drawing.Size(149, 23);
            this.TankCapacityTextBox.TabIndex = 10;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.VehicleType);
            this.Controls.Add(this.PowerHeliTextBox);
            this.Controls.Add(this.PowerHeliLabel);
            this.Controls.Add(this.BatteryCopacityTextBox);
            this.Controls.Add(this.BatteryCopacityLabel);
            this.Controls.Add(this.TankCapacityTextBox);
            this.Controls.Add(this.TankCapacityLabel);
            this.Controls.Add(this.FuelConsumptionTextBox);
            this.Controls.Add(this.FuelConsumptionLabel);
            this.Controls.Add(this.EngineCapacityTExtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTexBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenereteButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddButton);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddButton;
        private Button CloseButton;
        private Button GenereteButton;
        private Label label1;
        private TextBox NameTexBox;
        private Label label2;
        private TextBox EngineCapacityTExtBox;
        private Label FuelConsumptionLabel;
        private TextBox FuelConsumptionTextBox;
        private Label TankCapacityLabel;
        private Label BatteryCopacityLabel;
        private TextBox BatteryCopacityTextBox;
        private Label PowerHeliLabel;
        private TextBox PowerHeliTextBox;
        private ComboBox VehicleType;
        private TextBox TankCapacityTextBox;
    }
}
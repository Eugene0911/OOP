namespace Footwear
{
    partial class ShoesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bContinue = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lType = new System.Windows.Forms.Label();
            this.tPrice = new System.Windows.Forms.TextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.tMaterial = new System.Windows.Forms.TextBox();
            this.lMaterial = new System.Windows.Forms.Label();
            this.tProducer = new System.Windows.Forms.TextBox();
            this.lProducer = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bContinue
            // 
            this.bContinue.Location = new System.Drawing.Point(110, 278);
            this.bContinue.Name = "bContinue";
            this.bContinue.Size = new System.Drawing.Size(129, 36);
            this.bContinue.TabIndex = 51;
            this.bContinue.Text = "Save";
            this.bContinue.UseVisualStyleBackColor = true;
            this.bContinue.Click += new System.EventHandler(this.bContinue_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(177, 158);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 24);
            this.cbType.TabIndex = 50;
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(41, 157);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(37, 17);
            this.lType.TabIndex = 49;
            this.lType.Text = "Heel";
            // 
            // tPrice
            // 
            this.tPrice.Location = new System.Drawing.Point(177, 129);
            this.tPrice.Name = "tPrice";
            this.tPrice.Size = new System.Drawing.Size(120, 22);
            this.tPrice.TabIndex = 48;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(41, 129);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(40, 17);
            this.lPrice.TabIndex = 47;
            this.lPrice.Text = "Price";
            // 
            // tMaterial
            // 
            this.tMaterial.Location = new System.Drawing.Point(177, 101);
            this.tMaterial.Name = "tMaterial";
            this.tMaterial.Size = new System.Drawing.Size(120, 22);
            this.tMaterial.TabIndex = 44;
            // 
            // lMaterial
            // 
            this.lMaterial.AutoSize = true;
            this.lMaterial.Location = new System.Drawing.Point(41, 101);
            this.lMaterial.Name = "lMaterial";
            this.lMaterial.Size = new System.Drawing.Size(92, 17);
            this.lMaterial.TabIndex = 43;
            this.lMaterial.Text = "Main material";
            // 
            // tProducer
            // 
            this.tProducer.Location = new System.Drawing.Point(177, 73);
            this.tProducer.Name = "tProducer";
            this.tProducer.Size = new System.Drawing.Size(120, 22);
            this.tProducer.TabIndex = 42;
            // 
            // lProducer
            // 
            this.lProducer.AutoSize = true;
            this.lProducer.Location = new System.Drawing.Point(41, 73);
            this.lProducer.Name = "lProducer";
            this.lProducer.Size = new System.Drawing.Size(66, 17);
            this.lProducer.TabIndex = 41;
            this.lProducer.Text = "Producer";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(177, 45);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(120, 22);
            this.tName.TabIndex = 40;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(41, 45);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(45, 17);
            this.lName.TabIndex = 39;
            this.lName.Text = "Name";
            // 
            // ShoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 358);
            this.Controls.Add(this.bContinue);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.tPrice);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.tMaterial);
            this.Controls.Add(this.lMaterial);
            this.Controls.Add(this.tProducer);
            this.Controls.Add(this.lProducer);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.lName);
            this.Name = "ShoesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShoesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bContinue;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.TextBox tPrice;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.TextBox tMaterial;
        private System.Windows.Forms.Label lMaterial;
        private System.Windows.Forms.TextBox tProducer;
        private System.Windows.Forms.Label lProducer;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label lName;
    }
}


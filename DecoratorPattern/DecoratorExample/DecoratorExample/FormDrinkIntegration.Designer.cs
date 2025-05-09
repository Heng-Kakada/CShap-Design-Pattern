namespace DecoratorExample
{
    partial class FormDrinkIntegration
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
            txtResult = new TextBox();
            txtDrink = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            btnMix = new Button();
            cboIngredient = new ComboBox();
            label4 = new Label();
            txtWeight = new TextBox();
            label3 = new Label();
            txtMixName = new TextBox();
            label2 = new Label();
            btnActivate = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Enabled = false;
            txtResult.Location = new Point(75, 281);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(589, 233);
            txtResult.TabIndex = 0;
            // 
            // txtDrink
            // 
            txtDrink.Enabled = false;
            txtDrink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDrink.Location = new Point(250, 31);
            txtDrink.Name = "txtDrink";
            txtDrink.Size = new Size(376, 29);
            txtDrink.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 33);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 2;
            label1.Text = "Drink Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnMix);
            groupBox1.Controls.Add(cboIngredient);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtWeight);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMixName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtResult);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(99, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(744, 536);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mixing Drinks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(75, 255);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 11;
            label5.Text = "Result";
            // 
            // btnMix
            // 
            btnMix.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMix.Location = new Point(469, 186);
            btnMix.Name = "btnMix";
            btnMix.Size = new Size(92, 36);
            btnMix.TabIndex = 5;
            btnMix.Text = "Mix";
            btnMix.UseVisualStyleBackColor = true;
            btnMix.Visible = false;
            // 
            // cboIngredient
            // 
            cboIngredient.Enabled = false;
            cboIngredient.FormattingEnabled = true;
            cboIngredient.Location = new Point(222, 61);
            cboIngredient.Name = "cboIngredient";
            cboIngredient.Size = new Size(236, 29);
            cboIngredient.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 193);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 9;
            label4.Text = "Weights (GS)";
            // 
            // txtWeight
            // 
            txtWeight.Enabled = false;
            txtWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWeight.Location = new Point(222, 191);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(144, 29);
            txtWeight.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 128);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 7;
            label3.Text = "Mixing Name";
            // 
            // txtMixName
            // 
            txtMixName.Enabled = false;
            txtMixName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMixName.Location = new Point(222, 126);
            txtMixName.Name = "txtMixName";
            txtMixName.Size = new Size(376, 29);
            txtMixName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 61);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 5;
            label2.Text = "Ingredient";
            // 
            // btnActivate
            // 
            btnActivate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActivate.Location = new Point(713, 26);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(101, 36);
            btnActivate.TabIndex = 4;
            btnActivate.Text = "Activate";
            btnActivate.UseVisualStyleBackColor = true;
            // 
            // FormDrinkIntegration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 690);
            Controls.Add(btnActivate);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(txtDrink);
            Name = "FormDrinkIntegration";
            Text = "Form1";
            Load += FormDrinkIntegration_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private TextBox txtDrink;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnMix;
        private ComboBox cboIngredient;
        private Label label4;
        private TextBox txtWeight;
        private Label label3;
        private TextBox txtMixName;
        private Label label2;
        private Button btnActivate;
        private Label label5;
    }
}

namespace PjPoligonos
{
    partial class FigBiTriangulo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtLado1 = new TextBox();
            txtLado2 = new TextBox();
            txtLado3 = new TextBox();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cboOpcion = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(312, 139);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Lado1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(423, 139);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Lado2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(536, 139);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Lado3";
            // 
            // txtLado1
            // 
            txtLado1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLado1.Location = new Point(299, 168);
            txtLado1.Margin = new Padding(3, 4, 3, 4);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(85, 30);
            txtLado1.TabIndex = 3;
            // 
            // txtLado2
            // 
            txtLado2.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLado2.Location = new Point(410, 168);
            txtLado2.Margin = new Padding(3, 4, 3, 4);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(85, 30);
            txtLado2.TabIndex = 4;
            // 
            // txtLado3
            // 
            txtLado3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLado3.Location = new Point(523, 168);
            txtLado3.Margin = new Padding(3, 4, 3, 4);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(85, 30);
            txtLado3.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.DarkKhaki;
            btnCalcular.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(267, 243);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 53);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.Location = new Point(196, 370);
            txtResultado.Margin = new Padding(3, 4, 3, 4);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(257, 30);
            txtResultado.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(271, 346);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 8;
            label4.Text = "Resultado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT Condensed Extra Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(205, 63);
            label5.Name = "label5";
            label5.Size = new Size(234, 40);
            label5.TabIndex = 9;
            label5.Text = "Ingrese los datos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(243, 16);
            label6.Name = "label6";
            label6.Size = new Size(155, 47);
            label6.TabIndex = 10;
            label6.Text = "Triángulo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 140);
            label7.Name = "label7";
            label7.Size = new Size(229, 20);
            label7.TabIndex = 17;
            label7.Text = "¿Qué Desea Calcular?";
            // 
            // cboOpcion
            // 
            cboOpcion.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboOpcion.FormattingEnabled = true;
            cboOpcion.Items.AddRange(new object[] { "Área", "Perímetro" });
            cboOpcion.Location = new Point(76, 169);
            cboOpcion.Margin = new Padding(3, 4, 3, 4);
            cboOpcion.Name = "cboOpcion";
            cboOpcion.Size = new Size(138, 28);
            cboOpcion.TabIndex = 16;
            // 
            // FigBiTriangulo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(637, 443);
            Controls.Add(label7);
            Controls.Add(cboOpcion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtLado3);
            Controls.Add(txtLado2);
            Controls.Add(txtLado1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FigBiTriangulo";
            Text = "FigBiTriangulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLado1;
        private TextBox txtLado2;
        private TextBox txtLado3;
        private Button btnCalcular;
        private TextBox txtResultado;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cboOpcion;
    }
}
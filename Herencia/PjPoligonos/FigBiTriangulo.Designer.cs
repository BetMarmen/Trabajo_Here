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
            label1.Location = new Point(195, 177);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 177);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Lado2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 177);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Lado3";
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(195, 195);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(75, 23);
            txtLado1.TabIndex = 3;
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(292, 195);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(75, 23);
            txtLado2.TabIndex = 4;
            // 
            // txtLado3
            // 
            txtLado3.Location = new Point(391, 195);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(75, 23);
            txtLado3.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(230, 256);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(142, 325);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(225, 23);
            txtResultado.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 297);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "Resultado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 137);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 9;
            label5.Text = "Ingrese los datos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 45);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 10;
            label6.Text = "Triángulo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 177);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 17;
            label7.Text = "¿Qué Desea Calcular?";
            // 
            // cboOpcion
            // 
            cboOpcion.FormattingEnabled = true;
            cboOpcion.Items.AddRange(new object[] { "Área", "Perímetro" });
            cboOpcion.Location = new Point(48, 195);
            cboOpcion.Name = "cboOpcion";
            cboOpcion.Size = new Size(121, 23);
            cboOpcion.TabIndex = 16;
            // 
            // FigBiTriangulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 450);
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
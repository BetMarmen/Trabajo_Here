namespace PjPoligonos
{
    partial class FigTridimencionales
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
            tntCalcular = new Button();
            label5 = new Label();
            txtLado = new TextBox();
            txtDiametro = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboFigura = new ComboBox();
            cboOpcion = new ComboBox();
            label7 = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // tntCalcular
            // 
            tntCalcular.BackColor = Color.FromArgb(255, 192, 192);
            tntCalcular.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tntCalcular.Location = new Point(261, 184);
            tntCalcular.Margin = new Padding(3, 4, 3, 4);
            tntCalcular.Name = "tntCalcular";
            tntCalcular.Size = new Size(126, 44);
            tntCalcular.TabIndex = 23;
            tntCalcular.Text = "Calcular";
            tntCalcular.UseVisualStyleBackColor = false;
            tntCalcular.Click += tntCalcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(423, 258);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 20;
            label5.Text = "Ingrese el Lado";
            // 
            // txtLado
            // 
            txtLado.Enabled = false;
            txtLado.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLado.Location = new Point(447, 287);
            txtLado.Margin = new Padding(3, 4, 3, 4);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(114, 30);
            txtLado.TabIndex = 19;
            // 
            // txtDiametro
            // 
            txtDiametro.Enabled = false;
            txtDiametro.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiametro.Location = new Point(88, 287);
            txtDiametro.Margin = new Padding(3, 4, 3, 4);
            txtDiametro.Name = "txtDiametro";
            txtDiametro.Size = new Size(114, 30);
            txtDiametro.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 258);
            label4.Name = "label4";
            label4.Size = new Size(218, 20);
            label4.TabIndex = 17;
            label4.Text = "Ingrese el Diametro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(389, 113);
            label3.Name = "label3";
            label3.Size = new Size(240, 20);
            label3.TabIndex = 16;
            label3.Text = "Seleccione una figura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 113);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 15;
            label2.Text = "¿Qué Desea Calcular?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(189, 19);
            label1.Name = "label1";
            label1.Size = new Size(325, 47);
            label1.TabIndex = 14;
            label1.Text = "Seleccione una Opción";
            // 
            // cboFigura
            // 
            cboFigura.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboFigura.FormattingEnabled = true;
            cboFigura.Items.AddRange(new object[] { "Esfera", "Cubo", "Tetraedro" });
            cboFigura.Location = new Point(423, 142);
            cboFigura.Margin = new Padding(3, 4, 3, 4);
            cboFigura.Name = "cboFigura";
            cboFigura.Size = new Size(138, 28);
            cboFigura.TabIndex = 13;
            cboFigura.SelectedIndexChanged += cboFigura_SelectedIndexChanged_2;
            // 
            // cboOpcion
            // 
            cboOpcion.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboOpcion.FormattingEnabled = true;
            cboOpcion.Items.AddRange(new object[] { "Área", "Volumen" });
            cboOpcion.Location = new Point(88, 142);
            cboOpcion.Margin = new Padding(3, 4, 3, 4);
            cboOpcion.Name = "cboOpcion";
            cboOpcion.Size = new Size(138, 28);
            cboOpcion.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(261, 356);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 24;
            label7.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.Location = new Point(209, 385);
            txtResultado.Margin = new Padding(3, 4, 3, 4);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(199, 30);
            txtResultado.TabIndex = 25;
            // 
            // FigTridimencionales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(641, 478);
            Controls.Add(txtResultado);
            Controls.Add(label7);
            Controls.Add(tntCalcular);
            Controls.Add(label5);
            Controls.Add(txtLado);
            Controls.Add(txtDiametro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboFigura);
            Controls.Add(cboOpcion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FigTridimencionales";
            Text = "FigTridimencionales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tntCalcular;
        private Label label5;
        private TextBox txtLado;
        private TextBox txtDiametro;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboFigura;
        private ComboBox cboOpcion;
        private Label label7;
        private TextBox txtResultado;
    }
}
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
            tntCalcular.Location = new Point(260, 188);
            tntCalcular.Name = "tntCalcular";
            tntCalcular.Size = new Size(75, 23);
            tntCalcular.TabIndex = 23;
            tntCalcular.Text = "Calcular";
            tntCalcular.UseVisualStyleBackColor = true;
            tntCalcular.Click += tntCalcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 248);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 20;
            label5.Text = "Ingrese el Lado";
            // 
            // txtLado
            // 
            txtLado.Enabled = false;
            txtLado.Location = new Point(320, 266);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(100, 23);
            txtLado.TabIndex = 19;
            // 
            // txtDiametro
            // 
            txtDiametro.Enabled = false;
            txtDiametro.Location = new Point(165, 266);
            txtDiametro.Name = "txtDiametro";
            txtDiametro.Size = new Size(100, 23);
            txtDiametro.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 248);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 17;
            label4.Text = "Ingrese el Diametro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(364, 123);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 16;
            label3.Text = "Seleccione una figura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 123);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 15;
            label2.Text = "¿Qué Desea Calcular?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(188, 81);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 14;
            label1.Text = "Seleccione una Opción";
            // 
            // cboFigura
            // 
            cboFigura.FormattingEnabled = true;
            cboFigura.Items.AddRange(new object[] { "Esfera", "Cubo", "Tetraedro" });
            cboFigura.Location = new Point(363, 141);
            cboFigura.Name = "cboFigura";
            cboFigura.Size = new Size(121, 23);
            cboFigura.TabIndex = 13;
            cboFigura.SelectedIndexChanged += cboFigura_SelectedIndexChanged_2;
            // 
            // cboOpcion
            // 
            cboOpcion.FormattingEnabled = true;
            cboOpcion.Items.AddRange(new object[] { "Área", "Volumen" });
            cboOpcion.Location = new Point(70, 141);
            cboOpcion.Name = "cboOpcion";
            cboOpcion.Size = new Size(121, 23);
            cboOpcion.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 324);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 24;
            label7.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(200, 342);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(175, 23);
            txtResultado.TabIndex = 25;
            // 
            // FigTridimencionales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 450);
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
namespace PjPoligonos
{
    partial class FigBidimencionales
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
            cboOpcion = new ComboBox();
            cboFigura = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDiametro = new TextBox();
            txtBase = new TextBox();
            label5 = new Label();
            tntCalcular = new Button();
            txtResultado = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // cboOpcion
            // 
            cboOpcion.FormattingEnabled = true;
            cboOpcion.Items.AddRange(new object[] { "Área", "Perímetro" });
            cboOpcion.Location = new Point(57, 139);
            cboOpcion.Name = "cboOpcion";
            cboOpcion.Size = new Size(121, 23);
            cboOpcion.TabIndex = 0;
            // 
            // cboFigura
            // 
            cboFigura.FormattingEnabled = true;
            cboFigura.Items.AddRange(new object[] { "Circulo", "Triángulo", "Cuadrado" });
            cboFigura.Location = new Point(350, 139);
            cboFigura.Name = "cboFigura";
            cboFigura.Size = new Size(121, 23);
            cboFigura.TabIndex = 1;
            cboFigura.SelectedIndexChanged += cboFigura_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(175, 79);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 2;
            label1.Text = "Seleccione una Opción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 121);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 3;
            label2.Text = "¿Qué Desea Calcular?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 121);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 4;
            label3.Text = "Seleccione una figura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 242);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 5;
            label4.Text = "Ingrese el Diametro";
            // 
            // txtDiametro
            // 
            txtDiametro.Enabled = false;
            txtDiametro.Location = new Point(162, 260);
            txtDiametro.Name = "txtDiametro";
            txtDiametro.Size = new Size(100, 23);
            txtDiametro.TabIndex = 6;
            // 
            // txtBase
            // 
            txtBase.Enabled = false;
            txtBase.Location = new Point(317, 260);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 242);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 8;
            label5.Text = "Ingrese la Base";
            // 
            // tntCalcular
            // 
            tntCalcular.Location = new Point(247, 186);
            tntCalcular.Name = "tntCalcular";
            tntCalcular.Size = new Size(75, 23);
            tntCalcular.TabIndex = 11;
            tntCalcular.Text = "Calcular";
            tntCalcular.UseVisualStyleBackColor = true;
            tntCalcular.Click += tntCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(212, 331);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(175, 23);
            txtResultado.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(263, 313);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 26;
            label7.Text = "Resultado";
            // 
            // FigBidimencionales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 450);
            Controls.Add(txtResultado);
            Controls.Add(label7);
            Controls.Add(tntCalcular);
            Controls.Add(label5);
            Controls.Add(txtBase);
            Controls.Add(txtDiametro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboFigura);
            Controls.Add(cboOpcion);
            Name = "FigBidimencionales";
            Text = "FigBidimencionales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboOpcion;
        private ComboBox cboFigura;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDiametro;
        private TextBox txtBase;
        private Label label5;
        private Button tntCalcular;
        private TextBox txtResultado;
        private Label label7;
    }
}
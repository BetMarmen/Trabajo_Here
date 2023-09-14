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
            cboOpcion.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboOpcion.FormattingEnabled = true;
            cboOpcion.Items.AddRange(new object[] { "Área", "Perímetro" });
            cboOpcion.Location = new Point(83, 167);
            cboOpcion.Margin = new Padding(3, 4, 3, 4);
            cboOpcion.Name = "cboOpcion";
            cboOpcion.Size = new Size(138, 28);
            cboOpcion.TabIndex = 0;
            // 
            // cboFigura
            // 
            cboFigura.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cboFigura.FormattingEnabled = true;
            cboFigura.Items.AddRange(new object[] { "Circulo", "Triángulo", "Cuadrado" });
            cboFigura.Location = new Point(453, 168);
            cboFigura.Margin = new Padding(3, 4, 3, 4);
            cboFigura.Name = "cboFigura";
            cboFigura.Size = new Size(138, 28);
            cboFigura.TabIndex = 1;
            cboFigura.SelectedIndexChanged += cboFigura_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 32);
            label1.Name = "label1";
            label1.Size = new Size(325, 47);
            label1.TabIndex = 2;
            label1.Text = "Seleccione una Opción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 138);
            label2.Name = "label2";
            label2.Size = new Size(229, 20);
            label2.TabIndex = 3;
            label2.Text = "¿Qué Desea Calcular?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(406, 139);
            label3.Name = "label3";
            label3.Size = new Size(240, 20);
            label3.TabIndex = 4;
            label3.Text = "Seleccione una figura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(52, 334);
            label4.Name = "label4";
            label4.Size = new Size(218, 20);
            label4.TabIndex = 5;
            label4.Text = "Ingrese el Diametro";
            // 
            // txtDiametro
            // 
            txtDiametro.Enabled = false;
            txtDiametro.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiametro.Location = new Point(97, 362);
            txtDiametro.Margin = new Padding(3, 4, 3, 4);
            txtDiametro.Name = "txtDiametro";
            txtDiametro.Size = new Size(114, 30);
            txtDiametro.TabIndex = 6;
            // 
            // txtBase
            // 
            txtBase.Enabled = false;
            txtBase.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBase.Location = new Point(436, 363);
            txtBase.Margin = new Padding(3, 4, 3, 4);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(114, 30);
            txtBase.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(406, 334);
            label5.Name = "label5";
            label5.Size = new Size(174, 20);
            label5.TabIndex = 8;
            label5.Text = "Ingrese la Base";
            // 
            // tntCalcular
            // 
            tntCalcular.BackColor = Color.Plum;
            tntCalcular.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tntCalcular.Location = new Point(266, 225);
            tntCalcular.Margin = new Padding(3, 4, 3, 4);
            tntCalcular.Name = "tntCalcular";
            tntCalcular.Size = new Size(127, 54);
            tntCalcular.TabIndex = 11;
            tntCalcular.Text = "Calcular";
            tntCalcular.UseVisualStyleBackColor = false;
            tntCalcular.Click += tntCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.Location = new Point(231, 473);
            txtResultado.Margin = new Padding(3, 4, 3, 4);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(199, 30);
            txtResultado.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(282, 444);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 26;
            label7.Text = "Resultado";
            // 
            // FigBidimencionales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(683, 541);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "FigBidimencionales";
            Text = "FigBidimencionales";
            Load += FigBidimencionales_Load;
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
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
            this.tntCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFigura = new System.Windows.Forms.ComboBox();
            this.cboOpcion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tntCalcular
            // 
            this.tntCalcular.Location = new System.Drawing.Point(297, 251);
            this.tntCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tntCalcular.Name = "tntCalcular";
            this.tntCalcular.Size = new System.Drawing.Size(86, 31);
            this.tntCalcular.TabIndex = 23;
            this.tntCalcular.Text = "Calcular";
            this.tntCalcular.UseVisualStyleBackColor = true;
            this.tntCalcular.Click += new System.EventHandler(this.tntCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ingrese el Lado";
            // 
            // txtLado
            // 
            this.txtLado.Enabled = false;
            this.txtLado.Location = new System.Drawing.Point(287, 353);
            this.txtLado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(114, 27);
            this.txtLado.TabIndex = 19;
            // 
            // txtDiametro
            // 
            this.txtDiametro.Enabled = false;
            this.txtDiametro.Location = new System.Drawing.Point(110, 353);
            this.txtDiametro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(114, 27);
            this.txtDiametro.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ingrese el Diametro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Seleccione una figura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "¿Qué Desea Calcular?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(215, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seleccione una Opción";
            // 
            // cboFigura
            // 
            this.cboFigura.FormattingEnabled = true;
            this.cboFigura.Items.AddRange(new object[] {
            "Esfera",
            "Cubo",
            "Tetraedro"});
            this.cboFigura.Location = new System.Drawing.Point(415, 188);
            this.cboFigura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboFigura.Name = "cboFigura";
            this.cboFigura.Size = new System.Drawing.Size(138, 28);
            this.cboFigura.TabIndex = 13;
            this.cboFigura.SelectedIndexChanged += new System.EventHandler(this.cboFigura_SelectedIndexChanged_2);
            // 
            // cboOpcion
            // 
            this.cboOpcion.FormattingEnabled = true;
            this.cboOpcion.Items.AddRange(new object[] {
            "Área",
            "Volumen"});
            this.cboOpcion.Location = new System.Drawing.Point(80, 188);
            this.cboOpcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboOpcion.Name = "cboOpcion";
            this.cboOpcion.Size = new System.Drawing.Size(138, 28);
            this.cboOpcion.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(229, 456);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(199, 27);
            this.txtResultado.TabIndex = 25;
            // 
            // FigTridimencionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 600);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tntCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.txtDiametro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFigura);
            this.Controls.Add(this.cboOpcion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FigTridimencionales";
            this.Text = "FigTridimencionales";
            this.ResumeLayout(false);
            this.PerformLayout();

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
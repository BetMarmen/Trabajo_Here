namespace PjPoligonos
{
    partial class Seleccionar
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
            btnFigBi = new Button();
            btnFigTri = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnFigBi
            // 
            btnFigBi.Location = new Point(54, 207);
            btnFigBi.Name = "btnFigBi";
            btnFigBi.Size = new Size(178, 53);
            btnFigBi.TabIndex = 0;
            btnFigBi.Text = "Figuras Bidimencionales";
            btnFigBi.UseVisualStyleBackColor = true;
            btnFigBi.Click += btnFigBi_Click;
            // 
            // btnFigTri
            // 
            btnFigTri.Location = new Point(357, 207);
            btnFigTri.Name = "btnFigTri";
            btnFigTri.Size = new Size(178, 53);
            btnFigTri.TabIndex = 1;
            btnFigTri.Text = "Figuras Tridimencionales";
            btnFigTri.UseVisualStyleBackColor = true;
            btnFigTri.Click += btnFigTri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 72);
            label1.Name = "label1";
            label1.Size = new Size(233, 30);
            label1.TabIndex = 2;
            label1.Text = "Seleccione una opción";
            // 
            // Seleccionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 450);
            Controls.Add(label1);
            Controls.Add(btnFigTri);
            Controls.Add(btnFigBi);
            Name = "Seleccionar";
            Text = "Seleccionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFigBi;
        private Button btnFigTri;
        private Label label1;
    }
}
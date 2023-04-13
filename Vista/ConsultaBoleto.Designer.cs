namespace Vista
{
    partial class ConsultaBoleto
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
            usuario = new Label();
            panel1 = new Panel();
            tabla = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(124, 22);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 0;
            label1.Text = "Consultar Boletos";
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usuario.Location = new Point(477, 31);
            usuario.Name = "usuario";
            usuario.Size = new Size(54, 21);
            usuario.TabIndex = 1;
            usuario.Text = "label2";
            // 
            // panel1
            // 
            panel1.Controls.Add(tabla);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(usuario);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 447);
            panel1.TabIndex = 2;
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Location = new Point(3, 78);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(806, 366);
            tabla.TabIndex = 2;
            // 
            // ConsultaBoleto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 471);
            Controls.Add(panel1);
            Name = "ConsultaBoleto";
            Text = "Consultar Boletos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label usuario;
        private Panel panel1;
        private DataGridView tabla;
    }
}
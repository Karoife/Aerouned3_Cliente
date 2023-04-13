namespace Vista
{
    partial class Principal
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
            panel1 = new Panel();
            btnDesconectar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnConsultar = new Button();
            btnComprar = new Button();
            labelUsuario = new Label();
            btnConectar = new Button();
            txtID = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDesconectar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnConectar);
            panel1.Controls.Add(txtID);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 199);
            panel1.TabIndex = 0;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(314, 37);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(81, 23);
            btnDesconectar.TabIndex = 4;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 39);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 3;
            label1.Text = "ID Cliente:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnComprar);
            groupBox1.Controls.Add(labelUsuario);
            groupBox1.Location = new Point(44, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 102);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Boleto";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(189, 47);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(49, 47);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(75, 23);
            btnComprar.TabIndex = 1;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(217, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(47, 15);
            labelUsuario.TabIndex = 0;
            labelUsuario.Text = "Usuario";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(233, 37);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 1;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(118, 40);
            txtID.MaxLength = 12;
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 223);
            Controls.Add(panel1);
            Name = "Principal";
            Text = "Cliente Aerouned 3.0";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnConsultar;
        private Button btnComprar;
        private Label labelUsuario;
        private Button btnConectar;
        private TextBox txtID;
        private Button btnDesconectar;
    }
}
namespace Vista
{
    partial class ComBoleto
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
            panel1 = new Panel();
            labelVuelo = new Label();
            tabla = new DataGridView();
            labelAsientos = new Label();
            label5 = new Label();
            numAsientos = new NumericUpDown();
            cmbVuelo = new ComboBox();
            txtNumero = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            labelUsuario = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnComprar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAsientos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelVuelo);
            panel1.Controls.Add(tabla);
            panel1.Controls.Add(labelAsientos);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(numAsientos);
            panel1.Controls.Add(cmbVuelo);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnComprar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 412);
            panel1.TabIndex = 0;
            // 
            // labelVuelo
            // 
            labelVuelo.AutoSize = true;
            labelVuelo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelVuelo.Location = new Point(292, 84);
            labelVuelo.Name = "labelVuelo";
            labelVuelo.Size = new Size(49, 20);
            labelVuelo.TabIndex = 13;
            labelVuelo.Text = "Vuelo";
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Location = new Point(272, 107);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(274, 150);
            tabla.TabIndex = 12;
            // 
            // labelAsientos
            // 
            labelAsientos.AutoSize = true;
            labelAsientos.Location = new Point(177, 198);
            labelAsientos.Name = "labelAsientos";
            labelAsientos.Size = new Size(13, 15);
            labelAsientos.TabIndex = 11;
            labelAsientos.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 198);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 10;
            label5.Text = "Disponibles:";
            // 
            // numAsientos
            // 
            numAsientos.Location = new Point(109, 216);
            numAsientos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAsientos.Name = "numAsientos";
            numAsientos.Size = new Size(120, 23);
            numAsientos.TabIndex = 9;
            numAsientos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbVuelo
            // 
            cmbVuelo.FormattingEnabled = true;
            cmbVuelo.Location = new Point(109, 159);
            cmbVuelo.Name = "cmbVuelo";
            cmbVuelo.Size = new Size(120, 23);
            cmbVuelo.TabIndex = 8;
            cmbVuelo.SelectedValueChanged += cmbVuelo_SelectedValueChanged;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(109, 109);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(120, 23);
            txtNumero.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 216);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 6;
            label4.Text = "Asientos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 159);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 5;
            label3.Text = "Vuelo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 107);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 4;
            label2.Text = "Número:";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.Location = new Point(252, 53);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(62, 20);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 21);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 2;
            label1.Text = "Comprar Boleto";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(177, 281);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(38, 281);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(75, 23);
            btnComprar.TabIndex = 0;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // ComBoleto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 436);
            Controls.Add(panel1);
            Name = "ComBoleto";
            Text = "Comprar Boleto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAsientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnComprar;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label labelUsuario;
        private DataGridView tabla;
        private Label labelAsientos;
        private Label label5;
        private NumericUpDown numAsientos;
        private ComboBox cmbVuelo;
        private TextBox txtNumero;
        private Label label4;
        private Label labelVuelo;
    }
}
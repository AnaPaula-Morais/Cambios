namespace Cambios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBoxValor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxOrigem = new ComboBox();
            comboBoxDestino = new ComboBox();
            buttonConverter = new Button();
            labelResultado = new Label();
            labelStatus = new Label();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            btnTroca = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 186, 115);
            label1.Location = new Point(51, 129);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // textBoxValor
            // 
            textBoxValor.BorderStyle = BorderStyle.FixedSingle;
            textBoxValor.Location = new Point(133, 129);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(405, 31);
            textBoxValor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(10, 186, 115);
            label2.Location = new Point(51, 271);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 2;
            label2.Text = "Moeda de destino:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(10, 186, 115);
            label3.Location = new Point(51, 208);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 3;
            label3.Text = "Moeda de origem:";
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.FlatStyle = FlatStyle.Flat;
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(233, 208);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(305, 33);
            comboBoxOrigem.TabIndex = 4;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FlatStyle = FlatStyle.Flat;
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(234, 271);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(304, 33);
            comboBoxDestino.TabIndex = 5;
            // 
            // buttonConverter
            // 
            buttonConverter.BackColor = Color.DarkCyan;
            buttonConverter.Enabled = false;
            buttonConverter.FlatAppearance.BorderSize = 0;
            buttonConverter.FlatStyle = FlatStyle.Flat;
            buttonConverter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConverter.ForeColor = Color.White;
            buttonConverter.Location = new Point(598, 118);
            buttonConverter.Name = "buttonConverter";
            buttonConverter.Size = new Size(136, 51);
            buttonConverter.TabIndex = 6;
            buttonConverter.Text = "Converter";
            buttonConverter.UseVisualStyleBackColor = false;
            buttonConverter.Click += buttonConverter_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.ForeColor = Color.FromArgb(10, 186, 115);
            labelResultado.Location = new Point(234, 338);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(397, 25);
            labelResultado.TabIndex = 7;
            labelResultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(61, 429);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(60, 25);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Status";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(565, 464);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(200, 34);
            progressBar1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(33, 43, 54);
            label4.Location = new Point(249, 31);
            label4.Name = "label4";
            label4.Size = new Size(300, 38);
            label4.TabIndex = 10;
            label4.Text = "Conversor de Moedas";
            // 
            // btnTroca
            // 
            btnTroca.BackColor = Color.DarkCyan;
            btnTroca.Enabled = false;
            btnTroca.Image = (Image)resources.GetObject("btnTroca.Image");
            btnTroca.Location = new Point(565, 225);
            btnTroca.Name = "btnTroca";
            btnTroca.Size = new Size(72, 62);
            btnTroca.TabIndex = 11;
            btnTroca.UseVisualStyleBackColor = false;
            btnTroca.Click += btnTroca_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(800, 555);
            Controls.Add(btnTroca);
            Controls.Add(label4);
            Controls.Add(progressBar1);
            Controls.Add(labelStatus);
            Controls.Add(labelResultado);
            Controls.Add(buttonConverter);
            Controls.Add(comboBoxDestino);
            Controls.Add(comboBoxOrigem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxValor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Câmbios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxValor;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxDestino;
        private Button buttonConverter;
        private Label labelResultado;
        private Label labelStatus;
        private ProgressBar progressBar1;
        private Label label4;
        private Button btnTroca;
    }
}

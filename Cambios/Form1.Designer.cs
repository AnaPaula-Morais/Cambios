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
            label1 = new Label();
            this.textBoxValor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            this.comboBoxOrigem = new ComboBox();
            this.comboBoxDestino = new ComboBox();
            buttonConverter = new Button();
            label4 = new Label();
            labelStatus = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 49);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new Point(134, 49);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new Size(405, 31);
            this.textBoxValor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 191);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 2;
            label2.Text = "Moeda de destino:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 128);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 3;
            label3.Text = "Moeda de origem:";
            // 
            // comboBoxOrigem
            // 
            this.comboBoxOrigem.FormattingEnabled = true;
            this.comboBoxOrigem.Location = new Point(234, 128);
            this.comboBoxOrigem.Name = "comboBoxOrigem";
            this.comboBoxOrigem.Size = new Size(305, 33);
            this.comboBoxOrigem.TabIndex = 4;
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new Point(235, 191);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new Size(304, 33);
            this.comboBoxDestino.TabIndex = 5;
            // 
            // buttonConverter
            // 
            buttonConverter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConverter.Location = new Point(602, 49);
            buttonConverter.Name = "buttonConverter";
            buttonConverter.Size = new Size(136, 51);
            buttonConverter.TabIndex = 6;
            buttonConverter.Text = "Converter";
            buttonConverter.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(235, 258);
            label4.Name = "label4";
            label4.Size = new Size(397, 25);
            label4.TabIndex = 7;
            label4.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(62, 349);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(60, 25);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Status";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(566, 384);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(200, 34);
            progressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(labelStatus);
            Controls.Add(label4);
            Controls.Add(buttonConverter);
            Controls.Add(this.comboBoxDestino);
            Controls.Add(this.comboBoxOrigem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(this.textBoxValor);
            Controls.Add(label1);
            Name = "Form1";
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
        private Label label4;
        private Label labelStatus;
        private ProgressBar progressBar1;
    }
}

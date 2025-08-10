namespace Ejercicio2
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
            components = new System.ComponentModel.Container();
            txtTemperatura = new TextBox();
            cmbConversion = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(228, 129);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(125, 27);
            txtTemperatura.TabIndex = 0;
            // 
            // cmbConversion
            // 
            cmbConversion.FormattingEnabled = true;
            cmbConversion.Location = new Point(46, 129);
            cmbConversion.Name = "cmbConversion";
            cmbConversion.Size = new Size(151, 28);
            cmbConversion.TabIndex = 1;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(65, 197);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(94, 29);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(178, 201);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 532);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbConversion);
            Controls.Add(txtTemperatura);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTemperatura;
        private ComboBox cmbConversion;
        private Button btnConvertir;
        private Label lblResultado;
        private ErrorProvider errorProvider1;
    }
}

namespace Practica
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
            lblMensaje = new Label();
            btnSaludar = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AccessibleName = "lblMensaje";
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = SystemColors.ControlDark;
            lblMensaje.Location = new Point(85, 58);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.RightToLeft = RightToLeft.Yes;
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 0;
            lblMensaje.Click += label1_Click;
            // 
            // btnSaludar
            // 
            btnSaludar.AccessibleDescription = "btnSaludar";
            btnSaludar.AccessibleName = "btnSaludar";
            btnSaludar.Location = new Point(242, 148);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(262, 86);
            btnSaludar.TabIndex = 1;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaludar);
            Controls.Add(lblMensaje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Button btnSaludar;
    }
}

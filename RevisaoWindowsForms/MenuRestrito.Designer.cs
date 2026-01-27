namespace RevisaoWindowsForms
{
    partial class MenuRestrito
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
            lblUsuarioLogado = new Label();
            SuspendLayout();
            // 
            // lblUsuarioLogado
            // 
            lblUsuarioLogado.AutoSize = true;
            lblUsuarioLogado.Location = new Point(12, 9);
            lblUsuarioLogado.Name = "lblUsuarioLogado";
            lblUsuarioLogado.Size = new Size(97, 25);
            lblUsuarioLogado.TabIndex = 0;
            lblUsuarioLogado.Text = "Bem vindo";
            // 
            // MenuRestrito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUsuarioLogado);
            Name = "MenuRestrito";
            Text = "MenuRestrito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarioLogado;
    }
}
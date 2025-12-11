namespace PrimeiroProjetoWindowsForms
{
    partial class Menu
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
            labelBoasVindas = new Label();
            SuspendLayout();
            // 
            // labelBoasVindas
            // 
            labelBoasVindas.AutoSize = true;
            labelBoasVindas.Location = new Point(23, 26);
            labelBoasVindas.Name = "labelBoasVindas";
            labelBoasVindas.Size = new Size(97, 25);
            labelBoasVindas.TabIndex = 0;
            labelBoasVindas.Text = "Bem vindo";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBoasVindas);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBoasVindas;
    }
}
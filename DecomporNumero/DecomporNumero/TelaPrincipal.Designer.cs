namespace DecomporNumero
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EntradaGroupBox = new System.Windows.Forms.GroupBox();
            this.SaidaGroupBox = new System.Windows.Forms.GroupBox();
            this.SaidaTextBox = new System.Windows.Forms.TextBox();
            this.DecomporNumeroButton = new System.Windows.Forms.Button();
            this.InformacaoLabel1 = new System.Windows.Forms.Label();
            this.InformacaoLabel2 = new System.Windows.Forms.Label();
            this.NumeroNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EntradaGroupBox.SuspendLayout();
            this.SaidaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EntradaGroupBox
            // 
            this.EntradaGroupBox.Controls.Add(this.NumeroNumericUpDown);
            this.EntradaGroupBox.Controls.Add(this.InformacaoLabel2);
            this.EntradaGroupBox.Controls.Add(this.InformacaoLabel1);
            this.EntradaGroupBox.Controls.Add(this.DecomporNumeroButton);
            this.EntradaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.EntradaGroupBox.Name = "EntradaGroupBox";
            this.EntradaGroupBox.Size = new System.Drawing.Size(358, 75);
            this.EntradaGroupBox.TabIndex = 2;
            this.EntradaGroupBox.TabStop = false;
            this.EntradaGroupBox.Text = "Entrada:";
            // 
            // SaidaGroupBox
            // 
            this.SaidaGroupBox.Controls.Add(this.SaidaTextBox);
            this.SaidaGroupBox.Location = new System.Drawing.Point(12, 93);
            this.SaidaGroupBox.Name = "SaidaGroupBox";
            this.SaidaGroupBox.Size = new System.Drawing.Size(358, 223);
            this.SaidaGroupBox.TabIndex = 3;
            this.SaidaGroupBox.TabStop = false;
            this.SaidaGroupBox.Text = "Saída";
            // 
            // SaidaTextBox
            // 
            this.SaidaTextBox.Location = new System.Drawing.Point(6, 19);
            this.SaidaTextBox.Multiline = true;
            this.SaidaTextBox.Name = "SaidaTextBox";
            this.SaidaTextBox.ReadOnly = true;
            this.SaidaTextBox.Size = new System.Drawing.Size(346, 198);
            this.SaidaTextBox.TabIndex = 0;
            // 
            // DecomporNumeroButton
            // 
            this.DecomporNumeroButton.Location = new System.Drawing.Point(268, 45);
            this.DecomporNumeroButton.Name = "DecomporNumeroButton";
            this.DecomporNumeroButton.Size = new System.Drawing.Size(84, 20);
            this.DecomporNumeroButton.TabIndex = 1;
            this.DecomporNumeroButton.Text = "Decompor";
            this.DecomporNumeroButton.UseVisualStyleBackColor = true;
            // 
            // InformacaoLabel1
            // 
            this.InformacaoLabel1.AutoSize = true;
            this.InformacaoLabel1.Location = new System.Drawing.Point(3, 16);
            this.InformacaoLabel1.Name = "InformacaoLabel1";
            this.InformacaoLabel1.Size = new System.Drawing.Size(216, 13);
            this.InformacaoLabel1.TabIndex = 2;
            this.InformacaoLabel1.Text = "1. Digite um número inteiro e maior que zero.";
            // 
            // InformacaoLabel2
            // 
            this.InformacaoLabel2.AutoSize = true;
            this.InformacaoLabel2.Location = new System.Drawing.Point(3, 29);
            this.InformacaoLabel2.Name = "InformacaoLabel2";
            this.InformacaoLabel2.Size = new System.Drawing.Size(309, 13);
            this.InformacaoLabel2.TabIndex = 3;
            this.InformacaoLabel2.Text = "2. Clique em decompor para obter os divisores naturais e primos.";
            // 
            // NumeroNumericUpDown
            // 
            this.NumeroNumericUpDown.Location = new System.Drawing.Point(6, 45);
            this.NumeroNumericUpDown.Name = "NumeroNumericUpDown";
            this.NumeroNumericUpDown.Size = new System.Drawing.Size(256, 20);
            this.NumeroNumericUpDown.TabIndex = 4;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 323);
            this.Controls.Add(this.SaidaGroupBox);
            this.Controls.Add(this.EntradaGroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(396, 362);
            this.MinimumSize = new System.Drawing.Size(396, 362);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.Text = "Decompor Numero";
            this.EntradaGroupBox.ResumeLayout(false);
            this.EntradaGroupBox.PerformLayout();
            this.SaidaGroupBox.ResumeLayout(false);
            this.SaidaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox EntradaGroupBox;
        private System.Windows.Forms.GroupBox SaidaGroupBox;
        private System.Windows.Forms.TextBox SaidaTextBox;
        private System.Windows.Forms.Label InformacaoLabel2;
        private System.Windows.Forms.Label InformacaoLabel1;
        private System.Windows.Forms.Button DecomporNumeroButton;
        private System.Windows.Forms.NumericUpDown NumeroNumericUpDown;
    }
}
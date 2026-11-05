namespace CinemaApp.Cadastros
{
    partial class CadastroSala
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
            nudCapacidade = new NumericUpDown();
            nudFileiras = new NumericUpDown();
            nudAssentos = new NumericUpDown();
            nudNumero = new NumericUpDown();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel4 = new ReaLTaiizor.Controls.MaterialLabel();
            tabPageCadastro.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFileiras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAssentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumero).BeginInit();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(materialLabel3);
            tabPageCadastro.Controls.Add(materialLabel4);
            tabPageCadastro.Controls.Add(materialLabel2);
            tabPageCadastro.Controls.Add(materialLabel1);
            tabPageCadastro.Controls.Add(nudNumero);
            tabPageCadastro.Controls.Add(nudAssentos);
            tabPageCadastro.Controls.Add(nudFileiras);
            tabPageCadastro.Controls.Add(nudCapacidade);
            tabPageCadastro.Size = new Size(486, 305);
            tabPageCadastro.Controls.SetChildIndex(nudCapacidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(nudFileiras, 0);
            tabPageCadastro.Controls.SetChildIndex(nudAssentos, 0);
            tabPageCadastro.Controls.SetChildIndex(nudNumero, 0);
            tabPageCadastro.Controls.SetChildIndex(materialLabel1, 0);
            tabPageCadastro.Controls.SetChildIndex(materialLabel2, 0);
            tabPageCadastro.Controls.SetChildIndex(materialLabel4, 0);
            tabPageCadastro.Controls.SetChildIndex(materialLabel3, 0);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(494, 333);
            // 
            // nudCapacidade
            // 
            nudCapacidade.Location = new Point(154, 96);
            nudCapacidade.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCapacidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacidade.Name = "nudCapacidade";
            nudCapacidade.Size = new Size(120, 23);
            nudCapacidade.TabIndex = 5;
            nudCapacidade.TextAlign = HorizontalAlignment.Center;
            nudCapacidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudFileiras
            // 
            nudFileiras.Location = new Point(18, 159);
            nudFileiras.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudFileiras.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudFileiras.Name = "nudFileiras";
            nudFileiras.Size = new Size(120, 23);
            nudFileiras.TabIndex = 6;
            nudFileiras.TextAlign = HorizontalAlignment.Center;
            nudFileiras.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudAssentos
            // 
            nudAssentos.Location = new Point(154, 159);
            nudAssentos.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAssentos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAssentos.Name = "nudAssentos";
            nudAssentos.Size = new Size(120, 23);
            nudAssentos.TabIndex = 7;
            nudAssentos.TextAlign = HorizontalAlignment.Center;
            nudAssentos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudNumero
            // 
            nudNumero.Location = new Point(18, 96);
            nudNumero.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNumero.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumero.Name = "nudNumero";
            nudNumero.Size = new Size(120, 23);
            nudNumero.TabIndex = 8;
            nudNumero.TextAlign = HorizontalAlignment.Center;
            nudNumero.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(18, 74);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(93, 19);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Número Sala";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(154, 74);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(85, 19);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Capacidade";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(154, 137);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(66, 19);
            materialLabel3.TabIndex = 12;
            materialLabel3.Text = "Assentos";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(18, 137);
            materialLabel4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(52, 19);
            materialLabel4.TabIndex = 11;
            materialLabel4.Text = "Fileiras";
            // 
            // CadastroSala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 400);
            Location = new Point(0, 0);
            MinimumSize = new Size(500, 400);
            Name = "CadastroSala";
            Text = "CadastroSala";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCapacidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFileiras).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAssentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumero).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudCapacidade;
        private NumericUpDown nudNumero;
        private NumericUpDown nudAssentos;
        private NumericUpDown nudFileiras;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel4;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
    }
}
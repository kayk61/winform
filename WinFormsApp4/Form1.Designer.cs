namespace WinFormsApp4
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
            lblNome = new Label();
            lblIdade = new Label();
            lblTipo = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            btnCadastrar = new Button();
            btnFazerSom = new Button();
            cmbTipo = new ComboBox();
            lstAnimais = new ListBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(220, 94);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(220, 148);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 1;
            lblIdade.Text = "idade";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(220, 210);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            lblTipo.Click += label3_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(220, 112);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(220, 166);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(183, 300);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnFazerSom
            // 
            btnFazerSom.Location = new Point(294, 300);
            btnFazerSom.Name = "btnFazerSom";
            btnFazerSom.Size = new Size(75, 23);
            btnFazerSom.TabIndex = 7;
            btnFazerSom.Text = "Fazer som";
            btnFazerSom.UseVisualStyleBackColor = true;
            btnFazerSom.Click += btnFazerSom_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Cachorro", "Gato", "Passaro" });
            cmbTipo.Location = new Point(220, 237);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 8;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lstAnimais
            // 
            lstAnimais.FormattingEnabled = true;
            lstAnimais.Location = new Point(221, 329);
            lstAnimais.Name = "lstAnimais";
            lstAnimais.Size = new Size(120, 94);
            lstAnimais.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstAnimais);
            Controls.Add(cmbTipo);
            Controls.Add(btnFazerSom);
            Controls.Add(btnCadastrar);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lblTipo);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblIdade;
        private Label lblTipo;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Button btnCadastrar;
        private Button btnFazerSom;
        private ComboBox cmbTipo;
        private ListBox lstAnimais;
    }
}

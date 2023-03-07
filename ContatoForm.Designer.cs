namespace AppContatoForm
{
    partial class ContatoForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtNome = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.dateDataNascimento = new Sunny.UI.UIDatePicker();
            this.rdSexoGroup = new Sunny.UI.UIRadioButtonGroup();
            this.rdSexo2 = new Sunny.UI.UIRadioButton();
            this.rdSexo1 = new Sunny.UI.UIRadioButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtEmail = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtTelefone = new Sunny.UI.UITextBox();
            this.btnSalvar = new Sunny.UI.UIButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.rdSexoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.uiLabel1);
            this.flowLayoutPanel1.Controls.Add(this.txtNome);
            this.flowLayoutPanel1.Controls.Add(this.uiLabel2);
            this.flowLayoutPanel1.Controls.Add(this.dateDataNascimento);
            this.flowLayoutPanel1.Controls.Add(this.rdSexoGroup);
            this.flowLayoutPanel1.Controls.Add(this.uiLabel3);
            this.flowLayoutPanel1.Controls.Add(this.txtEmail);
            this.flowLayoutPanel1.Controls.Add(this.uiLabel4);
            this.flowLayoutPanel1.Controls.Add(this.txtTelefone);
            this.flowLayoutPanel1.Controls.Add(this.btnSalvar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(3, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "Nome";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtNome.Location = new System.Drawing.Point(4, 28);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.ShowText = false;
            this.txtNome.Size = new System.Drawing.Size(375, 28);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNome.Watermark = "";
            this.txtNome.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(3, 61);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(380, 23);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "Data Nascimento";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dateDataNascimento
            // 
            this.dateDataNascimento.FillColor = System.Drawing.Color.White;
            this.dateDataNascimento.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dateDataNascimento.Location = new System.Drawing.Point(4, 89);
            this.dateDataNascimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDataNascimento.MaxLength = 10;
            this.dateDataNascimento.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateDataNascimento.Name = "dateDataNascimento";
            this.dateDataNascimento.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateDataNascimento.Size = new System.Drawing.Size(417, 29);
            this.dateDataNascimento.SymbolDropDown = 61555;
            this.dateDataNascimento.SymbolNormal = 61555;
            this.dateDataNascimento.TabIndex = 0;
            this.dateDataNascimento.Text = "2023-02-28";
            this.dateDataNascimento.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateDataNascimento.Value = new System.DateTime(2023, 2, 28, 10, 35, 1, 73);
            this.dateDataNascimento.Watermark = "";
            this.dateDataNascimento.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rdSexoGroup
            // 
            this.rdSexoGroup.Controls.Add(this.rdSexo2);
            this.rdSexoGroup.Controls.Add(this.rdSexo1);
            this.rdSexoGroup.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rdSexoGroup.Location = new System.Drawing.Point(4, 128);
            this.rdSexoGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdSexoGroup.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdSexoGroup.Name = "rdSexoGroup";
            this.rdSexoGroup.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.rdSexoGroup.Size = new System.Drawing.Size(270, 130);
            this.rdSexoGroup.TabIndex = 7;
            this.rdSexoGroup.Text = "Sexo";
            this.rdSexoGroup.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdSexoGroup.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rdSexo2
            // 
            this.rdSexo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdSexo2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rdSexo2.Location = new System.Drawing.Point(16, 84);
            this.rdSexo2.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdSexo2.Name = "rdSexo2";
            this.rdSexo2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdSexo2.Size = new System.Drawing.Size(150, 29);
            this.rdSexo2.TabIndex = 1;
            this.rdSexo2.Text = "Feminino";
            this.rdSexo2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // rdSexo1
            // 
            this.rdSexo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdSexo1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rdSexo1.Location = new System.Drawing.Point(16, 35);
            this.rdSexo1.MinimumSize = new System.Drawing.Size(1, 1);
            this.rdSexo1.Name = "rdSexo1";
            this.rdSexo1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rdSexo1.Size = new System.Drawing.Size(150, 29);
            this.rdSexo1.TabIndex = 0;
            this.rdSexo1.Text = "Masculino";
            this.rdSexo1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(3, 263);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 8;
            this.uiLabel3.Text = "E-mail";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtEmail.Location = new System.Drawing.Point(4, 291);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShowText = false;
            this.txtEmail.Size = new System.Drawing.Size(150, 29);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.Watermark = "";
            this.txtEmail.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(3, 325);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 9;
            this.uiLabel4.Text = "Telefone";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtTelefone.Location = new System.Drawing.Point(4, 353);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefone.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ShowText = false;
            this.txtTelefone.Size = new System.Drawing.Size(150, 29);
            this.txtTelefone.TabIndex = 11;
            this.txtTelefone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTelefone.Watermark = "";
            this.txtTelefone.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(3, 390);
            this.btnSalvar.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 35);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ContatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ContatoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Contato";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.rdSexoGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UIDatePicker dateDataNascimento;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtNome;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIRadioButtonGroup rdSexoGroup;
        private Sunny.UI.UIRadioButton rdSexo2;
        private Sunny.UI.UIRadioButton rdSexo1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtTelefone;
        private Sunny.UI.UIButton btnSalvar;
    }
}
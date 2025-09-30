namespace AcademicoAppV1
{
    partial class FormAluno
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAluno));
            tabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            btnSalvar = new ReaLTaiizor.Controls.Button();
            btnCancelar = new ReaLTaiizor.Controls.Button();
            txtEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            listViewConsulta = new ListView();
            btnExcluir = new ReaLTaiizor.Controls.Button();
            btnEditar = new ReaLTaiizor.Controls.Button();
            btnNovo = new ReaLTaiizor.Controls.Button();
            imageList1 = new ImageList(components);
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Controls.Add(tabPageCadastro);
            tabControlCadastro.Controls.Add(tabPageConsulta);
            tabControlCadastro.Depth = 0;
            tabControlCadastro.Dock = DockStyle.Fill;
            tabControlCadastro.ImageList = imageList1;
            tabControlCadastro.Location = new Point(3, 64);
            tabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCadastro.Multiline = true;
            tabControlCadastro.Name = "tabControlCadastro";
            tabControlCadastro.SelectedIndex = 0;
            tabControlCadastro.Size = new Size(979, 524);
            tabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(txtEstado);
            tabPageCadastro.Controls.Add(txtDataNascimento);
            tabPageCadastro.Controls.Add(txtSenha);
            tabPageCadastro.Controls.Add(txtCidade);
            tabPageCadastro.Controls.Add(txtBairro);
            tabPageCadastro.Controls.Add(txtEndereco);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtMatricula);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(971, 489);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BorderColor = Color.FromArgb(32, 34, 37);
            btnSalvar.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSalvar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSalvar.Font = new Font("Microsoft Sans Serif", 12F);
            btnSalvar.Image = null;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.InactiveColor = Color.FromArgb(32, 34, 37);
            btnSalvar.Location = new Point(660, 423);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSalvar.PressedColor = Color.FromArgb(165, 37, 37);
            btnSalvar.Size = new Size(120, 40);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlignment = StringAlignment.Center;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BorderColor = Color.FromArgb(32, 34, 37);
            btnCancelar.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnCancelar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelar.Image = null;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.InactiveColor = Color.FromArgb(32, 34, 37);
            btnCancelar.Location = new Point(512, 423);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCancelar.PressedColor = Color.FromArgb(165, 37, 37);
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlignment = StringAlignment.Center;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEstado
            // 
            txtEstado.AutoResize = false;
            txtEstado.BackColor = Color.FromArgb(255, 255, 255);
            txtEstado.Depth = 0;
            txtEstado.DrawMode = DrawMode.OwnerDrawVariable;
            txtEstado.DropDownHeight = 174;
            txtEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEstado.DropDownWidth = 121;
            txtEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtEstado.FormattingEnabled = true;
            txtEstado.Hint = "Estado";
            txtEstado.IntegralHeight = false;
            txtEstado.ItemHeight = 43;
            txtEstado.Items.AddRange(new object[] { "", "AC - Acre    ", "AL - Alagoas    ", "AM - Amazonas    ", "BA - Bahia    ", "CE - Ceará    ", "GO - Goiás    ", "MA - Maranhão    ", "PA - Pará    ", "PE - Pernambuco    ", "PI - Piauí    ", "RO - Rondônia    ", "SE - Sergipe    ", "TO - Tocanti", "MS - Mato Grosso do Sul    ", "RN - Rio Grande do Norte    ", "RS - Rio Grande do Sul    ", "AP - Amapá    ", "MT - Mato Grosso    ", "PB - Paraíba    ", "PR - Paraná    ", "RR - Roraima  ", "DF - Distrito Federal", "ES - Espírito Santo    ", "MG - Minas Gerais    ", "RJ - Rio de Janeiro    ", "SC - Santa Catarina ", "SP - São Paulo " });
            txtEstado.Location = new Point(478, 281);
            txtEstado.MaxDropDownItems = 4;
            txtEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(191, 49);
            txtEstado.StartIndex = 0;
            txtEstado.TabIndex = 7;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.AllowPromptAsInput = true;
            txtDataNascimento.AnimateReadOnly = false;
            txtDataNascimento.AsciiOnly = false;
            txtDataNascimento.BackgroundImageLayout = ImageLayout.None;
            txtDataNascimento.BeepOnError = false;
            txtDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.Depth = 0;
            txtDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataNascimento.HidePromptOnLeave = false;
            txtDataNascimento.HideSelection = true;
            txtDataNascimento.Hint = "Data de Nascimento";
            txtDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            txtDataNascimento.LeadingIcon = null;
            txtDataNascimento.Location = new Point(450, 16);
            txtDataNascimento.Mask = "99 /99 /9999";
            txtDataNascimento.MaxLength = 32767;
            txtDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.PasswordChar = '\0';
            txtDataNascimento.PrefixSuffixText = null;
            txtDataNascimento.PromptChar = '_';
            txtDataNascimento.ReadOnly = false;
            txtDataNascimento.RejectInputOnFirstFailure = false;
            txtDataNascimento.ResetOnPrompt = true;
            txtDataNascimento.ResetOnSpace = true;
            txtDataNascimento.RightToLeft = RightToLeft.No;
            txtDataNascimento.SelectedText = "";
            txtDataNascimento.SelectionLength = 0;
            txtDataNascimento.SelectionStart = 0;
            txtDataNascimento.ShortcutsEnabled = true;
            txtDataNascimento.Size = new Size(250, 48);
            txtDataNascimento.SkipLiterals = true;
            txtDataNascimento.TabIndex = 6;
            txtDataNascimento.TabStop = false;
            txtDataNascimento.Text = "   /   /";
            txtDataNascimento.TextAlign = HorizontalAlignment.Left;
            txtDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.TrailingIcon = null;
            txtDataNascimento.UseSystemPasswordChar = false;
            txtDataNascimento.ValidatingType = null;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = Properties.Resources.baseline_fingerprint_black_24dp;
            txtSenha.Location = new Point(19, 351);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(761, 48);
            txtSenha.TabIndex = 5;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(19, 281);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(329, 48);
            txtCidade.TabIndex = 4;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(19, 218);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(761, 48);
            txtBairro.TabIndex = 3;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(19, 150);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(761, 48);
            txtEndereco.TabIndex = 2;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(19, 84);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(761, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = ImageLayout.None;
            txtMatricula.CharacterCasing = CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "Matrícula";
            txtMatricula.LeadingIcon = null;
            txtMatricula.Location = new Point(19, 16);
            txtMatricula.MaxLength = 32767;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new Size(329, 48);
            txtMatricula.TabIndex = 0;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(listViewConsulta);
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(971, 489);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // listViewConsulta
            // 
            listViewConsulta.FullRowSelect = true;
            listViewConsulta.GridLines = true;
            listViewConsulta.Location = new Point(-4, 0);
            listViewConsulta.Name = "listViewConsulta";
            listViewConsulta.Size = new Size(965, 362);
            listViewConsulta.TabIndex = 4;
            listViewConsulta.UseCompatibleStateImageBehavior = false;
            listViewConsulta.View = View.Details;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.BorderColor = Color.FromArgb(32, 34, 37);
            btnExcluir.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnExcluir.EnteredColor = Color.FromArgb(32, 34, 37);
            btnExcluir.Font = new Font("Microsoft Sans Serif", 12F);
            btnExcluir.Image = null;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.InactiveColor = Color.FromArgb(32, 34, 37);
            btnExcluir.Location = new Point(824, 368);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnExcluir.PressedColor = Color.FromArgb(165, 37, 37);
            btnExcluir.Size = new Size(120, 40);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.TextAlignment = StringAlignment.Center;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BorderColor = Color.FromArgb(32, 34, 37);
            btnEditar.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnEditar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnEditar.Font = new Font("Microsoft Sans Serif", 12F);
            btnEditar.Image = null;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.InactiveColor = Color.FromArgb(32, 34, 37);
            btnEditar.Location = new Point(685, 368);
            btnEditar.Name = "btnEditar";
            btnEditar.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnEditar.PressedColor = Color.FromArgb(165, 37, 37);
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "EDITAR";
            btnEditar.TextAlignment = StringAlignment.Center;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = Color.Transparent;
            btnNovo.BorderColor = Color.FromArgb(32, 34, 37);
            btnNovo.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnNovo.EnteredColor = Color.FromArgb(32, 34, 37);
            btnNovo.Font = new Font("Microsoft Sans Serif", 12F);
            btnNovo.Image = null;
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.InactiveColor = Color.FromArgb(32, 34, 37);
            btnNovo.Location = new Point(548, 368);
            btnNovo.Name = "btnNovo";
            btnNovo.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnNovo.PressedColor = Color.FromArgb(165, 37, 37);
            btnNovo.Size = new Size(120, 40);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "NOVO";
            btnNovo.TextAlignment = StringAlignment.Center;
            btnNovo.Click += btnNovo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 591);
            Controls.Add(tabControlCadastro);
            DrawerTabControl = tabControlCadastro;
            MaximizeBox = false;
            Name = "FormAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControlCadastro;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.Button btnSalvar;
        private ReaLTaiizor.Controls.Button btnCancelar;
        private ReaLTaiizor.Controls.MaterialComboBox txtEstado;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataNascimento;
        private ReaLTaiizor.Controls.Button btnExcluir;
        private ReaLTaiizor.Controls.Button btnEditar;
        private ReaLTaiizor.Controls.Button btnNovo;
        private ListView listViewConsulta;
    }
}
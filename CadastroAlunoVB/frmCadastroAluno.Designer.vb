<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAluno
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttelefone = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.gAlunos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.txtPesquisaNome = New System.Windows.Forms.TextBox()
        Me.txtPesquisaCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.colIdAluno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelecionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.gAlunos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelecionarToolStripMenuItem, Me.ExcluirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(129, 48)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txttelefone)
        Me.GroupBox1.Controls.Add(Me.txtnome)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(865, 79)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "dados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(605, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telefone:"
        '
        'txttelefone
        '
        Me.txttelefone.Location = New System.Drawing.Point(608, 32)
        Me.txttelefone.Name = "txttelefone"
        Me.txttelefone.Size = New System.Drawing.Size(246, 20)
        Me.txttelefone.TabIndex = 4
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(99, 32)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(503, 20)
        Me.txtnome.TabIndex = 3
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(15, 32)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(78, 20)
        Me.txtcodigo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código aluno:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.btnLimpar)
        Me.GroupBox2.Controls.Add(Me.btnExcluir)
        Me.GroupBox2.Controls.Add(Me.btnAtualizar)
        Me.GroupBox2.Controls.Add(Me.btnIncluir)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(865, 79)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "comandos"
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.Gold
        Me.btnLimpar.Location = New System.Drawing.Point(144, 29)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(123, 31)
        Me.btnLimpar.TabIndex = 0
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Crimson
        Me.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExcluir.Location = New System.Drawing.Point(15, 29)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(123, 31)
        Me.btnExcluir.TabIndex = 0
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAtualizar.ForeColor = System.Drawing.Color.White
        Me.btnAtualizar.Location = New System.Drawing.Point(273, 29)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(123, 31)
        Me.btnAtualizar.TabIndex = 0
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = False
        '
        'btnIncluir
        '
        Me.btnIncluir.BackColor = System.Drawing.Color.ForestGreen
        Me.btnIncluir.ForeColor = System.Drawing.Color.White
        Me.btnIncluir.Location = New System.Drawing.Point(402, 29)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(123, 31)
        Me.btnIncluir.TabIndex = 0
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox3.Controls.Add(Me.gAlunos)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(865, 299)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "pesquisa"
        '
        'gAlunos
        '
        Me.gAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gAlunos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdAluno, Me.colNome, Me.colTelefone})
        Me.gAlunos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gAlunos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gAlunos.Location = New System.Drawing.Point(3, 89)
        Me.gAlunos.Name = "gAlunos"
        Me.gAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gAlunos.Size = New System.Drawing.Size(859, 207)
        Me.gAlunos.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Controls.Add(Me.btnPesquisar)
        Me.Panel1.Controls.Add(Me.txtPesquisaNome)
        Me.Panel1.Controls.Add(Me.txtPesquisaCodigo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 67)
        Me.Panel1.TabIndex = 2
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnPesquisar.ForeColor = System.Drawing.Color.Black
        Me.btnPesquisar.Location = New System.Drawing.Point(605, 25)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(101, 23)
        Me.btnPesquisar.TabIndex = 2
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = False
        '
        'txtPesquisaNome
        '
        Me.txtPesquisaNome.Location = New System.Drawing.Point(96, 25)
        Me.txtPesquisaNome.Name = "txtPesquisaNome"
        Me.txtPesquisaNome.Size = New System.Drawing.Size(503, 20)
        Me.txtPesquisaNome.TabIndex = 1
        '
        'txtPesquisaCodigo
        '
        Me.txtPesquisaCodigo.Location = New System.Drawing.Point(9, 25)
        Me.txtPesquisaCodigo.Name = "txtPesquisaCodigo"
        Me.txtPesquisaCodigo.Size = New System.Drawing.Size(78, 20)
        Me.txtPesquisaCodigo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nome:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Código:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Label4"
        '
        'colIdAluno
        '
        Me.colIdAluno.DataPropertyName = "IdAluno"
        Me.colIdAluno.HeaderText = "Código"
        Me.colIdAluno.Name = "colIdAluno"
        Me.colIdAluno.ReadOnly = True
        '
        'colNome
        '
        Me.colNome.DataPropertyName = "Nome"
        Me.colNome.HeaderText = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.ReadOnly = True
        '
        'colTelefone
        '
        Me.colTelefone.DataPropertyName = "Telefone"
        Me.colTelefone.HeaderText = "Telefone"
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.ReadOnly = True
        '
        'SelecionarToolStripMenuItem
        '
        Me.SelecionarToolStripMenuItem.Name = "SelecionarToolStripMenuItem"
        Me.SelecionarToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.SelecionarToolStripMenuItem.Text = "Selecionar"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'frmCadastroAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 456)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCadastroAluno"
        Me.Text = "frmCdastroAluno"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.gAlunos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txttelefone As TextBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnIncluir As Button
    Friend WithEvents gAlunos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents txtPesquisaNome As TextBox
    Friend WithEvents txtPesquisaCodigo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents colIdAluno As DataGridViewTextBoxColumn
    Friend WithEvents colNome As DataGridViewTextBoxColumn
    Friend WithEvents colTelefone As DataGridViewTextBoxColumn
    Friend WithEvents SelecionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
End Class

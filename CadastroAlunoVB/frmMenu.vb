Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load







    End Sub

    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        Dim vfrmCadastro As New frmCadastroAluno
        vfrmCadastro.MdiParent = Me
        vfrmCadastro.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MessageBox.Show("Deseja realmente sair?",
                           "Confirmacao",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
        End If
    End Sub


    'Private Sub ContextMenuStrip7_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    'End Sub

    'Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    'End Sub


End Class
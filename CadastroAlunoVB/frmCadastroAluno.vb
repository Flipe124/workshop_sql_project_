Public Class frmCadastroAluno
    Dim strConexao As String = "Data Source = (local)\sqlexpress;UID=nutec;PWD=nutec;initial catalog=NUTEC;"

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        Dim conexao As New System.Data.SqlClient.SqlConnection
        conexao.ConnectionString = strConexao
        conexao.Open()

        Dim comando As New System.Data.SqlClient.SqlCommand
        comando.Connection = conexao
        comando.CommandText = String.Format("INSERT INTO Alunos (Nome, Telefone) VALUES ('{0}','{1}')", txtnome.Text, txttelefone.Text)
        comando.ExecuteNonQuery()

        conexao.Close()

    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Dim conexao As New System.Data.SqlClient.SqlConnection
        conexao.ConnectionString = strConexao
        conexao.Open()

        Dim comando As New System.Data.SqlClient.SqlCommand
        comando.Connection = conexao
        comando.CommandText = String.Format("SELECT * FROM Alunos WHERE Nome LIKE '%{0}%'", txtPesquisaNome.Text)

        Dim banco As New DataSet
        Dim adptadorDeDados As New System.Data.SqlClient.SqlDataAdapter(comando.CommandText, conexao)
        adptadorDeDados.Fill(banco)

        conexao.Close()

        gAlunos.DataSource = banco.Tables(0)
        gAlunos.Refresh()

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles gAlunos.DoubleClick
        'txtcodigo.Text = DataGridView1.SelectedRows(0).Cells("colIdAluno").Value

        'txtcodigo.Text = gAlunos.CurrentRow.Cells("colIdAluno").Value
        'txtnome.Text = gAlunos.CurrentRow.Cells("colNome").Value
        'txttelefone.Text = gAlunos.CurrentRow.Cells("colTelefone").Value

        With gAlunos.CurrentRow

            txtcodigo.Text = .Cells("colIdAluno").Value
            txtnome.Text = .Cells("colNome").Value
            txttelefone.Text = .Cells("colTelefone").Value

        End With

    End Sub

    Private Sub SelecionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecionarToolStripMenuItem.Click
        With gAlunos.CurrentRow

            txtcodigo.Text = .Cells("colIdAluno").Value
            txtnome.Text = .Cells("colNome").Value
            txttelefone.Text = .Cells("colTelefone").Value

        End With
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Dim conexao As New System.Data.SqlClient.SqlConnection
        conexao.ConnectionString = strConexao
        conexao.Open()

        Dim comando As New System.Data.SqlClient.SqlCommand
        comando.Connection = conexao
        comando.CommandText = String.Format("UPDATE Alunos SET Nome = '{0}', Telefone = '{1}' WHERE IdAluno = '{2}'", txtnome.Text, txttelefone.Text, txtcodigo.Text)
        comando.ExecuteNonQuery()

        conexao.Close()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        txtcodigo.Text = ""
        txtnome.Text = ""
        txttelefone.Text = ""
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim conexao As New System.Data.SqlClient.SqlConnection
        conexao.ConnectionString = strConexao
        conexao.Open()

        Dim comando As New System.Data.SqlClient.SqlCommand
        comando.Connection = conexao
        comando.CommandText = String.Format("DELETE FROM Alunos WHERE IdAluno = '{0}'", txtcodigo.Text)
        comando.ExecuteNonQuery()

        conexao.Close()
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        'With gAlunos.CurrentRow

        '    txtcodigo.Text = .Cells("colIdAluno").Value
        '    txtnome.Text = .Cells("colNome").Value
        '    txttelefone.Text = .Cells("colTelefone").Value

        'End With



        Dim conexao As New System.Data.SqlClient.SqlConnection
        conexao.ConnectionString = strConexao
        conexao.Open()

        Dim comando As New System.Data.SqlClient.SqlCommand
        comando.Connection = conexao
        comando.CommandText = String.Format("DELETE FROM Alunos WHERE IdAluno = '{0}'", gAlunos.CurrentRow.Cells("colIdAluno").Value)
        comando.ExecuteNonQuery()

        conexao.Close()
    End Sub







    'Alterar nome para gAlunos' 
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gAlunos.CellContentClick

    End Sub

    Private Sub frmCadastroAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub










    'Private Sub frmCadastroAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    'End Sub

    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    'End Sub

    'Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    'End Sub

    'Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged
    '    'teste"
    'End Sub

    'Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, Label6.Click

    'End Sub

    'Private Sub txtnome_TextChanged(sender As Object, e As EventArgs) Handles txtnome.TextChanged

    'End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    'End Sub

End Class
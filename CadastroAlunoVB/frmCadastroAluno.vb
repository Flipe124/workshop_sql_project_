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






    Private Sub frmCadastroAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged
        'teste"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, Label6.Click

    End Sub


End Class
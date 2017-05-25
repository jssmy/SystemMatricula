Public Class REmpleado

    Dim personas As New PersonCON
    Dim person As New Person
    Dim g As New Genere
    Dim majorin As New MajorCON
    Dim c As New Major
    Private Sub REmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        g.set_ID(1)
        g.set_name("M")
        c.set_ID(1)
        c.set_name("Ing. de Sistemas")
        person.set_ID(1)
        person.set_dni(12323455)
        person.set_name("Joset")
        person.set_lastname("Manihuari")
        person.set_genere(g)
        person.set_major(c)
        Dim d As Date

        person.set_birthday(d)
        personas.save(person)
        ini_data_users()
        ini_user_list()
        ini_major_list()
    End Sub

    Private Sub ini_data_users()
        Me.td_users.ColumnCount = 6
        Me.td_users.ColumnHeadersVisible = True
        Dim columnHeaderStyle As New DataGridViewCellStyle()

        columnHeaderStyle.BackColor = Color.Beige
        columnHeaderStyle.Font = New Font("Verdana", 10, FontStyle.Bold)

        td_users.ColumnHeadersDefaultCellStyle = columnHeaderStyle
        td_users.Columns(0).Name = "DNI"
        td_users.Columns(1).Name = "Nombres"
        td_users.Columns(2).Name = "Apellidos"
        td_users.Columns(3).Name = "Cargo"
        td_users.Columns(4).Name = "Genero"
        td_users.Columns(5).Name = "Nacimiento"

    End Sub

    Private Sub ini_user_list()
        td_users.Rows().Clear()

        Dim i As Integer
        For i = 0 To personas.Size() - 1 Step 1

            person = personas.person_by_index(i)
            Dim g As Genere = person.get_genere()
            Dim c As Major = person.get_major()
            Dim row() As String = {person.get_dni(), person.get_name(), person.get_lastname(), c.get_name(), g.get_name(), person.get_birthday()}
            td_users.Rows.Add(row)
        Next
    End Sub

    Private Sub ini_major_list()
        Dim i As Integer
        For i = 0 To majorin.Size() - 1 Step 1
            c = majorin.major_by_index(i)
            cmb_major.Items.Add(c.get_name())
        Next

    End Sub

    Private Sub btn_save_user_tool_Click(sender As Object, e As EventArgs) Handles btn_save_user_tool.Click
        person = New Person
        c = New Major
        g = New Genere
        person.set_dni(txt_dni.Text)
        person.set_name(txt_name.Text)
        person.set_lastname(txt_lastname.Text)
        c.set_ID(1)
        c.set_name("Programador")
        g.set_ID(1)
        g.set_name("M")

        
        Dim birth As Date = time_pick.Value
        person.set_birthday(birth)

        If rd_man.Checked Then
            g.set_name("Man")
        End If
        If rd_woman.Checked Then
            g.set_name("Fem")
        End If

        c = majorin.major_by_name(cmb_major.Text)

        person.set_major(c)
        person.set_genere(g)
        Dim mess As String = personas.save(person)
        MessageBox.Show(mess)
        ini_user_list()
    End Sub
End Class
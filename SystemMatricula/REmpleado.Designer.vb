<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REmpleado))
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_lastname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rd_man = New System.Windows.Forms.RadioButton()
        Me.rd_woman = New System.Windows.Forms.RadioButton()
        Me.time_pick = New System.Windows.Forms.DateTimePicker()
        Me.cmb_major = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.td_users = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_new_user_tool = New System.Windows.Forms.ToolStripButton()
        Me.btn_save_user_tool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_serach_user_tool = New System.Windows.Forms.ToolStripTextBox()
        Me.btn_search_user_tool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_edit_user_tool = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.td_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_dni
        '
        Me.txt_dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dni.Location = New System.Drawing.Point(170, 67)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(194, 20)
        Me.txt_dni.TabIndex = 0
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(170, 95)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(194, 20)
        Me.txt_name.TabIndex = 1
        '
        'txt_lastname
        '
        Me.txt_lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lastname.Location = New System.Drawing.Point(170, 122)
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.Size = New System.Drawing.Size(194, 20)
        Me.txt_lastname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOMBRES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "APELLIDOS"
        '
        'rd_man
        '
        Me.rd_man.AutoSize = True
        Me.rd_man.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_man.Location = New System.Drawing.Point(395, 46)
        Me.rd_man.Name = "rd_man"
        Me.rd_man.Size = New System.Drawing.Size(62, 17)
        Me.rd_man.TabIndex = 6
        Me.rd_man.TabStop = True
        Me.rd_man.Text = "Hombre"
        Me.rd_man.UseVisualStyleBackColor = True
        '
        'rd_woman
        '
        Me.rd_woman.AutoSize = True
        Me.rd_woman.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_woman.Location = New System.Drawing.Point(553, 46)
        Me.rd_woman.Name = "rd_woman"
        Me.rd_woman.Size = New System.Drawing.Size(51, 17)
        Me.rd_woman.TabIndex = 7
        Me.rd_woman.TabStop = True
        Me.rd_woman.Text = "Mujer"
        Me.rd_woman.UseVisualStyleBackColor = True
        '
        'time_pick
        '
        Me.time_pick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_pick.Location = New System.Drawing.Point(395, 97)
        Me.time_pick.Name = "time_pick"
        Me.time_pick.Size = New System.Drawing.Size(209, 20)
        Me.time_pick.TabIndex = 8
        '
        'cmb_major
        '
        Me.cmb_major.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_major.FormattingEnabled = True
        Me.cmb_major.Location = New System.Drawing.Point(170, 148)
        Me.cmb_major.Name = "cmb_major"
        Me.cmb_major.Size = New System.Drawing.Size(194, 21)
        Me.cmb_major.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CARGO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'td_users
        '
        Me.td_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.td_users.Location = New System.Drawing.Point(28, 212)
        Me.td_users.Name = "td_users"
        Me.td_users.Size = New System.Drawing.Size(638, 201)
        Me.td_users.TabIndex = 11
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_new_user_tool, Me.btn_save_user_tool, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.txt_serach_user_tool, Me.btn_search_user_tool, Me.ToolStripSeparator2, Me.btn_edit_user_tool})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(688, 30)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_new_user_tool
        '
        Me.btn_new_user_tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_new_user_tool.Image = CType(resources.GetObject("btn_new_user_tool.Image"), System.Drawing.Image)
        Me.btn_new_user_tool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_new_user_tool.Name = "btn_new_user_tool"
        Me.btn_new_user_tool.Size = New System.Drawing.Size(23, 27)
        '
        'btn_save_user_tool
        '
        Me.btn_save_user_tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_save_user_tool.Image = CType(resources.GetObject("btn_save_user_tool.Image"), System.Drawing.Image)
        Me.btn_save_user_tool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_save_user_tool.Name = "btn_save_user_tool"
        Me.btn_save_user_tool.Size = New System.Drawing.Size(23, 27)
        Me.btn_save_user_tool.Text = "Guardar Empleado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 27)
        Me.ToolStripLabel1.Text = "Buscar"
        '
        'txt_serach_user_tool
        '
        Me.txt_serach_user_tool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_serach_user_tool.Name = "txt_serach_user_tool"
        Me.txt_serach_user_tool.Size = New System.Drawing.Size(100, 30)
        '
        'btn_search_user_tool
        '
        Me.btn_search_user_tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_search_user_tool.Image = CType(resources.GetObject("btn_search_user_tool.Image"), System.Drawing.Image)
        Me.btn_search_user_tool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_search_user_tool.Name = "btn_search_user_tool"
        Me.btn_search_user_tool.Size = New System.Drawing.Size(23, 27)
        Me.btn_search_user_tool.Text = "ToolStripButton3"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'btn_edit_user_tool
        '
        Me.btn_edit_user_tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_edit_user_tool.Image = CType(resources.GetObject("btn_edit_user_tool.Image"), System.Drawing.Image)
        Me.btn_edit_user_tool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_edit_user_tool.Name = "btn_edit_user_tool"
        Me.btn_edit_user_tool.Size = New System.Drawing.Size(23, 27)
        Me.btn_edit_user_tool.Text = "ToolStripButton4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.time_pick)
        Me.GroupBox1.Controls.Add(Me.rd_man)
        Me.GroupBox1.Controls.Add(Me.rd_woman)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 141)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(384, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 48)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Genero"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(384, 77)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 44)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha de Nacimiento"
        '
        'REmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 434)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.td_users)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_major)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_lastname)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "REmpleado"
        Me.Text = "REmpleado"
        CType(Me.td_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_lastname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rd_man As System.Windows.Forms.RadioButton
    Friend WithEvents rd_woman As System.Windows.Forms.RadioButton
    Friend WithEvents time_pick As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_major As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents td_users As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_new_user_tool As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_save_user_tool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_serach_user_tool As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btn_search_user_tool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_edit_user_tool As System.Windows.Forms.ToolStripButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.form_registrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiezaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlumnosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(698, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.form_registrar, Me.VerTodosToolStripMenuItem})
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AlumnosToolStripMenuItem.Text = "Empleados"
        '
        'form_registrar
        '
        Me.form_registrar.Name = "form_registrar"
        Me.form_registrar.Size = New System.Drawing.Size(152, 22)
        Me.form_registrar.Text = "Registrar"
        '
        'VerTodosToolStripMenuItem
        '
        Me.VerTodosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocentesToolStripMenuItem, Me.AuxiliaresToolStripMenuItem, Me.LimpiezaToolStripMenuItem})
        Me.VerTodosToolStripMenuItem.Name = "VerTodosToolStripMenuItem"
        Me.VerTodosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerTodosToolStripMenuItem.Text = "Vista"
        '
        'DocentesToolStripMenuItem
        '
        Me.DocentesToolStripMenuItem.Name = "DocentesToolStripMenuItem"
        Me.DocentesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DocentesToolStripMenuItem.Text = "Docentes"
        '
        'AuxiliaresToolStripMenuItem
        '
        Me.AuxiliaresToolStripMenuItem.Name = "AuxiliaresToolStripMenuItem"
        Me.AuxiliaresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AuxiliaresToolStripMenuItem.Text = "Auxiliares"
        '
        'LimpiezaToolStripMenuItem
        '
        Me.LimpiezaToolStripMenuItem.Name = "LimpiezaToolStripMenuItem"
        Me.LimpiezaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LimpiezaToolStripMenuItem.Text = "Limpieza"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 354)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents form_registrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerTodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuxiliaresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiezaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

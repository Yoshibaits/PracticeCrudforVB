<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt_prodno = New TextBox()
        txt_price = New TextBox()
        txt_prodname = New TextBox()
        combo_prodGroup = New ComboBox()
        exp_datePicker = New DateTimePicker()
        status_checkbox = New CheckBox()
        btn_save = New Button()
        btn_update = New Button()
        btn_delete = New Button()
        btn_clear = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewCheckBoxColumn()
        Label6 = New Label()
        txt_search = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_prodno
        ' 
        txt_prodno.Location = New Point(59, 61)
        txt_prodno.Name = "txt_prodno"
        txt_prodno.Size = New Size(212, 23)
        txt_prodno.TabIndex = 0
        ' 
        ' txt_price
        ' 
        txt_price.Location = New Point(59, 182)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(212, 23)
        txt_price.TabIndex = 1
        ' 
        ' txt_prodname
        ' 
        txt_prodname.Location = New Point(58, 123)
        txt_prodname.Name = "txt_prodname"
        txt_prodname.Size = New Size(212, 23)
        txt_prodname.TabIndex = 2
        ' 
        ' combo_prodGroup
        ' 
        combo_prodGroup.FormattingEnabled = True
        combo_prodGroup.Items.AddRange(New Object() {"SWEETS", "COOL DRINKS", "FOODS"})
        combo_prodGroup.Location = New Point(59, 242)
        combo_prodGroup.Name = "combo_prodGroup"
        combo_prodGroup.Size = New Size(212, 23)
        combo_prodGroup.TabIndex = 3
        ' 
        ' exp_datePicker
        ' 
        exp_datePicker.Location = New Point(59, 300)
        exp_datePicker.Name = "exp_datePicker"
        exp_datePicker.Size = New Size(212, 23)
        exp_datePicker.TabIndex = 4
        ' 
        ' status_checkbox
        ' 
        status_checkbox.AutoSize = True
        status_checkbox.Location = New Point(57, 354)
        status_checkbox.Name = "status_checkbox"
        status_checkbox.Size = New Size(74, 19)
        status_checkbox.TabIndex = 5
        status_checkbox.Text = "Available"
        status_checkbox.UseVisualStyleBackColor = True
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.Lime
        btn_save.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn_save.ForeColor = SystemColors.Desktop
        btn_save.Location = New Point(59, 389)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(96, 60)
        btn_save.TabIndex = 6
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' btn_update
        ' 
        btn_update.BackColor = Color.Orange
        btn_update.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn_update.ForeColor = SystemColors.Desktop
        btn_update.Location = New Point(176, 389)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(96, 60)
        btn_update.TabIndex = 7
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.Red
        btn_delete.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn_delete.ForeColor = SystemColors.Desktop
        btn_delete.Location = New Point(59, 457)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(96, 60)
        btn_delete.TabIndex = 8
        btn_delete.Text = "Delete"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' btn_clear
        ' 
        btn_clear.BackColor = Color.White
        btn_clear.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn_clear.ForeColor = SystemColors.Desktop
        btn_clear.Location = New Point(176, 457)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(96, 60)
        btn_clear.TabIndex = 9
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 10
        Label1.Text = "Product No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 11
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(58, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 12
        Label3.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(58, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 15)
        Label4.TabIndex = 13
        Label4.Text = "Product Group"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(58, 282)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 15)
        Label5.TabIndex = 14
        Label5.Text = "Expiration Date"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(295, 123)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(651, 394)
        DataGridView1.TabIndex = 15
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Product Number"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 111
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Product Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Price"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 58
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Group"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 65
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "Exp. Date"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 75
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "Status"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 45
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(294, 41)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 17
        Label6.Text = "Search"
        ' 
        ' txt_search
        ' 
        txt_search.Location = New Point(295, 61)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(212, 23)
        txt_search.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(955, 530)
        Controls.Add(Label6)
        Controls.Add(txt_search)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_clear)
        Controls.Add(btn_delete)
        Controls.Add(btn_update)
        Controls.Add(btn_save)
        Controls.Add(status_checkbox)
        Controls.Add(exp_datePicker)
        Controls.Add(combo_prodGroup)
        Controls.Add(txt_prodname)
        Controls.Add(txt_price)
        Controls.Add(txt_prodno)
        Cursor = Cursors.Hand
        ForeColor = SystemColors.ControlText
        Name = "Form1"
        Text = "CRUD"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_prodno As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_prodname As TextBox
    Friend WithEvents combo_prodGroup As ComboBox
    Friend WithEvents exp_datePicker As DateTimePicker
    Friend WithEvents status_checkbox As CheckBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn

End Class

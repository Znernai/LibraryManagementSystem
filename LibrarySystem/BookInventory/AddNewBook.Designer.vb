﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FormSkin1 = New LibrarySystem.FormSkin()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBookID = New LibrarySystem.FlatLabel()
        Me.FlatLabel6 = New LibrarySystem.FlatLabel()
        Me.txtCopies = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlatLabel5 = New LibrarySystem.FlatLabel()
        Me.txtPublishedYear = New System.Windows.Forms.TextBox()
        Me.FlatLabel4 = New LibrarySystem.FlatLabel()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.FlatLabel3 = New LibrarySystem.FlatLabel()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Publisher = New LibrarySystem.FlatLabel()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.btnAddBook = New System.Windows.Forms.Button()
        Me.FlatLabel2 = New LibrarySystem.FlatLabel()
        Me.FlatLabel1 = New LibrarySystem.FlatLabel()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblErrorZero = New System.Windows.Forms.Label()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.lblErrorZero)
        Me.FormSkin1.Controls.Add(Me.Label6)
        Me.FormSkin1.Controls.Add(Me.lblBookID)
        Me.FormSkin1.Controls.Add(Me.FlatLabel6)
        Me.FormSkin1.Controls.Add(Me.txtCopies)
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel5)
        Me.FormSkin1.Controls.Add(Me.txtPublishedYear)
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.txtCategory)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.txtAuthor)
        Me.FormSkin1.Controls.Add(Me.Publisher)
        Me.FormSkin1.Controls.Add(Me.txtPublisher)
        Me.FormSkin1.Controls.Add(Me.btnAddBook)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.txtTitle)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(406, 463)
        Me.FormSkin1.TabIndex = 1
        Me.FormSkin1.Text = "Add New Book"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(166, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 15)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "All fields are required"
        '
        'lblBookID
        '
        Me.lblBookID.AutoSize = True
        Me.lblBookID.BackColor = System.Drawing.Color.DimGray
        Me.lblBookID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookID.ForeColor = System.Drawing.Color.White
        Me.lblBookID.Location = New System.Drawing.Point(165, 93)
        Me.lblBookID.Name = "lblBookID"
        Me.lblBookID.Size = New System.Drawing.Size(90, 20)
        Me.lblBookID.TabIndex = 95
        Me.lblBookID.Text = "FlatLabel31"
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel6.Location = New System.Drawing.Point(38, 351)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(103, 20)
        Me.FlatLabel6.TabIndex = 94
        Me.FlatLabel6.Text = "No. of Copies"
        '
        'txtCopies
        '
        Me.txtCopies.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCopies.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopies.Location = New System.Drawing.Point(169, 351)
        Me.txtCopies.MaxLength = 4
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.Size = New System.Drawing.Size(52, 20)
        Me.txtCopies.TabIndex = 93
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.btnFormClose
        Me.PictureBox1.Location = New System.Drawing.Point(376, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel5.Location = New System.Drawing.Point(38, 307)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(112, 20)
        Me.FlatLabel5.TabIndex = 12
        Me.FlatLabel5.Text = "Published Year"
        '
        'txtPublishedYear
        '
        Me.txtPublishedYear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPublishedYear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublishedYear.Location = New System.Drawing.Point(169, 307)
        Me.txtPublishedYear.MaxLength = 4
        Me.txtPublishedYear.Name = "txtPublishedYear"
        Me.txtPublishedYear.Size = New System.Drawing.Size(98, 20)
        Me.txtPublishedYear.TabIndex = 11
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel4.Location = New System.Drawing.Point(38, 266)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(72, 20)
        Me.FlatLabel4.TabIndex = 10
        Me.FlatLabel4.Text = "Category"
        '
        'txtCategory
        '
        Me.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCategory.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.Location = New System.Drawing.Point(169, 266)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(187, 20)
        Me.txtCategory.TabIndex = 9
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel3.Location = New System.Drawing.Point(38, 224)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(59, 20)
        Me.FlatLabel3.TabIndex = 8
        Me.FlatLabel3.Text = "Author"
        '
        'txtAuthor
        '
        Me.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAuthor.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(169, 224)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(187, 20)
        Me.txtAuthor.TabIndex = 7
        '
        'Publisher
        '
        Me.Publisher.AutoSize = True
        Me.Publisher.BackColor = System.Drawing.Color.Transparent
        Me.Publisher.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Publisher.ForeColor = System.Drawing.Color.DimGray
        Me.Publisher.Location = New System.Drawing.Point(38, 180)
        Me.Publisher.Name = "Publisher"
        Me.Publisher.Size = New System.Drawing.Size(74, 20)
        Me.Publisher.TabIndex = 6
        Me.Publisher.Text = "Publisher"
        '
        'txtPublisher
        '
        Me.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPublisher.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.Location = New System.Drawing.Point(169, 180)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(187, 20)
        Me.txtPublisher.TabIndex = 5
        '
        'btnAddBook
        '
        Me.btnAddBook.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAddBook.Enabled = False
        Me.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBook.ForeColor = System.Drawing.Color.White
        Me.btnAddBook.Location = New System.Drawing.Point(169, 402)
        Me.btnAddBook.Name = "btnAddBook"
        Me.btnAddBook.Size = New System.Drawing.Size(187, 43)
        Me.btnAddBook.TabIndex = 4
        Me.btnAddBook.Text = "Add Book"
        Me.btnAddBook.UseVisualStyleBackColor = False
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel2.Location = New System.Drawing.Point(38, 134)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(40, 20)
        Me.FlatLabel2.TabIndex = 3
        Me.FlatLabel2.Text = "Title"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.FlatLabel1.Location = New System.Drawing.Point(38, 93)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(61, 20)
        Me.FlatLabel1.TabIndex = 2
        Me.FlatLabel1.Text = "BookID"
        '
        'txtTitle
        '
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(169, 134)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(187, 20)
        Me.txtTitle.TabIndex = 1
        '
        'lblErrorZero
        '
        Me.lblErrorZero.AutoSize = True
        Me.lblErrorZero.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorZero.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorZero.ForeColor = System.Drawing.Color.Red
        Me.lblErrorZero.Location = New System.Drawing.Point(247, 354)
        Me.lblErrorZero.Name = "lblErrorZero"
        Me.lblErrorZero.Size = New System.Drawing.Size(91, 15)
        Me.lblErrorZero.TabIndex = 110
        Me.lblErrorZero.Text = "Cannot be zero"
        Me.lblErrorZero.Visible = False
        '
        'AddNewBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 463)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddNewBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Book"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatLabel1 As LibrarySystem.FlatLabel
    Friend WithEvents FormSkin1 As LibrarySystem.FormSkin
    Friend WithEvents Publisher As LibrarySystem.FlatLabel
    Friend WithEvents txtPublisher As System.Windows.Forms.TextBox
    Friend WithEvents btnAddBook As System.Windows.Forms.Button
    Friend WithEvents FlatLabel2 As LibrarySystem.FlatLabel
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents FlatLabel5 As LibrarySystem.FlatLabel
    Friend WithEvents txtPublishedYear As System.Windows.Forms.TextBox
    Friend WithEvents FlatLabel4 As LibrarySystem.FlatLabel
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents FlatLabel3 As LibrarySystem.FlatLabel
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatLabel6 As LibrarySystem.FlatLabel
    Friend WithEvents txtCopies As System.Windows.Forms.TextBox
    Friend WithEvents lblBookID As LibrarySystem.FlatLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblErrorZero As System.Windows.Forms.Label
End Class

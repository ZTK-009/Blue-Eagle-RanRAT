<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Filemanager
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Filemanager))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestroyFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViweeditTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrypteDecryptTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowPicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAsWallpaperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.RunToolStripMenuItem, Me.RenameToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.UpToolStripMenuItem, Me.DownToolStripMenuItem, Me.OpToolStripMenuItem, Me.DestroyFileToolStripMenuItem, Me.HideFileToolStripMenuItem, Me.ShowFileToolStripMenuItem, Me.NewFolderToolStripMenuItem, Me.NewTextFileToolStripMenuItem, Me.ViweeditTextFileToolStripMenuItem, Me.CrypteDecryptTextToolStripMenuItem, Me.ShowPicToolStripMenuItem, Me.SetAsWallpaperToolStripMenuItem, Me.FileInformationToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(202, 378)
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.BackToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.BackToolStripMenuItem.Image = CType(resources.GetObject("BackToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.RunToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.RunToolStripMenuItem.Image = CType(resources.GetObject("RunToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.RenameToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.RenameToolStripMenuItem.Image = CType(resources.GetObject("RenameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.DeleteToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete "
        '
        'UpToolStripMenuItem
        '
        Me.UpToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.UpToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.UpToolStripMenuItem.Image = CType(resources.GetObject("UpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpToolStripMenuItem.Name = "UpToolStripMenuItem"
        Me.UpToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.UpToolStripMenuItem.Text = "Upload"
        '
        'DownToolStripMenuItem
        '
        Me.DownToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.DownToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.DownToolStripMenuItem.Image = CType(resources.GetObject("DownToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownToolStripMenuItem.Name = "DownToolStripMenuItem"
        Me.DownToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DownToolStripMenuItem.Text = "Download"
        '
        'OpToolStripMenuItem
        '
        Me.OpToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.OpToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.OpToolStripMenuItem.Image = CType(resources.GetObject("OpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpToolStripMenuItem.Name = "OpToolStripMenuItem"
        Me.OpToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.OpToolStripMenuItem.Text = "Open Downloads Folder"
        '
        'DestroyFileToolStripMenuItem
        '
        Me.DestroyFileToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.DestroyFileToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.DestroyFileToolStripMenuItem.Image = CType(resources.GetObject("DestroyFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DestroyFileToolStripMenuItem.Name = "DestroyFileToolStripMenuItem"
        Me.DestroyFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DestroyFileToolStripMenuItem.Text = "Destroy file"
        '
        'HideFileToolStripMenuItem
        '
        Me.HideFileToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.HideFileToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.HideFileToolStripMenuItem.Image = CType(resources.GetObject("HideFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HideFileToolStripMenuItem.Name = "HideFileToolStripMenuItem"
        Me.HideFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.HideFileToolStripMenuItem.Text = "Hide File "
        '
        'ShowFileToolStripMenuItem
        '
        Me.ShowFileToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.ShowFileToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.ShowFileToolStripMenuItem.Image = CType(resources.GetObject("ShowFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowFileToolStripMenuItem.Name = "ShowFileToolStripMenuItem"
        Me.ShowFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ShowFileToolStripMenuItem.Text = "Show File"
        '
        'NewFolderToolStripMenuItem
        '
        Me.NewFolderToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.NewFolderToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.NewFolderToolStripMenuItem.Image = CType(resources.GetObject("NewFolderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewFolderToolStripMenuItem.Name = "NewFolderToolStripMenuItem"
        Me.NewFolderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.NewFolderToolStripMenuItem.Text = "New Folder "
        '
        'NewTextFileToolStripMenuItem
        '
        Me.NewTextFileToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.NewTextFileToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.NewTextFileToolStripMenuItem.Image = CType(resources.GetObject("NewTextFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewTextFileToolStripMenuItem.Name = "NewTextFileToolStripMenuItem"
        Me.NewTextFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.NewTextFileToolStripMenuItem.Text = "New Text File"
        '
        'ViweeditTextFileToolStripMenuItem
        '
        Me.ViweeditTextFileToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.ViweeditTextFileToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.ViweeditTextFileToolStripMenuItem.Image = CType(resources.GetObject("ViweeditTextFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViweeditTextFileToolStripMenuItem.Name = "ViweeditTextFileToolStripMenuItem"
        Me.ViweeditTextFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ViweeditTextFileToolStripMenuItem.Text = "View/Edit Text"
        '
        'CrypteDecryptTextToolStripMenuItem
        '
        Me.CrypteDecryptTextToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.CrypteDecryptTextToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.CrypteDecryptTextToolStripMenuItem.Image = CType(resources.GetObject("CrypteDecryptTextToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CrypteDecryptTextToolStripMenuItem.Name = "CrypteDecryptTextToolStripMenuItem"
        Me.CrypteDecryptTextToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CrypteDecryptTextToolStripMenuItem.Text = "Crypt/Decrypt Text"
        '
        'ShowPicToolStripMenuItem
        '
        Me.ShowPicToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.ShowPicToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.ShowPicToolStripMenuItem.Image = CType(resources.GetObject("ShowPicToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowPicToolStripMenuItem.Name = "ShowPicToolStripMenuItem"
        Me.ShowPicToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ShowPicToolStripMenuItem.Text = "View image"
        '
        'SetAsWallpaperToolStripMenuItem
        '
        Me.SetAsWallpaperToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.SetAsWallpaperToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.SetAsWallpaperToolStripMenuItem.Image = CType(resources.GetObject("SetAsWallpaperToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SetAsWallpaperToolStripMenuItem.Name = "SetAsWallpaperToolStripMenuItem"
        Me.SetAsWallpaperToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SetAsWallpaperToolStripMenuItem.Text = "Set as Wallpaper"
        '
        'FileInformationToolStripMenuItem
        '
        Me.FileInformationToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.FileInformationToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.FileInformationToolStripMenuItem.Image = CType(resources.GetObject("FileInformationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileInformationToolStripMenuItem.Name = "FileInformationToolStripMenuItem"
        Me.FileInformationToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.FileInformationToolStripMenuItem.Text = "File Information"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "0.png")
        Me.ImageList1.Images.SetKeyName(1, "1.png")
        Me.ImageList1.Images.SetKeyName(2, "2.png")
        Me.ImageList1.Images.SetKeyName(3, "3.png")
        Me.ImageList1.Images.SetKeyName(4, "4.png")
        Me.ImageList1.Images.SetKeyName(5, "5.png")
        Me.ImageList1.Images.SetKeyName(6, "6.png")
        Me.ImageList1.Images.SetKeyName(7, "7.png")
        Me.ImageList1.Images.SetKeyName(8, "8.png")
        Me.ImageList1.Images.SetKeyName(9, "9.png")
        Me.ImageList1.Images.SetKeyName(10, "10.png")
        Me.ImageList1.Images.SetKeyName(11, "11.png")
        Me.ImageList1.Images.SetKeyName(12, "12.png")
        Me.ImageList1.Images.SetKeyName(13, "13.png")
        Me.ImageList1.Images.SetKeyName(14, "14.png")
        Me.ImageList1.Images.SetKeyName(15, "15.png")
        Me.ImageList1.Images.SetKeyName(16, "16.png")
        Me.ImageList1.Images.SetKeyName(17, "17.png")
        Me.ImageList1.Images.SetKeyName(18, "18.png")
        Me.ImageList1.Images.SetKeyName(19, "19.png")
        Me.ImageList1.Images.SetKeyName(20, "20.png")
        Me.ImageList1.Images.SetKeyName(21, "21.png")
        Me.ImageList1.Images.SetKeyName(22, "22.png")
        Me.ImageList1.Images.SetKeyName(23, "23.png")
        Me.ImageList1.Images.SetKeyName(24, "24.png")
        Me.ImageList1.Images.SetKeyName(25, "25.png")
        Me.ImageList1.Images.SetKeyName(26, "26.png")
        Me.ImageList1.Images.SetKeyName(27, "27.png")
        Me.ImageList1.Images.SetKeyName(28, "28.png")
        Me.ImageList1.Images.SetKeyName(29, "29.png")
        Me.ImageList1.Images.SetKeyName(30, "30.png")
        Me.ImageList1.Images.SetKeyName(31, "31.png")
        Me.ImageList1.Images.SetKeyName(32, "32.png")
        Me.ImageList1.Images.SetKeyName(33, "33.png")
        Me.ImageList1.Images.SetKeyName(34, "34.png")
        Me.ImageList1.Images.SetKeyName(35, "35.png")
        Me.ImageList1.Images.SetKeyName(36, "36.png")
        Me.ImageList1.Images.SetKeyName(37, "37.png")
        Me.ImageList1.Images.SetKeyName(38, "38.png")
        Me.ImageList1.Images.SetKeyName(39, "39.png")
        Me.ImageList1.Images.SetKeyName(40, "40.png")
        Me.ImageList1.Images.SetKeyName(41, "41.png")
        Me.ImageList1.Images.SetKeyName(42, "42.png")
        Me.ImageList1.Images.SetKeyName(43, "43.png")
        Me.ImageList1.Images.SetKeyName(44, "44.png")
        Me.ImageList1.Images.SetKeyName(45, "45.png")
        Me.ImageList1.Images.SetKeyName(46, "46.png")
        Me.ImageList1.Images.SetKeyName(47, "47.png")
        Me.ImageList1.Images.SetKeyName(48, "48.png")
        Me.ImageList1.Images.SetKeyName(49, "49.png")
        Me.ImageList1.Images.SetKeyName(50, "50.png")
        Me.ImageList1.Images.SetKeyName(51, "51.png")
        Me.ImageList1.Images.SetKeyName(52, "52.png")
        Me.ImageList1.Images.SetKeyName(53, "53.png")
        Me.ImageList1.Images.SetKeyName(54, "54.png")
        Me.ImageList1.Images.SetKeyName(55, "55.png")
        Me.ImageList1.Images.SetKeyName(56, "56.png")
        Me.ImageList1.Images.SetKeyName(57, "57.png")
        Me.ImageList1.Images.SetKeyName(58, "Icons-Land-Vista-Hardware-Devices-USB-Flash-Card-With-Card-Reader.ico")
        Me.ImageList1.Images.SetKeyName(59, "Treetog-Junior-Network.ico")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 82)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Button6)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(768, 54)
        Me.Panel4.TabIndex = 4
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Black
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.Snow
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(624, 22)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(133, 25)
        Me.Button8.TabIndex = 51
        Me.Button8.Text = "My Pictures"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.Snow
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(547, 22)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 25)
        Me.Button7.TabIndex = 50
        Me.Button7.Text = "My Music"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Snow
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(408, 22)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 25)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "My Documents"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Snow
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(327, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 25)
        Me.Button5.TabIndex = 48
        Me.Button5.Text = "Temp"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Black
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.Snow
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(245, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 25)
        Me.Button6.TabIndex = 47
        Me.Button6.Text = "Desktop"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Snow
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(167, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 25)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "History"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Snow
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(85, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 25)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Recent"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Startup"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(7, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Quck Paths"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(768, 28)
        Me.Panel3.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Snow
        Me.TextBox1.Location = New System.Drawing.Point(40, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(728, 23)
        Me.TextBox1.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Path"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Controls.Add(Me.pic1)
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 82)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(768, 512)
        Me.Panel2.TabIndex = 2
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.Transparent
        Me.pic1.BackgroundImage = CType(resources.GetObject("pic1.BackgroundImage"), System.Drawing.Image)
        Me.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic1.Location = New System.Drawing.Point(287, 92)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(478, 323)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 21
        Me.pic1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.FullRowSelect = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(768, 512)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File Name / Dir."
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "File Size"
        Me.ColumnHeader2.Width = 136
        '
        'Filemanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(768, 594)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.ForeColor = System.Drawing.Color.Snow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Filemanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filemanager"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DestroyFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViweeditTextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrypteDecryptTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowPicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetAsWallpaperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FileInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

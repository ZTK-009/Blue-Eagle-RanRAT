<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MapGadget
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MapGadget))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.logger = New System.Windows.Forms.RichTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.firepic = New System.Windows.Forms.PictureBox()
        Me.Flager = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.firepic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 20)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hacker FullScreen Mode   - Saher Blue Eagle RanRAT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(752, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 648)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client logs"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.ForeColor = System.Drawing.Color.Snow
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(3, 18)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(189, 627)
        Me.ListBox1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 20)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox6)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox7)
        Me.SplitContainer1.Size = New System.Drawing.Size(752, 648)
        Me.SplitContainer1.SplitterDistance = 438
        Me.SplitContainer1.TabIndex = 6
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.logger)
        Me.GroupBox6.Controls.Add(Me.PictureBox2)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(752, 438)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Clients Connections Localization"
        '
        'logger
        '
        Me.logger.Location = New System.Drawing.Point(133, -317)
        Me.logger.Name = "logger"
        Me.logger.Size = New System.Drawing.Size(487, 254)
        Me.logger.TabIndex = 4
        Me.logger.Text = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(746, 417)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RichTextBox1)
        Me.GroupBox7.Controls.Add(Me.firepic)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(752, 206)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Program Console"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Lime
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 18)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(746, 185)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'firepic
        '
        Me.firepic.Image = CType(resources.GetObject("firepic.Image"), System.Drawing.Image)
        Me.firepic.Location = New System.Drawing.Point(221, 64)
        Me.firepic.Name = "firepic"
        Me.firepic.Size = New System.Drawing.Size(101, 50)
        Me.firepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.firepic.TabIndex = 3
        Me.firepic.TabStop = False
        '
        'Flager
        '
        Me.Flager.Interval = 50
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1 - Copy.gif")
        Me.ImageList1.Images.SetKeyName(1, "1.gif")
        Me.ImageList1.Images.SetKeyName(2, "2.gif")
        Me.ImageList1.Images.SetKeyName(3, "3.gif")
        Me.ImageList1.Images.SetKeyName(4, "4.gif")
        Me.ImageList1.Images.SetKeyName(5, "5.gif")
        Me.ImageList1.Images.SetKeyName(6, "6.gif")
        Me.ImageList1.Images.SetKeyName(7, "7.gif")
        Me.ImageList1.Images.SetKeyName(8, "8.gif")
        Me.ImageList1.Images.SetKeyName(9, "9.gif")
        Me.ImageList1.Images.SetKeyName(10, "10.gif")
        Me.ImageList1.Images.SetKeyName(11, "11.gif")
        Me.ImageList1.Images.SetKeyName(12, "12.gif")
        Me.ImageList1.Images.SetKeyName(13, "13.gif")
        Me.ImageList1.Images.SetKeyName(14, "14.gif")
        Me.ImageList1.Images.SetKeyName(15, "15.gif")
        Me.ImageList1.Images.SetKeyName(16, "16.gif")
        Me.ImageList1.Images.SetKeyName(17, "17.gif")
        Me.ImageList1.Images.SetKeyName(18, "18.gif")
        Me.ImageList1.Images.SetKeyName(19, "19.gif")
        Me.ImageList1.Images.SetKeyName(20, "20.gif")
        Me.ImageList1.Images.SetKeyName(21, "21.gif")
        Me.ImageList1.Images.SetKeyName(22, "22.gif")
        Me.ImageList1.Images.SetKeyName(23, "23.gif")
        Me.ImageList1.Images.SetKeyName(24, "24.gif")
        Me.ImageList1.Images.SetKeyName(25, "25.gif")
        Me.ImageList1.Images.SetKeyName(26, "26.gif")
        Me.ImageList1.Images.SetKeyName(27, "27.gif")
        Me.ImageList1.Images.SetKeyName(28, "28.gif")
        Me.ImageList1.Images.SetKeyName(29, "29.gif")
        Me.ImageList1.Images.SetKeyName(30, "30.gif")
        Me.ImageList1.Images.SetKeyName(31, "31.gif")
        Me.ImageList1.Images.SetKeyName(32, "32.gif")
        Me.ImageList1.Images.SetKeyName(33, "33.gif")
        Me.ImageList1.Images.SetKeyName(34, "34.gif")
        Me.ImageList1.Images.SetKeyName(35, "35.gif")
        Me.ImageList1.Images.SetKeyName(36, "36.gif")
        Me.ImageList1.Images.SetKeyName(37, "37.gif")
        Me.ImageList1.Images.SetKeyName(38, "38.gif")
        Me.ImageList1.Images.SetKeyName(39, "39.gif")
        Me.ImageList1.Images.SetKeyName(40, "40.gif")
        Me.ImageList1.Images.SetKeyName(41, "41.gif")
        Me.ImageList1.Images.SetKeyName(42, "42.gif")
        Me.ImageList1.Images.SetKeyName(43, "43.gif")
        Me.ImageList1.Images.SetKeyName(44, "44.gif")
        Me.ImageList1.Images.SetKeyName(45, "45.gif")
        Me.ImageList1.Images.SetKeyName(46, "46.gif")
        Me.ImageList1.Images.SetKeyName(47, "47.gif")
        Me.ImageList1.Images.SetKeyName(48, "48.gif")
        Me.ImageList1.Images.SetKeyName(49, "49.gif")
        Me.ImageList1.Images.SetKeyName(50, "50.gif")
        Me.ImageList1.Images.SetKeyName(51, "51.gif")
        Me.ImageList1.Images.SetKeyName(52, "52.gif")
        Me.ImageList1.Images.SetKeyName(53, "53.gif")
        Me.ImageList1.Images.SetKeyName(54, "54.gif")
        Me.ImageList1.Images.SetKeyName(55, "55.gif")
        Me.ImageList1.Images.SetKeyName(56, "56.gif")
        Me.ImageList1.Images.SetKeyName(57, "57.gif")
        Me.ImageList1.Images.SetKeyName(58, "58.gif")
        Me.ImageList1.Images.SetKeyName(59, "59.gif")
        Me.ImageList1.Images.SetKeyName(60, "60.gif")
        Me.ImageList1.Images.SetKeyName(61, "61.gif")
        Me.ImageList1.Images.SetKeyName(62, "62.gif")
        Me.ImageList1.Images.SetKeyName(63, "63.gif")
        Me.ImageList1.Images.SetKeyName(64, "64.gif")
        Me.ImageList1.Images.SetKeyName(65, "65.gif")
        Me.ImageList1.Images.SetKeyName(66, "66.gif")
        Me.ImageList1.Images.SetKeyName(67, "67.gif")
        Me.ImageList1.Images.SetKeyName(68, "68.gif")
        Me.ImageList1.Images.SetKeyName(69, "69.gif")
        Me.ImageList1.Images.SetKeyName(70, "70.gif")
        Me.ImageList1.Images.SetKeyName(71, "71.gif")
        Me.ImageList1.Images.SetKeyName(72, "72.gif")
        Me.ImageList1.Images.SetKeyName(73, "73.gif")
        Me.ImageList1.Images.SetKeyName(74, "74.gif")
        Me.ImageList1.Images.SetKeyName(75, "75.gif")
        Me.ImageList1.Images.SetKeyName(76, "76.gif")
        Me.ImageList1.Images.SetKeyName(77, "77.gif")
        Me.ImageList1.Images.SetKeyName(78, "78.gif")
        Me.ImageList1.Images.SetKeyName(79, "79.gif")
        Me.ImageList1.Images.SetKeyName(80, "80.gif")
        Me.ImageList1.Images.SetKeyName(81, "81.gif")
        Me.ImageList1.Images.SetKeyName(82, "82.gif")
        Me.ImageList1.Images.SetKeyName(83, "83.gif")
        Me.ImageList1.Images.SetKeyName(84, "84.gif")
        Me.ImageList1.Images.SetKeyName(85, "85.gif")
        Me.ImageList1.Images.SetKeyName(86, "86.gif")
        Me.ImageList1.Images.SetKeyName(87, "87.gif")
        Me.ImageList1.Images.SetKeyName(88, "88.gif")
        Me.ImageList1.Images.SetKeyName(89, "89.gif")
        Me.ImageList1.Images.SetKeyName(90, "90.gif")
        Me.ImageList1.Images.SetKeyName(91, "91.gif")
        Me.ImageList1.Images.SetKeyName(92, "92.gif")
        Me.ImageList1.Images.SetKeyName(93, "93.gif")
        Me.ImageList1.Images.SetKeyName(94, "94.gif")
        Me.ImageList1.Images.SetKeyName(95, "95.gif")
        Me.ImageList1.Images.SetKeyName(96, "96.gif")
        Me.ImageList1.Images.SetKeyName(97, "97.gif")
        Me.ImageList1.Images.SetKeyName(98, "98.gif")
        Me.ImageList1.Images.SetKeyName(99, "99.gif")
        Me.ImageList1.Images.SetKeyName(100, "100.gif")
        Me.ImageList1.Images.SetKeyName(101, "101.gif")
        Me.ImageList1.Images.SetKeyName(102, "102.gif")
        Me.ImageList1.Images.SetKeyName(103, "103.gif")
        Me.ImageList1.Images.SetKeyName(104, "104.gif")
        Me.ImageList1.Images.SetKeyName(105, "105.gif")
        Me.ImageList1.Images.SetKeyName(106, "106.gif")
        Me.ImageList1.Images.SetKeyName(107, "107.gif")
        Me.ImageList1.Images.SetKeyName(108, "108.gif")
        Me.ImageList1.Images.SetKeyName(109, "109.gif")
        Me.ImageList1.Images.SetKeyName(110, "110.gif")
        Me.ImageList1.Images.SetKeyName(111, "111.gif")
        Me.ImageList1.Images.SetKeyName(112, "112.gif")
        Me.ImageList1.Images.SetKeyName(113, "113.gif")
        Me.ImageList1.Images.SetKeyName(114, "114.gif")
        Me.ImageList1.Images.SetKeyName(115, "115.gif")
        Me.ImageList1.Images.SetKeyName(116, "116.gif")
        Me.ImageList1.Images.SetKeyName(117, "117.gif")
        Me.ImageList1.Images.SetKeyName(118, "118.gif")
        Me.ImageList1.Images.SetKeyName(119, "119.gif")
        Me.ImageList1.Images.SetKeyName(120, "120.gif")
        Me.ImageList1.Images.SetKeyName(121, "121.gif")
        Me.ImageList1.Images.SetKeyName(122, "122.gif")
        Me.ImageList1.Images.SetKeyName(123, "123.gif")
        Me.ImageList1.Images.SetKeyName(124, "124.gif")
        Me.ImageList1.Images.SetKeyName(125, "125.gif")
        Me.ImageList1.Images.SetKeyName(126, "126.gif")
        Me.ImageList1.Images.SetKeyName(127, "127.gif")
        Me.ImageList1.Images.SetKeyName(128, "128.gif")
        Me.ImageList1.Images.SetKeyName(129, "129.gif")
        Me.ImageList1.Images.SetKeyName(130, "130.gif")
        Me.ImageList1.Images.SetKeyName(131, "131.gif")
        Me.ImageList1.Images.SetKeyName(132, "132.gif")
        Me.ImageList1.Images.SetKeyName(133, "133.gif")
        Me.ImageList1.Images.SetKeyName(134, "134.gif")
        Me.ImageList1.Images.SetKeyName(135, "135.gif")
        Me.ImageList1.Images.SetKeyName(136, "136.gif")
        Me.ImageList1.Images.SetKeyName(137, "137.gif")
        Me.ImageList1.Images.SetKeyName(138, "138.gif")
        Me.ImageList1.Images.SetKeyName(139, "139.gif")
        Me.ImageList1.Images.SetKeyName(140, "140.gif")
        Me.ImageList1.Images.SetKeyName(141, "141.gif")
        Me.ImageList1.Images.SetKeyName(142, "142.gif")
        Me.ImageList1.Images.SetKeyName(143, "143.gif")
        Me.ImageList1.Images.SetKeyName(144, "144.gif")
        Me.ImageList1.Images.SetKeyName(145, "145.gif")
        Me.ImageList1.Images.SetKeyName(146, "146.gif")
        Me.ImageList1.Images.SetKeyName(147, "147.gif")
        Me.ImageList1.Images.SetKeyName(148, "148.gif")
        Me.ImageList1.Images.SetKeyName(149, "149.gif")
        Me.ImageList1.Images.SetKeyName(150, "150.gif")
        Me.ImageList1.Images.SetKeyName(151, "151.gif")
        Me.ImageList1.Images.SetKeyName(152, "152.gif")
        Me.ImageList1.Images.SetKeyName(153, "153.gif")
        Me.ImageList1.Images.SetKeyName(154, "154.gif")
        Me.ImageList1.Images.SetKeyName(155, "155.gif")
        Me.ImageList1.Images.SetKeyName(156, "156.gif")
        Me.ImageList1.Images.SetKeyName(157, "157.gif")
        Me.ImageList1.Images.SetKeyName(158, "158.gif")
        Me.ImageList1.Images.SetKeyName(159, "159.gif")
        Me.ImageList1.Images.SetKeyName(160, "160.gif")
        Me.ImageList1.Images.SetKeyName(161, "161.gif")
        Me.ImageList1.Images.SetKeyName(162, "162.gif")
        Me.ImageList1.Images.SetKeyName(163, "163.gif")
        Me.ImageList1.Images.SetKeyName(164, "164.gif")
        Me.ImageList1.Images.SetKeyName(165, "165.gif")
        Me.ImageList1.Images.SetKeyName(166, "166.gif")
        Me.ImageList1.Images.SetKeyName(167, "167.gif")
        Me.ImageList1.Images.SetKeyName(168, "168.gif")
        Me.ImageList1.Images.SetKeyName(169, "169.gif")
        Me.ImageList1.Images.SetKeyName(170, "170.gif")
        Me.ImageList1.Images.SetKeyName(171, "171.gif")
        Me.ImageList1.Images.SetKeyName(172, "172.gif")
        Me.ImageList1.Images.SetKeyName(173, "173.gif")
        Me.ImageList1.Images.SetKeyName(174, "174.gif")
        Me.ImageList1.Images.SetKeyName(175, "175.gif")
        Me.ImageList1.Images.SetKeyName(176, "176.gif")
        Me.ImageList1.Images.SetKeyName(177, "177.gif")
        Me.ImageList1.Images.SetKeyName(178, "178.gif")
        Me.ImageList1.Images.SetKeyName(179, "179.gif")
        Me.ImageList1.Images.SetKeyName(180, "180.gif")
        Me.ImageList1.Images.SetKeyName(181, "181.gif")
        Me.ImageList1.Images.SetKeyName(182, "182.gif")
        Me.ImageList1.Images.SetKeyName(183, "183.gif")
        Me.ImageList1.Images.SetKeyName(184, "184.gif")
        Me.ImageList1.Images.SetKeyName(185, "185.gif")
        Me.ImageList1.Images.SetKeyName(186, "186.gif")
        Me.ImageList1.Images.SetKeyName(187, "187.gif")
        Me.ImageList1.Images.SetKeyName(188, "188.gif")
        Me.ImageList1.Images.SetKeyName(189, "189.gif")
        Me.ImageList1.Images.SetKeyName(190, "190.gif")
        Me.ImageList1.Images.SetKeyName(191, "191.gif")
        Me.ImageList1.Images.SetKeyName(192, "192.gif")
        Me.ImageList1.Images.SetKeyName(193, "193.gif")
        Me.ImageList1.Images.SetKeyName(194, "194.gif")
        Me.ImageList1.Images.SetKeyName(195, "195.gif")
        Me.ImageList1.Images.SetKeyName(196, "196.gif")
        Me.ImageList1.Images.SetKeyName(197, "197.gif")
        Me.ImageList1.Images.SetKeyName(198, "198.gif")
        Me.ImageList1.Images.SetKeyName(199, "199.gif")
        Me.ImageList1.Images.SetKeyName(200, "200.gif")
        Me.ImageList1.Images.SetKeyName(201, "201.gif")
        Me.ImageList1.Images.SetKeyName(202, "202.gif")
        Me.ImageList1.Images.SetKeyName(203, "203.gif")
        Me.ImageList1.Images.SetKeyName(204, "204.gif")
        Me.ImageList1.Images.SetKeyName(205, "205.gif")
        Me.ImageList1.Images.SetKeyName(206, "206.gif")
        Me.ImageList1.Images.SetKeyName(207, "207.jpg")
        Me.ImageList1.Images.SetKeyName(208, "208.gif")
        Me.ImageList1.Images.SetKeyName(209, "209.gif")
        Me.ImageList1.Images.SetKeyName(210, "210.gif")
        Me.ImageList1.Images.SetKeyName(211, "211.gif")
        Me.ImageList1.Images.SetKeyName(212, "212.gif")
        Me.ImageList1.Images.SetKeyName(213, "213.gif")
        Me.ImageList1.Images.SetKeyName(214, "214.gif")
        Me.ImageList1.Images.SetKeyName(215, "215.gif")
        Me.ImageList1.Images.SetKeyName(216, "216.gif")
        Me.ImageList1.Images.SetKeyName(217, "217.gif")
        Me.ImageList1.Images.SetKeyName(218, "218.gif")
        Me.ImageList1.Images.SetKeyName(219, "219.gif")
        Me.ImageList1.Images.SetKeyName(220, "220.gif")
        Me.ImageList1.Images.SetKeyName(221, "221.gif")
        Me.ImageList1.Images.SetKeyName(222, "222.gif")
        Me.ImageList1.Images.SetKeyName(223, "223.gif")
        Me.ImageList1.Images.SetKeyName(224, "224.gif")
        Me.ImageList1.Images.SetKeyName(225, "225.gif")
        Me.ImageList1.Images.SetKeyName(226, "226.gif")
        Me.ImageList1.Images.SetKeyName(227, "227.gif")
        Me.ImageList1.Images.SetKeyName(228, "228.gif")
        Me.ImageList1.Images.SetKeyName(229, "229.gif")
        Me.ImageList1.Images.SetKeyName(230, "230.gif")
        Me.ImageList1.Images.SetKeyName(231, "231.gif")
        Me.ImageList1.Images.SetKeyName(232, "232.gif")
        Me.ImageList1.Images.SetKeyName(233, "233.gif")
        Me.ImageList1.Images.SetKeyName(234, "234.gif")
        Me.ImageList1.Images.SetKeyName(235, "235.gif")
        Me.ImageList1.Images.SetKeyName(236, "236.gif")
        Me.ImageList1.Images.SetKeyName(237, "237.gif")
        Me.ImageList1.Images.SetKeyName(238, "238.gif")
        Me.ImageList1.Images.SetKeyName(239, "239.gif")
        Me.ImageList1.Images.SetKeyName(240, "240.gif")
        Me.ImageList1.Images.SetKeyName(241, "241.gif")
        Me.ImageList1.Images.SetKeyName(242, "basic.png")
        Me.ImageList1.Images.SetKeyName(243, "connections.png")
        Me.ImageList1.Images.SetKeyName(244, "group.png")
        Me.ImageList1.Images.SetKeyName(245, "misc.png")
        Me.ImageList1.Images.SetKeyName(246, "user.png")
        Me.ImageList1.Images.SetKeyName(247, "user_gray.png")
        Me.ImageList1.Images.SetKeyName(248, "001.png")
        Me.ImageList1.Images.SetKeyName(249, "002.png")
        Me.ImageList1.Images.SetKeyName(250, "003.png")
        Me.ImageList1.Images.SetKeyName(251, "004.png")
        Me.ImageList1.Images.SetKeyName(252, "005.png")
        Me.ImageList1.Images.SetKeyName(253, "006.png")
        Me.ImageList1.Images.SetKeyName(254, "007.png")
        Me.ImageList1.Images.SetKeyName(255, "008.png")
        Me.ImageList1.Images.SetKeyName(256, "009.png")
        Me.ImageList1.Images.SetKeyName(257, "010.png")
        Me.ImageList1.Images.SetKeyName(258, "011.png")
        Me.ImageList1.Images.SetKeyName(259, "012.png")
        Me.ImageList1.Images.SetKeyName(260, "013.png")
        Me.ImageList1.Images.SetKeyName(261, "014.png")
        Me.ImageList1.Images.SetKeyName(262, "015.png")
        Me.ImageList1.Images.SetKeyName(263, "016.png")
        Me.ImageList1.Images.SetKeyName(264, "017.png")
        Me.ImageList1.Images.SetKeyName(265, "018.png")
        Me.ImageList1.Images.SetKeyName(266, "019.png")
        Me.ImageList1.Images.SetKeyName(267, "020.png")
        Me.ImageList1.Images.SetKeyName(268, "021.png")
        Me.ImageList1.Images.SetKeyName(269, "022.png")
        Me.ImageList1.Images.SetKeyName(270, "023.png")
        Me.ImageList1.Images.SetKeyName(271, "024.png")
        Me.ImageList1.Images.SetKeyName(272, "025.png")
        Me.ImageList1.Images.SetKeyName(273, "026.png")
        Me.ImageList1.Images.SetKeyName(274, "027.png")
        Me.ImageList1.Images.SetKeyName(275, "028.png")
        Me.ImageList1.Images.SetKeyName(276, "029.png")
        Me.ImageList1.Images.SetKeyName(277, "030.png")
        Me.ImageList1.Images.SetKeyName(278, "031.png")
        Me.ImageList1.Images.SetKeyName(279, "032.png")
        Me.ImageList1.Images.SetKeyName(280, "033.png")
        Me.ImageList1.Images.SetKeyName(281, "034.png")
        Me.ImageList1.Images.SetKeyName(282, "035.png")
        Me.ImageList1.Images.SetKeyName(283, "036.png")
        Me.ImageList1.Images.SetKeyName(284, "037.png")
        Me.ImageList1.Images.SetKeyName(285, "038.png")
        Me.ImageList1.Images.SetKeyName(286, "039.png")
        Me.ImageList1.Images.SetKeyName(287, "040.png")
        Me.ImageList1.Images.SetKeyName(288, "041.png")
        Me.ImageList1.Images.SetKeyName(289, "042.png")
        Me.ImageList1.Images.SetKeyName(290, "043.png")
        Me.ImageList1.Images.SetKeyName(291, "044.png")
        Me.ImageList1.Images.SetKeyName(292, "045.png")
        Me.ImageList1.Images.SetKeyName(293, "046.png")
        Me.ImageList1.Images.SetKeyName(294, "047.png")
        Me.ImageList1.Images.SetKeyName(295, "048.png")
        Me.ImageList1.Images.SetKeyName(296, "049.png")
        Me.ImageList1.Images.SetKeyName(297, "050.png")
        Me.ImageList1.Images.SetKeyName(298, "051.png")
        Me.ImageList1.Images.SetKeyName(299, "052.png")
        Me.ImageList1.Images.SetKeyName(300, "053.png")
        Me.ImageList1.Images.SetKeyName(301, "054.png")
        Me.ImageList1.Images.SetKeyName(302, "055.png")
        Me.ImageList1.Images.SetKeyName(303, "056.png")
        Me.ImageList1.Images.SetKeyName(304, "057.png")
        Me.ImageList1.Images.SetKeyName(305, "058.png")
        Me.ImageList1.Images.SetKeyName(306, "059.png")
        Me.ImageList1.Images.SetKeyName(307, "060.png")
        Me.ImageList1.Images.SetKeyName(308, "061.png")
        Me.ImageList1.Images.SetKeyName(309, "062.png")
        Me.ImageList1.Images.SetKeyName(310, "063.png")
        Me.ImageList1.Images.SetKeyName(311, "064.png")
        Me.ImageList1.Images.SetKeyName(312, "065.png")
        Me.ImageList1.Images.SetKeyName(313, "066.png")
        Me.ImageList1.Images.SetKeyName(314, "067.png")
        Me.ImageList1.Images.SetKeyName(315, "068.png")
        Me.ImageList1.Images.SetKeyName(316, "069.png")
        Me.ImageList1.Images.SetKeyName(317, "070.png")
        Me.ImageList1.Images.SetKeyName(318, "071.png")
        Me.ImageList1.Images.SetKeyName(319, "072.png")
        Me.ImageList1.Images.SetKeyName(320, "073.png")
        Me.ImageList1.Images.SetKeyName(321, "074.png")
        Me.ImageList1.Images.SetKeyName(322, "075.png")
        Me.ImageList1.Images.SetKeyName(323, "076.png")
        Me.ImageList1.Images.SetKeyName(324, "077.png")
        Me.ImageList1.Images.SetKeyName(325, "078.png")
        Me.ImageList1.Images.SetKeyName(326, "079.png")
        Me.ImageList1.Images.SetKeyName(327, "080.png")
        Me.ImageList1.Images.SetKeyName(328, "081.png")
        Me.ImageList1.Images.SetKeyName(329, "082.png")
        Me.ImageList1.Images.SetKeyName(330, "083.png")
        Me.ImageList1.Images.SetKeyName(331, "084.png")
        Me.ImageList1.Images.SetKeyName(332, "085.png")
        Me.ImageList1.Images.SetKeyName(333, "086.png")
        Me.ImageList1.Images.SetKeyName(334, "087.png")
        Me.ImageList1.Images.SetKeyName(335, "088.png")
        Me.ImageList1.Images.SetKeyName(336, "089.png")
        Me.ImageList1.Images.SetKeyName(337, "090.png")
        Me.ImageList1.Images.SetKeyName(338, "091.png")
        Me.ImageList1.Images.SetKeyName(339, "092.png")
        Me.ImageList1.Images.SetKeyName(340, "093.png")
        Me.ImageList1.Images.SetKeyName(341, "094.png")
        Me.ImageList1.Images.SetKeyName(342, "095.png")
        Me.ImageList1.Images.SetKeyName(343, "096.png")
        Me.ImageList1.Images.SetKeyName(344, "097.png")
        Me.ImageList1.Images.SetKeyName(345, "098.png")
        Me.ImageList1.Images.SetKeyName(346, "099.png")
        Me.ImageList1.Images.SetKeyName(347, "100.png")
        Me.ImageList1.Images.SetKeyName(348, "101.png")
        Me.ImageList1.Images.SetKeyName(349, "102.png")
        Me.ImageList1.Images.SetKeyName(350, "103.png")
        Me.ImageList1.Images.SetKeyName(351, "104.png")
        Me.ImageList1.Images.SetKeyName(352, "105.png")
        Me.ImageList1.Images.SetKeyName(353, "106.png")
        Me.ImageList1.Images.SetKeyName(354, "107.png")
        Me.ImageList1.Images.SetKeyName(355, "108.png")
        Me.ImageList1.Images.SetKeyName(356, "109.png")
        Me.ImageList1.Images.SetKeyName(357, "110.png")
        Me.ImageList1.Images.SetKeyName(358, "111.png")
        Me.ImageList1.Images.SetKeyName(359, "112.png")
        Me.ImageList1.Images.SetKeyName(360, "113.png")
        Me.ImageList1.Images.SetKeyName(361, "114.png")
        Me.ImageList1.Images.SetKeyName(362, "115.png")
        Me.ImageList1.Images.SetKeyName(363, "116.png")
        Me.ImageList1.Images.SetKeyName(364, "117.png")
        Me.ImageList1.Images.SetKeyName(365, "118.png")
        Me.ImageList1.Images.SetKeyName(366, "119.png")
        Me.ImageList1.Images.SetKeyName(367, "120.png")
        Me.ImageList1.Images.SetKeyName(368, "121.png")
        Me.ImageList1.Images.SetKeyName(369, "122.png")
        Me.ImageList1.Images.SetKeyName(370, "123.png")
        Me.ImageList1.Images.SetKeyName(371, "124.png")
        Me.ImageList1.Images.SetKeyName(372, "125.png")
        Me.ImageList1.Images.SetKeyName(373, "126.png")
        Me.ImageList1.Images.SetKeyName(374, "127.png")
        Me.ImageList1.Images.SetKeyName(375, "128.png")
        Me.ImageList1.Images.SetKeyName(376, "129.png")
        Me.ImageList1.Images.SetKeyName(377, "130.png")
        Me.ImageList1.Images.SetKeyName(378, "131.png")
        Me.ImageList1.Images.SetKeyName(379, "132.png")
        Me.ImageList1.Images.SetKeyName(380, "133.png")
        Me.ImageList1.Images.SetKeyName(381, "134.png")
        Me.ImageList1.Images.SetKeyName(382, "135.png")
        Me.ImageList1.Images.SetKeyName(383, "136.png")
        Me.ImageList1.Images.SetKeyName(384, "137.png")
        Me.ImageList1.Images.SetKeyName(385, "138.png")
        Me.ImageList1.Images.SetKeyName(386, "139.png")
        Me.ImageList1.Images.SetKeyName(387, "140.png")
        Me.ImageList1.Images.SetKeyName(388, "141.png")
        Me.ImageList1.Images.SetKeyName(389, "142.png")
        Me.ImageList1.Images.SetKeyName(390, "143.png")
        Me.ImageList1.Images.SetKeyName(391, "144.png")
        Me.ImageList1.Images.SetKeyName(392, "145.png")
        Me.ImageList1.Images.SetKeyName(393, "146.png")
        Me.ImageList1.Images.SetKeyName(394, "147.png")
        Me.ImageList1.Images.SetKeyName(395, "148.png")
        Me.ImageList1.Images.SetKeyName(396, "149.png")
        Me.ImageList1.Images.SetKeyName(397, "150.png")
        Me.ImageList1.Images.SetKeyName(398, "151.png")
        Me.ImageList1.Images.SetKeyName(399, "152.png")
        Me.ImageList1.Images.SetKeyName(400, "153.png")
        Me.ImageList1.Images.SetKeyName(401, "154.png")
        Me.ImageList1.Images.SetKeyName(402, "155.png")
        Me.ImageList1.Images.SetKeyName(403, "156.png")
        Me.ImageList1.Images.SetKeyName(404, "157.png")
        Me.ImageList1.Images.SetKeyName(405, "158.png")
        Me.ImageList1.Images.SetKeyName(406, "159.png")
        Me.ImageList1.Images.SetKeyName(407, "160.png")
        Me.ImageList1.Images.SetKeyName(408, "161.png")
        Me.ImageList1.Images.SetKeyName(409, "162.png")
        Me.ImageList1.Images.SetKeyName(410, "163.png")
        Me.ImageList1.Images.SetKeyName(411, "164.png")
        Me.ImageList1.Images.SetKeyName(412, "165.png")
        Me.ImageList1.Images.SetKeyName(413, "166.png")
        Me.ImageList1.Images.SetKeyName(414, "167.png")
        Me.ImageList1.Images.SetKeyName(415, "168.png")
        Me.ImageList1.Images.SetKeyName(416, "169.png")
        Me.ImageList1.Images.SetKeyName(417, "170.png")
        Me.ImageList1.Images.SetKeyName(418, "171.png")
        Me.ImageList1.Images.SetKeyName(419, "172.png")
        Me.ImageList1.Images.SetKeyName(420, "173.png")
        Me.ImageList1.Images.SetKeyName(421, "174.png")
        Me.ImageList1.Images.SetKeyName(422, "175.png")
        Me.ImageList1.Images.SetKeyName(423, "176.png")
        Me.ImageList1.Images.SetKeyName(424, "177.png")
        Me.ImageList1.Images.SetKeyName(425, "178.png")
        Me.ImageList1.Images.SetKeyName(426, "179.png")
        Me.ImageList1.Images.SetKeyName(427, "180.png")
        Me.ImageList1.Images.SetKeyName(428, "181.png")
        Me.ImageList1.Images.SetKeyName(429, "182.png")
        Me.ImageList1.Images.SetKeyName(430, "183.png")
        Me.ImageList1.Images.SetKeyName(431, "184.png")
        Me.ImageList1.Images.SetKeyName(432, "185.png")
        Me.ImageList1.Images.SetKeyName(433, "186.png")
        Me.ImageList1.Images.SetKeyName(434, "187.png")
        Me.ImageList1.Images.SetKeyName(435, "188.png")
        Me.ImageList1.Images.SetKeyName(436, "189.png")
        Me.ImageList1.Images.SetKeyName(437, "190.png")
        Me.ImageList1.Images.SetKeyName(438, "191.png")
        Me.ImageList1.Images.SetKeyName(439, "192.png")
        Me.ImageList1.Images.SetKeyName(440, "193.png")
        Me.ImageList1.Images.SetKeyName(441, "194.png")
        Me.ImageList1.Images.SetKeyName(442, "195.png")
        Me.ImageList1.Images.SetKeyName(443, "196.png")
        Me.ImageList1.Images.SetKeyName(444, "197.png")
        Me.ImageList1.Images.SetKeyName(445, "198.png")
        Me.ImageList1.Images.SetKeyName(446, "199.png")
        Me.ImageList1.Images.SetKeyName(447, "200.png")
        Me.ImageList1.Images.SetKeyName(448, "Ampeross-Qetto-2-Camera.ico")
        Me.ImageList1.Images.SetKeyName(449, "Cornmanthe3rd-Metronome-Utilities-antivirus.ico")
        Me.ImageList1.Images.SetKeyName(450, "Ncrow-Mega-Pack-2-Windows-Media-Center.ico")
        Me.ImageList1.Images.SetKeyName(451, "Kearone-Platecons-Ram-or-hardware.ico")
        Me.ImageList1.Images.SetKeyName(452, "Cancel.bmp")
        Me.ImageList1.Images.SetKeyName(453, "Tatice-Cristal-Intense-Globe-terrestre-2.ico")
        Me.ImageList1.Images.SetKeyName(454, "212121.ico")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Windows7.png")
        Me.ImageList2.Images.SetKeyName(1, "Windows10.png")
        Me.ImageList2.Images.SetKeyName(2, "WindowsXP.png")
        Me.ImageList2.Images.SetKeyName(3, "unknowen.png")
        Me.ImageList2.Images.SetKeyName(4, "Windows Vista.png")
        Me.ImageList2.Images.SetKeyName(5, "firewallx.png")
        Me.ImageList2.Images.SetKeyName(6, "unknowenr.png")
        Me.ImageList2.Images.SetKeyName(7, "Windows Vistar.png")
        Me.ImageList2.Images.SetKeyName(8, "Windows7r.png")
        Me.ImageList2.Images.SetKeyName(9, "Windows10r.png")
        Me.ImageList2.Images.SetKeyName(10, "WindowsXPr.png")
        '
        'MapGadget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(947, 668)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MapGadget"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.firepic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents logger As RichTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents firepic As PictureBox
    Friend WithEvents Flager As Timer
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
End Class

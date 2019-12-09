<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class countrylist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(countrylist))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 23)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(96, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "None"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Location = New System.Drawing.Point(230, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Finish"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selected : "
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.ListView1.ForeColor = System.Drawing.Color.Snow
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(305, 130)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Country"
        Me.ColumnHeader1.Width = 300
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
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(121, 174)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(477, 217)
        Me.RichTextBox1.TabIndex = 44
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'countrylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(305, 153)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.ForeColor = System.Drawing.Color.Snow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "countrylist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "countrylist"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class

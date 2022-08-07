<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lb1 = New System.Windows.Forms.Label()
        Me.btok = New System.Windows.Forms.Button()
        Me.btclear = New System.Windows.Forms.Button()
        Me.btexit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rb14 = New System.Windows.Forms.RadioButton()
        Me.Rb13 = New System.Windows.Forms.RadioButton()
        Me.Rb12 = New System.Windows.Forms.RadioButton()
        Me.Rb11 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rb24 = New System.Windows.Forms.RadioButton()
        Me.Rb23 = New System.Windows.Forms.RadioButton()
        Me.Rb22 = New System.Windows.Forms.RadioButton()
        Me.Rb21 = New System.Windows.Forms.RadioButton()
        Me.Rb41 = New System.Windows.Forms.RadioButton()
        Me.Rb42 = New System.Windows.Forms.RadioButton()
        Me.Rb43 = New System.Windows.Forms.RadioButton()
        Me.Rb44 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Rb31 = New System.Windows.Forms.RadioButton()
        Me.Rb32 = New System.Windows.Forms.RadioButton()
        Me.Rb33 = New System.Windows.Forms.RadioButton()
        Me.Rb34 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lboutput = New System.Windows.Forms.Label()
        Me.bttimer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb1
        '
        Me.lb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lb1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.ForeColor = System.Drawing.Color.Black
        Me.lb1.Location = New System.Drawing.Point(-19, 6)
        Me.lb1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(669, 68)
        Me.lb1.TabIndex = 0
        Me.lb1.Text = "ข้อสอบปลายภาคเรียนที่ 2/2563"
        Me.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lb1.UseWaitCursor = True
        '
        'btok
        '
        Me.btok.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btok.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btok.ForeColor = System.Drawing.Color.DarkBlue
        Me.btok.Location = New System.Drawing.Point(362, 599)
        Me.btok.Margin = New System.Windows.Forms.Padding(4)
        Me.btok.Name = "btok"
        Me.btok.Size = New System.Drawing.Size(135, 66)
        Me.btok.TabIndex = 5
        Me.btok.Text = "ตกลง"
        Me.btok.UseVisualStyleBackColor = False
        Me.btok.UseWaitCursor = True
        '
        'btclear
        '
        Me.btclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btclear.ForeColor = System.Drawing.Color.Black
        Me.btclear.Location = New System.Drawing.Point(570, 599)
        Me.btclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btclear.Name = "btclear"
        Me.btclear.Size = New System.Drawing.Size(127, 66)
        Me.btclear.TabIndex = 6
        Me.btclear.Text = "ยกเลิก"
        Me.btclear.UseVisualStyleBackColor = False
        Me.btclear.UseWaitCursor = True
        '
        'btexit
        '
        Me.btexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btexit.ForeColor = System.Drawing.Color.Red
        Me.btexit.Location = New System.Drawing.Point(769, 599)
        Me.btexit.Margin = New System.Windows.Forms.Padding(4)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(196, 66)
        Me.btexit.TabIndex = 7
        Me.btexit.Text = "จบการทำงาน"
        Me.btexit.UseVisualStyleBackColor = False
        Me.btexit.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(56, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 54)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "วิชา การเขียนโปรแกรม Visual Basic"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(57, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(536, 54)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ชื่อ-นามสกุล"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.UseWaitCursor = True
        '
        'tbname
        '
        Me.tbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbname.Location = New System.Drawing.Point(250, 139)
        Me.tbname.Margin = New System.Windows.Forms.Padding(4)
        Me.tbname.Multiline = True
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(332, 36)
        Me.tbname.TabIndex = 10
        Me.tbname.UseWaitCursor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rb14)
        Me.GroupBox1.Controls.Add(Me.Rb13)
        Me.GroupBox1.Controls.Add(Me.Rb12)
        Me.GroupBox1.Controls.Add(Me.Rb11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 190)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(670, 186)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1.การเขียนโปรแกรมภาษา Visual Basic เหมาะกับงานประเภทใด?"
        Me.GroupBox1.UseWaitCursor = True
        '
        'Rb14
        '
        Me.Rb14.AutoSize = True
        Me.Rb14.Location = New System.Drawing.Point(27, 131)
        Me.Rb14.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb14.Name = "Rb14"
        Me.Rb14.Size = New System.Drawing.Size(459, 29)
        Me.Rb14.TabIndex = 3
        Me.Rb14.TabStop = True
        Me.Rb14.Text = "เขียนโปรแกรมที่ใช้งานบนระบบปฏิบัติการ Windows ทั่วไป"
        Me.Rb14.UseVisualStyleBackColor = True
        Me.Rb14.UseWaitCursor = True
        '
        'Rb13
        '
        Me.Rb13.AutoSize = True
        Me.Rb13.Location = New System.Drawing.Point(27, 103)
        Me.Rb13.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb13.Name = "Rb13"
        Me.Rb13.Size = New System.Drawing.Size(298, 29)
        Me.Rb13.TabIndex = 2
        Me.Rb13.TabStop = True
        Me.Rb13.Text = "เขียนโปรแกรมออกแบบ Model ต่างๆ"
        Me.Rb13.UseVisualStyleBackColor = True
        Me.Rb13.UseWaitCursor = True
        '
        'Rb12
        '
        Me.Rb12.AutoSize = True
        Me.Rb12.Location = New System.Drawing.Point(27, 75)
        Me.Rb12.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb12.Name = "Rb12"
        Me.Rb12.Size = New System.Drawing.Size(247, 29)
        Me.Rb12.TabIndex = 1
        Me.Rb12.TabStop = True
        Me.Rb12.Text = "เขียนโปรแกรมควบคุมหุ่นยนต์"
        Me.Rb12.UseVisualStyleBackColor = True
        Me.Rb12.UseWaitCursor = True
        '
        'Rb11
        '
        Me.Rb11.AutoSize = True
        Me.Rb11.Location = New System.Drawing.Point(27, 44)
        Me.Rb11.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb11.Name = "Rb11"
        Me.Rb11.Size = New System.Drawing.Size(225, 29)
        Me.Rb11.TabIndex = 0
        Me.Rb11.TabStop = True
        Me.Rb11.Text = "เขียนโปรแกรมเกมบนมือถือ"
        Me.Rb11.UseVisualStyleBackColor = True
        Me.Rb11.UseWaitCursor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rb24)
        Me.GroupBox2.Controls.Add(Me.Rb23)
        Me.GroupBox2.Controls.Add(Me.Rb22)
        Me.GroupBox2.Controls.Add(Me.Rb21)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(722, 190)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(433, 169)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2.โปรเจ็กต์ (Project) คืออะไร ?"
        Me.GroupBox2.UseWaitCursor = True
        '
        'Rb24
        '
        Me.Rb24.AutoSize = True
        Me.Rb24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Rb24.Location = New System.Drawing.Point(32, 117)
        Me.Rb24.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb24.Name = "Rb24"
        Me.Rb24.Size = New System.Drawing.Size(263, 29)
        Me.Rb24.TabIndex = 3
        Me.Rb24.TabStop = True
        Me.Rb24.Text = "กลุ่มของไฟล์ในการสร้างโปรแกรม"
        Me.Rb24.UseVisualStyleBackColor = True
        Me.Rb24.UseWaitCursor = True
        '
        'Rb23
        '
        Me.Rb23.AutoSize = True
        Me.Rb23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Rb23.Location = New System.Drawing.Point(32, 89)
        Me.Rb23.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb23.Name = "Rb23"
        Me.Rb23.Size = New System.Drawing.Size(263, 29)
        Me.Rb23.TabIndex = 2
        Me.Rb23.TabStop = True
        Me.Rb23.Text = "ไฟล์ที่ใช้ในการสร้างออบเจ็กต์ต่าง"
        Me.Rb23.UseVisualStyleBackColor = True
        Me.Rb23.UseWaitCursor = True
        '
        'Rb22
        '
        Me.Rb22.AutoSize = True
        Me.Rb22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Rb22.Location = New System.Drawing.Point(32, 66)
        Me.Rb22.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb22.Name = "Rb22"
        Me.Rb22.Size = New System.Drawing.Size(234, 29)
        Me.Rb22.TabIndex = 1
        Me.Rb22.TabStop = True
        Me.Rb22.Text = "ไฟล์ที่เก็บข้อมูลเกี่ยวกับฟอร์ม"
        Me.Rb22.UseVisualStyleBackColor = True
        Me.Rb22.UseWaitCursor = True
        '
        'Rb21
        '
        Me.Rb21.AutoSize = True
        Me.Rb21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Rb21.Location = New System.Drawing.Point(32, 38)
        Me.Rb21.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb21.Name = "Rb21"
        Me.Rb21.Size = New System.Drawing.Size(259, 29)
        Me.Rb21.TabIndex = 0
        Me.Rb21.TabStop = True
        Me.Rb21.Text = "กลุ่มของคอนโทรลต่าง ๆ ใน VB"
        Me.Rb21.UseVisualStyleBackColor = True
        Me.Rb21.UseWaitCursor = True
        '
        'Rb41
        '
        Me.Rb41.AutoSize = True
        Me.Rb41.Location = New System.Drawing.Point(36, 31)
        Me.Rb41.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb41.Name = "Rb41"
        Me.Rb41.Size = New System.Drawing.Size(154, 29)
        Me.Rb41.TabIndex = 0
        Me.Rb41.TabStop = True
        Me.Rb41.Text = "ตัวเลขจำนวนเต็ม"
        Me.Rb41.UseVisualStyleBackColor = True
        Me.Rb41.UseWaitCursor = True
        '
        'Rb42
        '
        Me.Rb42.AutoSize = True
        Me.Rb42.Location = New System.Drawing.Point(36, 68)
        Me.Rb42.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb42.Name = "Rb42"
        Me.Rb42.Size = New System.Drawing.Size(151, 29)
        Me.Rb42.TabIndex = 1
        Me.Rb42.TabStop = True
        Me.Rb42.Text = "ตัวเลขจำนวนจริง"
        Me.Rb42.UseVisualStyleBackColor = True
        Me.Rb42.UseWaitCursor = True
        '
        'Rb43
        '
        Me.Rb43.AutoSize = True
        Me.Rb43.Location = New System.Drawing.Point(36, 103)
        Me.Rb43.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb43.Name = "Rb43"
        Me.Rb43.Size = New System.Drawing.Size(98, 29)
        Me.Rb43.TabIndex = 2
        Me.Rb43.TabStop = True
        Me.Rb43.Text = "ตัวอักขระ"
        Me.Rb43.UseVisualStyleBackColor = True
        Me.Rb43.UseWaitCursor = True
        '
        'Rb44
        '
        Me.Rb44.AutoSize = True
        Me.Rb44.Location = New System.Drawing.Point(36, 140)
        Me.Rb44.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb44.Name = "Rb44"
        Me.Rb44.Size = New System.Drawing.Size(207, 29)
        Me.Rb44.TabIndex = 3
        Me.Rb44.TabStop = True
        Me.Rb44.Text = "ข้อมูลทางตรรก(จริง-เท็จ)"
        Me.Rb44.UseVisualStyleBackColor = True
        Me.Rb44.UseWaitCursor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Rb44)
        Me.GroupBox4.Controls.Add(Me.Rb43)
        Me.GroupBox4.Controls.Add(Me.Rb42)
        Me.GroupBox4.Controls.Add(Me.Rb41)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(722, 371)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(433, 198)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "4.ตัวแปรประเภท Integer ใช้เก็บค่าอะไร?"
        Me.GroupBox4.UseWaitCursor = True
        '
        'Rb31
        '
        Me.Rb31.AutoSize = True
        Me.Rb31.Location = New System.Drawing.Point(37, 62)
        Me.Rb31.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb31.Name = "Rb31"
        Me.Rb31.Size = New System.Drawing.Size(146, 29)
        Me.Rb31.TabIndex = 0
        Me.Rb31.TabStop = True
        Me.Rb31.Text = "ActiveX EXE"
        Me.Rb31.UseVisualStyleBackColor = True
        Me.Rb31.UseWaitCursor = True
        '
        'Rb32
        '
        Me.Rb32.AutoSize = True
        Me.Rb32.Location = New System.Drawing.Point(38, 90)
        Me.Rb32.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb32.Name = "Rb32"
        Me.Rb32.Size = New System.Drawing.Size(169, 29)
        Me.Rb32.TabIndex = 1
        Me.Rb32.TabStop = True
        Me.Rb32.Text = "ActiveX Control"
        Me.Rb32.UseVisualStyleBackColor = True
        Me.Rb32.UseWaitCursor = True
        '
        'Rb33
        '
        Me.Rb33.AutoSize = True
        Me.Rb33.Location = New System.Drawing.Point(37, 117)
        Me.Rb33.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb33.Name = "Rb33"
        Me.Rb33.Size = New System.Drawing.Size(158, 29)
        Me.Rb33.TabIndex = 2
        Me.Rb33.TabStop = True
        Me.Rb33.Text = "Standard EXE"
        Me.Rb33.UseVisualStyleBackColor = True
        Me.Rb33.UseWaitCursor = True
        '
        'Rb34
        '
        Me.Rb34.AutoSize = True
        Me.Rb34.Location = New System.Drawing.Point(37, 145)
        Me.Rb34.Margin = New System.Windows.Forms.Padding(4)
        Me.Rb34.Name = "Rb34"
        Me.Rb34.Size = New System.Drawing.Size(228, 29)
        Me.Rb34.TabIndex = 3
        Me.Rb34.TabStop = True
        Me.Rb34.Text = "VB Application Wizard"
        Me.Rb34.UseVisualStyleBackColor = True
        Me.Rb34.UseWaitCursor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rb34)
        Me.GroupBox3.Controls.Add(Me.Rb33)
        Me.GroupBox3.Controls.Add(Me.Rb32)
        Me.GroupBox3.Controls.Add(Me.Rb31)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(27, 384)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(670, 207)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "3.แอพพลิเคชันทั่วไปที่มีการใช้งานใน Windows เมื่อสร้างแล้วจะได้ไฟล์ที่มีนามสกุลเป" &
    "็น .EXE (เอ็กซ์คิวต์ไฟล์) คือข้อใด?"
        Me.GroupBox3.UseWaitCursor = True
        '
        'Timer1
        '
        '
        'lboutput
        '
        Me.lboutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lboutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lboutput.Font = New System.Drawing.Font("Yu Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboutput.Location = New System.Drawing.Point(860, 33)
        Me.lboutput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lboutput.Name = "lboutput"
        Me.lboutput.Size = New System.Drawing.Size(216, 89)
        Me.lboutput.TabIndex = 16
        Me.lboutput.Text = "00:00:00"
        Me.lboutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lboutput.UseWaitCursor = True
        '
        'bttimer
        '
        Me.bttimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bttimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bttimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bttimer.ForeColor = System.Drawing.Color.Black
        Me.bttimer.Location = New System.Drawing.Point(976, 134)
        Me.bttimer.Margin = New System.Windows.Forms.Padding(4)
        Me.bttimer.Name = "bttimer"
        Me.bttimer.Size = New System.Drawing.Size(100, 41)
        Me.bttimer.TabIndex = 17
        Me.bttimer.Text = "จับเวลา"
        Me.bttimer.UseVisualStyleBackColor = False
        Me.bttimer.UseWaitCursor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GreenYellow
        Me.ClientSize = New System.Drawing.Size(1195, 678)
        Me.ControlBox = False
        Me.Controls.Add(Me.bttimer)
        Me.Controls.Add(Me.lboutput)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.btclear)
        Me.Controls.Add(Me.btok)
        Me.Controls.Add(Me.lb1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "ข้อสอบปลายภาค"
        Me.UseWaitCursor = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents btok As System.Windows.Forms.Button
    Friend WithEvents btclear As System.Windows.Forms.Button
    Friend WithEvents btexit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb14 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb13 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb12 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb11 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb24 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb23 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb22 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb21 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb41 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb42 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb43 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb44 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb31 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb32 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb33 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb34 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lboutput As System.Windows.Forms.Label
    Friend WithEvents bttimer As System.Windows.Forms.Button

End Class

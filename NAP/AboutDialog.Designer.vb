<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutDialog
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutDialog))
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelOrganization = New System.Windows.Forms.Label()
        Me.LinkLabelEULA = New System.Windows.Forms.LinkLabel()
        Me.LabelLicense = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelSupportPhone = New System.Windows.Forms.Label()
        Me.LinkLabelWebsite = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelEmail = New System.Windows.Forms.LinkLabel()
        Me.LabelSupportAvailable = New System.Windows.Forms.Label()
        Me.LabelCompany = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelWindowsVersion = New System.Windows.Forms.Label()
        Me.LabelOSDescription = New System.Windows.Forms.Label()
        Me.LabelFramework = New System.Windows.Forms.Label()
        Me.LabelClrVersion = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PictureApplication = New System.Windows.Forms.PictureBox()
        Me.StatusStripAbout = New System.Windows.Forms.StatusStrip()
        Me.ToolStripLabelClock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripLabelDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripLabelUpTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ButtonSysInfo = New System.Windows.Forms.Button()
        Me.LabelBottomSeperator = New System.Windows.Forms.Label()
        Me.LabelTopSeparator = New System.Windows.Forms.Label()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TimerTickCount = New System.Windows.Forms.Timer(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        CType(Me.PictureApplication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelVersion, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LabelDescription, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(11, 75)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 4
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(410, 65)
        Me.TableLayoutPanel4.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "copyright @ Nightingale 2017"
        '
        'LabelVersion
        '
        Me.LabelVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelVersion.Location = New System.Drawing.Point(2, 0)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(406, 15)
        Me.LabelVersion.TabIndex = 19
        Me.LabelVersion.Text = "Application Version: "
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDescription
        '
        Me.LabelDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelDescription.Location = New System.Drawing.Point(2, 15)
        Me.LabelDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(406, 15)
        Me.LabelDescription.TabIndex = 18
        Me.LabelDescription.Text = "Application Description: "
        Me.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LabelOrganization, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.LinkLabelEULA, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelLicense, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(11, 144)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(410, 85)
        Me.TableLayoutPanel3.TabIndex = 38
        '
        'LabelOrganization
        '
        Me.LabelOrganization.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelOrganization.AutoSize = True
        Me.LabelOrganization.BackColor = System.Drawing.Color.Transparent
        Me.LabelOrganization.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOrganization.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelOrganization.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelOrganization.Location = New System.Drawing.Point(2, 66)
        Me.LabelOrganization.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelOrganization.Name = "LabelOrganization"
        Me.LabelOrganization.Size = New System.Drawing.Size(406, 15)
        Me.LabelOrganization.TabIndex = 14
        Me.LabelOrganization.Text = "Virtual Software"
        Me.LabelOrganization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabelEULA
        '
        Me.LinkLabelEULA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabelEULA.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelEULA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelEULA.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelEULA.LinkColor = System.Drawing.Color.MediumBlue
        Me.LinkLabelEULA.Location = New System.Drawing.Point(2, 23)
        Me.LinkLabelEULA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelEULA.Name = "LinkLabelEULA"
        Me.LinkLabelEULA.Size = New System.Drawing.Size(406, 16)
        Me.LinkLabelEULA.TabIndex = 3
        Me.LinkLabelEULA.TabStop = True
        Me.LinkLabelEULA.Text = "NNN GENERAL PUBLIC LICENSE to:"
        Me.LinkLabelEULA.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LinkLabelEULA.UseCompatibleTextRendering = True
        '
        'LabelLicense
        '
        Me.LabelLicense.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelLicense.AutoSize = True
        Me.LabelLicense.BackColor = System.Drawing.Color.Transparent
        Me.LabelLicense.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLicense.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelLicense.Location = New System.Drawing.Point(2, 3)
        Me.LabelLicense.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLicense.Name = "LabelLicense"
        Me.LabelLicense.Size = New System.Drawing.Size(406, 15)
        Me.LabelLicense.TabIndex = 16
        Me.LabelLicense.Text = "This product is licensed under the terms of the"
        Me.LabelLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nathaniel Nkrumah"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LabelSupportPhone, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LinkLabelWebsite, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LinkLabelEmail, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelSupportAvailable, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelCompany, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(11, 234)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(410, 105)
        Me.TableLayoutPanel2.TabIndex = 37
        '
        'LabelSupportPhone
        '
        Me.LabelSupportPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelSupportPhone.BackColor = System.Drawing.Color.Transparent
        Me.LabelSupportPhone.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSupportPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelSupportPhone.Location = New System.Drawing.Point(2, 87)
        Me.LabelSupportPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSupportPhone.Name = "LabelSupportPhone"
        Me.LabelSupportPhone.Size = New System.Drawing.Size(406, 15)
        Me.LabelSupportPhone.TabIndex = 21
        Me.LabelSupportPhone.Text = "Phone:"
        Me.LabelSupportPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabelWebsite
        '
        Me.LinkLabelWebsite.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabelWebsite.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelWebsite.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelWebsite.LinkColor = System.Drawing.Color.MediumBlue
        Me.LinkLabelWebsite.Location = New System.Drawing.Point(2, 64)
        Me.LinkLabelWebsite.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelWebsite.Name = "LinkLabelWebsite"
        Me.LinkLabelWebsite.Size = New System.Drawing.Size(406, 18)
        Me.LinkLabelWebsite.TabIndex = 5
        Me.LinkLabelWebsite.TabStop = True
        Me.LinkLabelWebsite.Text = "Website:"
        Me.LinkLabelWebsite.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LinkLabelWebsite.UseCompatibleTextRendering = True
        '
        'LinkLabelEmail
        '
        Me.LinkLabelEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabelEmail.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabelEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabelEmail.LinkColor = System.Drawing.Color.MediumBlue
        Me.LinkLabelEmail.Location = New System.Drawing.Point(2, 43)
        Me.LinkLabelEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabelEmail.Name = "LinkLabelEmail"
        Me.LinkLabelEmail.Size = New System.Drawing.Size(406, 18)
        Me.LinkLabelEmail.TabIndex = 4
        Me.LinkLabelEmail.TabStop = True
        Me.LinkLabelEmail.Text = "Email:"
        Me.LinkLabelEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LinkLabelEmail.UseCompatibleTextRendering = True
        '
        'LabelSupportAvailable
        '
        Me.LabelSupportAvailable.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelSupportAvailable.AutoSize = True
        Me.LabelSupportAvailable.BackColor = System.Drawing.Color.Transparent
        Me.LabelSupportAvailable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSupportAvailable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelSupportAvailable.Location = New System.Drawing.Point(2, 24)
        Me.LabelSupportAvailable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSupportAvailable.Name = "LabelSupportAvailable"
        Me.LabelSupportAvailable.Size = New System.Drawing.Size(406, 15)
        Me.LabelSupportAvailable.TabIndex = 20
        Me.LabelSupportAvailable.Text = "Support is available:"
        Me.LabelSupportAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCompany
        '
        Me.LabelCompany.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelCompany.AutoSize = True
        Me.LabelCompany.BackColor = System.Drawing.Color.Transparent
        Me.LabelCompany.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCompany.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelCompany.Location = New System.Drawing.Point(2, 3)
        Me.LabelCompany.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCompany.Name = "LabelCompany"
        Me.LabelCompany.Size = New System.Drawing.Size(406, 15)
        Me.LabelCompany.TabIndex = 13
        Me.LabelCompany.Text = "Application Title is a product of Company Name"
        Me.LabelCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LabelWindowsVersion, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelOSDescription, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelFramework, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelClrVersion, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 344)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 85)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'LabelWindowsVersion
        '
        Me.LabelWindowsVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelWindowsVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelWindowsVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWindowsVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelWindowsVersion.Location = New System.Drawing.Point(2, 2)
        Me.LabelWindowsVersion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelWindowsVersion.Name = "LabelWindowsVersion"
        Me.LabelWindowsVersion.Size = New System.Drawing.Size(406, 16)
        Me.LabelWindowsVersion.TabIndex = 7
        Me.LabelWindowsVersion.Text = "Windows Version: "
        Me.LabelWindowsVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelOSDescription
        '
        Me.LabelOSDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelOSDescription.BackColor = System.Drawing.Color.Transparent
        Me.LabelOSDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOSDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelOSDescription.Location = New System.Drawing.Point(2, 23)
        Me.LabelOSDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelOSDescription.Name = "LabelOSDescription"
        Me.LabelOSDescription.Size = New System.Drawing.Size(406, 16)
        Me.LabelOSDescription.TabIndex = 8
        Me.LabelOSDescription.Text = "Operating System: "
        Me.LabelOSDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelFramework
        '
        Me.LabelFramework.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelFramework.BackColor = System.Drawing.Color.Transparent
        Me.LabelFramework.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFramework.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelFramework.Location = New System.Drawing.Point(2, 44)
        Me.LabelFramework.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFramework.Name = "LabelFramework"
        Me.LabelFramework.Size = New System.Drawing.Size(406, 16)
        Me.LabelFramework.TabIndex = 9
        Me.LabelFramework.Text = "NET Framework:"
        Me.LabelFramework.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelClrVersion
        '
        Me.LabelClrVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClrVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelClrVersion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClrVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelClrVersion.Location = New System.Drawing.Point(2, 66)
        Me.LabelClrVersion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelClrVersion.Name = "LabelClrVersion"
        Me.LabelClrVersion.Size = New System.Drawing.Size(406, 16)
        Me.LabelClrVersion.TabIndex = 10
        Me.LabelClrVersion.Text = "Common Language Runtime Version:"
        Me.LabelClrVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PanelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelHeader.Controls.Add(Me.LabelTitle)
        Me.PanelHeader.Controls.Add(Me.PictureApplication)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.ForeColor = System.Drawing.Color.LemonChiffon
        Me.PanelHeader.Location = New System.Drawing.Point(9, 9)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(414, 60)
        Me.PanelHeader.TabIndex = 35
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelTitle.Location = New System.Drawing.Point(76, 19)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(166, 23)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Application Title"
        '
        'PictureApplication
        '
        Me.PictureApplication.BackColor = System.Drawing.Color.Transparent
        Me.PictureApplication.Image = CType(resources.GetObject("PictureApplication.Image"), System.Drawing.Image)
        Me.PictureApplication.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureApplication.Location = New System.Drawing.Point(0, 0)
        Me.PictureApplication.Name = "PictureApplication"
        Me.PictureApplication.Size = New System.Drawing.Size(64, 60)
        Me.PictureApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureApplication.TabIndex = 23
        Me.PictureApplication.TabStop = False
        '
        'StatusStripAbout
        '
        Me.StatusStripAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStripAbout.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStripAbout.Location = New System.Drawing.Point(9, 482)
        Me.StatusStripAbout.Name = "StatusStripAbout"
        Me.StatusStripAbout.Size = New System.Drawing.Size(414, 22)
        Me.StatusStripAbout.SizingGrip = False
        Me.StatusStripAbout.TabIndex = 33
        '
        'ToolStripLabelClock
        '
        Me.ToolStripLabelClock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabelClock.Name = "ToolStripLabelClock"
        Me.ToolStripLabelClock.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripLabelDateTime
        '
        Me.ToolStripLabelDateTime.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabelDateTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabelDateTime.Name = "ToolStripLabelDateTime"
        Me.ToolStripLabelDateTime.Size = New System.Drawing.Size(233, 17)
        Me.ToolStripLabelDateTime.Text = "Wednesday, December 07, 2005 8:08:03 PM"
        '
        'ToolStripLabelUpTime
        '
        Me.ToolStripLabelUpTime.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabelUpTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabelUpTime.Name = "ToolStripLabelUpTime"
        Me.ToolStripLabelUpTime.Size = New System.Drawing.Size(109, 17)
        Me.ToolStripLabelUpTime.Text = "Up Time: 1:12:45:36"
        '
        'ButtonSysInfo
        '
        Me.ButtonSysInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSysInfo.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSysInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSysInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSysInfo.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonSysInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSysInfo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSysInfo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ButtonSysInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonSysInfo.Location = New System.Drawing.Point(153, 453)
        Me.ButtonSysInfo.Name = "ButtonSysInfo"
        Me.ButtonSysInfo.Size = New System.Drawing.Size(127, 25)
        Me.ButtonSysInfo.TabIndex = 31
        Me.ButtonSysInfo.Text = "&System Infomation"
        Me.ButtonSysInfo.UseVisualStyleBackColor = False
        '
        'LabelBottomSeperator
        '
        Me.LabelBottomSeperator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelBottomSeperator.BackColor = System.Drawing.SystemColors.Control
        Me.LabelBottomSeperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelBottomSeperator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelBottomSeperator.Location = New System.Drawing.Point(8, 438)
        Me.LabelBottomSeperator.Name = "LabelBottomSeperator"
        Me.LabelBottomSeperator.Size = New System.Drawing.Size(416, 3)
        Me.LabelBottomSeperator.TabIndex = 32
        '
        'LabelTopSeparator
        '
        Me.LabelTopSeparator.BackColor = System.Drawing.SystemColors.Control
        Me.LabelTopSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTopSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LabelTopSeparator.Location = New System.Drawing.Point(0, 60)
        Me.LabelTopSeparator.Name = "LabelTopSeparator"
        Me.LabelTopSeparator.Size = New System.Drawing.Size(432, 3)
        Me.LabelTopSeparator.TabIndex = 34
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOK.BackColor = System.Drawing.Color.Transparent
        Me.ButtonOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonOK.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOK.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ButtonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonOK.Location = New System.Drawing.Point(347, 453)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(73, 25)
        Me.ButtonOK.TabIndex = 30
        Me.ButtonOK.Text = "&OK"
        Me.ButtonOK.UseVisualStyleBackColor = False
        '
        'TimerTickCount
        '
        Me.TimerTickCount.Interval = 1000
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'AboutDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(432, 513)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.StatusStripAbout)
        Me.Controls.Add(Me.ButtonSysInfo)
        Me.Controls.Add(Me.LabelBottomSeperator)
        Me.Controls.Add(Me.LabelTopSeparator)
        Me.Controls.Add(Me.ButtonOK)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutDialog"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "   About......"
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.PictureApplication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelDescription As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelOrganization As System.Windows.Forms.Label
    Friend WithEvents LinkLabelEULA As System.Windows.Forms.LinkLabel
    Friend WithEvents LabelLicense As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelSupportPhone As System.Windows.Forms.Label
    Friend WithEvents LinkLabelWebsite As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabelEmail As System.Windows.Forms.LinkLabel
    Friend WithEvents LabelSupportAvailable As System.Windows.Forms.Label
    Friend WithEvents LabelCompany As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelWindowsVersion As System.Windows.Forms.Label
    Friend WithEvents LabelOSDescription As System.Windows.Forms.Label
    Friend WithEvents LabelFramework As System.Windows.Forms.Label
    Friend WithEvents LabelClrVersion As System.Windows.Forms.Label
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents PictureApplication As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStripAbout As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripLabelClock As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripLabelDateTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripLabelUpTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ButtonSysInfo As System.Windows.Forms.Button
    Friend WithEvents LabelBottomSeperator As System.Windows.Forms.Label
    Friend WithEvents LabelTopSeparator As System.Windows.Forms.Label
    Friend WithEvents ButtonOK As System.Windows.Forms.Button
    Friend WithEvents TimerTickCount As System.Windows.Forms.Timer
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager

End Class

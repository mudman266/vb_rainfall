<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRainfallAverage = New System.Windows.Forms.Label()
        Me.btnEnterRainfall = New System.Windows.Forms.Button()
        Me.lstRainfallAmounts = New System.Windows.Forms.ListBox()
        Me.lblAvgRainfall = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(947, 552)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(947, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FIleToolStripMenuItem
        '
        Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsClear, Me.tlsExit})
        Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
        Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FIleToolStripMenuItem.Text = "FIle"
        '
        'tlsClear
        '
        Me.tlsClear.Name = "tlsClear"
        Me.tlsClear.Size = New System.Drawing.Size(180, 22)
        Me.tlsClear.Text = "Clear"
        '
        'tlsExit
        '
        Me.tlsExit.Name = "tlsExit"
        Me.tlsExit.Size = New System.Drawing.Size(180, 22)
        Me.tlsExit.Text = "Exit"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(33, 66)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(511, 41)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Most Rainfall in US - Kauai"
        '
        'lblRainfallAverage
        '
        Me.lblRainfallAverage.AutoSize = True
        Me.lblRainfallAverage.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRainfallAverage.Location = New System.Drawing.Point(178, 121)
        Me.lblRainfallAverage.Name = "lblRainfallAverage"
        Me.lblRainfallAverage.Size = New System.Drawing.Size(204, 27)
        Me.lblRainfallAverage.TabIndex = 3
        Me.lblRainfallAverage.Text = "Rainfall Average"
        '
        'btnEnterRainfall
        '
        Me.btnEnterRainfall.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEnterRainfall.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterRainfall.Location = New System.Drawing.Point(172, 184)
        Me.btnEnterRainfall.Name = "btnEnterRainfall"
        Me.btnEnterRainfall.Size = New System.Drawing.Size(210, 76)
        Me.btnEnterRainfall.TabIndex = 4
        Me.btnEnterRainfall.Text = "Enter Rainfall"
        Me.btnEnterRainfall.UseVisualStyleBackColor = False
        '
        'lstRainfallAmounts
        '
        Me.lstRainfallAmounts.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRainfallAmounts.ForeColor = System.Drawing.Color.Red
        Me.lstRainfallAmounts.FormattingEnabled = True
        Me.lstRainfallAmounts.ItemHeight = 20
        Me.lstRainfallAmounts.Location = New System.Drawing.Point(664, 66)
        Me.lstRainfallAmounts.Name = "lstRainfallAmounts"
        Me.lstRainfallAmounts.Size = New System.Drawing.Size(95, 264)
        Me.lstRainfallAmounts.TabIndex = 5
        '
        'lblAvgRainfall
        '
        Me.lblAvgRainfall.AutoSize = True
        Me.lblAvgRainfall.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRainfall.ForeColor = System.Drawing.Color.Red
        Me.lblAvgRainfall.Location = New System.Drawing.Point(12, 372)
        Me.lblAvgRainfall.Name = "lblAvgRainfall"
        Me.lblAvgRainfall.Size = New System.Drawing.Size(446, 32)
        Me.lblAvgRainfall.TabIndex = 6
        Me.lblAvgRainfall.Text = "Average Rainfall per Month is: "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 572)
        Me.Controls.Add(Me.lblAvgRainfall)
        Me.Controls.Add(Me.lstRainfallAmounts)
        Me.Controls.Add(Me.btnEnterRainfall)
        Me.Controls.Add(Me.lblRainfallAverage)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Most Rainfall in the USA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tlsClear As ToolStripMenuItem
    Friend WithEvents tlsExit As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRainfallAverage As Label
    Friend WithEvents btnEnterRainfall As Button
    Friend WithEvents lstRainfallAmounts As ListBox
    Friend WithEvents lblAvgRainfall As Label
End Class

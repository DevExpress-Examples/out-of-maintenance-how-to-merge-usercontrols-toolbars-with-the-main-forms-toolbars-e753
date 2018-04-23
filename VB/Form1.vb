Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace MergeModules
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private bar1 As DevExpress.XtraBars.Bar
		Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private panel1 As System.Windows.Forms.Panel
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.panel1 = New System.Windows.Forms.Panel()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1})
			Me.barManager1.MaxItemId = 1
			' 
			' bar1
			' 
			Me.bar1.BarName = "Custom 1"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1)})
			Me.bar1.Text = "Custom 1"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "MainButton (Ctrl+N)"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
			Me.barButtonItem1.Name = "barButtonItem1"
'			Me.barButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem1_ItemClick);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(13, 55)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(120, 20)
			Me.simpleButton1.TabIndex = 4
			Me.simpleButton1.Text = "Create Module"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Enabled = False
			Me.simpleButton2.Location = New System.Drawing.Point(153, 55)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(120, 20)
			Me.simpleButton2.TabIndex = 5
			Me.simpleButton2.Text = "Destroy Module"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' panel1
			' 
			Me.panel1.Location = New System.Drawing.Point(13, 83)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(360, 153)
			Me.panel1.TabIndex = 6
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(388, 251)
			Me.Controls.Add(Me.panel1)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private [module] As UserControl1
		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton1.Click
			[module] = New UserControl1(barManager1)
			[module].Dock = DockStyle.Fill
			[module].Parent = panel1

			simpleButton1.Enabled = False
			simpleButton2.Enabled = True
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles simpleButton2.Click
			If [module] IsNot Nothing Then
				[module].Dispose()
				[module] = Nothing
			End If

			simpleButton1.Enabled = True
			simpleButton2.Enabled = False
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			MessageBox.Show(e.Item.Caption)
		End Sub
	End Class
End Namespace

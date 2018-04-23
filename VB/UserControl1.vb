Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraBars

Namespace MergeModules
	''' <summary>
	''' Summary description for UserControl1.
	''' </summary>
	Public Class UserControl1
		Inherits System.Windows.Forms.UserControl
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private bar1 As DevExpress.XtraBars.Bar
		Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private components As IContainer
		Private textEdit1 As DevExpress.XtraEditors.TextEdit


		Private mainManager As BarManager
		Private ReadOnly Property thisManager() As BarManager
			Get
				Return barManager1
			End Get
		End Property
		Public Sub New(ByVal mainManager As BarManager)
			Me.mainManager = mainManager
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitForm call

		End Sub

		#Region "Component Designer generated code"
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
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.barButtonItem1.Caption = "ModuleButton (Ctrl+M)"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M))
			Me.barButtonItem1.Name = "barButtonItem1"
'			Me.barButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem1_ItemClick);
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(48, 88)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(100, 20)
			Me.textEdit1.TabIndex = 4
			' 
			' UserControl1
			' 
			Me.BackColor = System.Drawing.SystemColors.ControlDark
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "UserControl1"
			Me.Size = New System.Drawing.Size(314, 173)
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub MergeToolbars(ByVal merge As Boolean)
			For Each bar As Bar In thisManager.Bars
				Dim mainBar As Bar = mainManager.Bars(bar.BarName)
				If mainBar IsNot Nothing Then
					If merge Then
						mainBar.Merge(bar)
						bar.Visible = False
					Else
						mainBar.UnMerge()
					End If
				End If
			Next bar
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			If (Not DesignMode) AndAlso mainManager IsNot Nothing Then
				thisManager.ForceInitialize()
				MergeToolbars(True)
			End If
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If mainManager IsNot Nothing Then
					MergeToolbars(False)
				End If
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			MessageBox.Show(e.Item.Caption)
		End Sub
	End Class
End Namespace

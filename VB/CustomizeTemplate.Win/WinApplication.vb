' Developer Express Code Central Example:
' How to Customize a Template
' 
' This example demonstrates how to customize Windows Forms Templates. The Edit
' Model item is removed from the Tools menu in the MainForm Template. See code at
' the bottom of the MainFrom.cs (MainForm.vb) file and in the Program.cs
' (Program.vb) file. For details, refer to the How to: Customize a Template
' (ms-help://DevExpress.Xaf/CustomDocument2618.htm) topic in XAF documentation.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E216

Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Xpo

Namespace CustomizeTemplate.Win
	Partial Public Class CustomizeTemplateWindowsFormsApplication
		Inherits WinApplication

		Public Sub New()
			InitializeComponent()
			DelayedViewItemsInitialization = True
		End Sub

		Private Sub CustomizeTemplateWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
			e.Updater.Update()
			e.Handled = True
		End Sub
		Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
			args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
		End Sub
	End Class
End Namespace

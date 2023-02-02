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

Imports System.Configuration

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.Win.SystemModule

Namespace CustomizeTemplate.Win
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
                        DevExpress.ExpressApp.FrameworkSettings.DefaultSettingsCompatibilityMode = DevExpress.ExpressApp.FrameworkSettingsCompatibilityMode.v20_1
Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
            Dim winApplication As New CustomizeTemplateWindowsFormsApplication()
            AddHandler winApplication.CreateCustomTemplate, AddressOf winApplication_CreateCustomTemplate

            InMemoryDataStoreProvider.Register()
            winApplication.ConnectionString = InMemoryDataStoreProvider.ConnectionString


            Try
                winApplication.Setup()
                winApplication.Start()
            Catch e As Exception
                winApplication.HandleException(e)
            End Try
        End Sub
        Private Shared Sub winApplication_CreateCustomTemplate(ByVal sender As Object, ByVal e As CreateCustomTemplateEventArgs)
            Dim isRibbon As Boolean = (CType(e.Application.Model.Options, IModelOptionsWin)).FormStyle = DevExpress.XtraBars.Ribbon.RibbonFormStyle.Ribbon
            If isRibbon AndAlso e.Context = TemplateContext.View Then
                e.Template = New DetailRibbonForm1()
            End If
        End Sub
    End Class
End Namespace

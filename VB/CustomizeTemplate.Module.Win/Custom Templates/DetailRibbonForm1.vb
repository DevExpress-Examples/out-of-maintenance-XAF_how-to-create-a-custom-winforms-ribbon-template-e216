Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Model
Imports DevExpress.ExpressApp.Templates
Imports DevExpress.ExpressApp.Templates.ActionControls
Imports DevExpress.ExpressApp.Win.Controls
Imports DevExpress.ExpressApp.Win.SystemModule
Imports DevExpress.ExpressApp.Win.Templates
Imports DevExpress.ExpressApp.Win.Templates.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Partial Public Class DetailRibbonForm1
    Inherits RibbonForm
    Implements IActionControlsSite
    Implements IContextMenuHolder
    Implements IWindowTemplate
    Implements IBarManagerHolder
    Implements ISupportViewChanged
    Implements ISupportUpdate
    Implements IViewSiteTemplate
    Implements ISupportStoreSettings
    Implements IViewHolder
    Private Shared ReadOnly viewChanged As New Object()
    Private Shared ReadOnly settingsReloaded As New Object()
    Private statusMessagesHelper As StatusMessagesHelper

    Protected Overridable Sub RaiseViewChanged(view As DevExpress.ExpressApp.View)
        RaiseEvent ISupportViewChanged_ViewChanged(Me, New TemplateViewChangedEventArgs(view))
    End Sub
    Protected Overridable Sub RaiseSettingsReloaded()
        RaiseEvent ISupportStoreSettings_SettingsReloaded(Me, EventArgs.Empty)
    End Sub

    Public Sub New()
        InitializeComponent()
        ribbonControl.Manager.ForceLinkCreate()
        statusMessagesHelper = New StatusMessagesHelper(barContainerStatusMessages)
    End Sub

#Region "IActionControlsSite Members"
    Private ReadOnly Property IActionControlsSite_ActionContainers() As IEnumerable(Of IActionControlContainer) Implements IActionControlsSite.ActionContainers
        Get
            Return ribbonControl.ActionContainers
        End Get
    End Property
    Private ReadOnly Property IActionControlsSite_ActionControls() As IEnumerable(Of IActionControl) Implements IActionControlsSite.ActionControls
        Get
            Return ribbonControl.ActionControls
        End Get
    End Property
    Private ReadOnly Property IActionControlsSite_DefaultContainer() As IActionControlContainer Implements IActionControlsSite.DefaultContainer
        Get
            Return barActionContainerView
        End Get
    End Property
#End Region

#Region "IFrameTemplate Members"
    Private Sub IFrameTemplate_SetView(view As DevExpress.ExpressApp.View) Implements IFrameTemplate.SetView
        viewSiteManager.SetView(view)
        RaiseViewChanged(view)
    End Sub
    Private Function IFrameTemplate_GetContainers() As ICollection(Of IActionContainer) Implements IFrameTemplate.GetContainers
        Return New IActionContainer() {}
    End Function
    Private ReadOnly Property IFrameTemplate_DefaultContainer() As IActionContainer Implements IFrameTemplate.DefaultContainer
        Get
            Return Nothing
        End Get
    End Property
#End Region

#Region "IWindowTemplate Members"
    Private Sub IWindowTemplate_SetCaption(caption As String) Implements IWindowTemplate.SetCaption
        Text = caption
    End Sub
    Private Sub IWindowTemplate_SetStatus(statusMessages As ICollection(Of String)) Implements IWindowTemplate.SetStatus
        statusMessagesHelper.SetMessages(statusMessages)
    End Sub
    Private Property IWindowTemplate_IsSizeable() As Boolean Implements IWindowTemplate.IsSizeable
        Get
            Return FormBorderStyle.Sizable = FormBorderStyle
        End Get
        Set(value As Boolean)
            FormBorderStyle = If(value, FormBorderStyle.Sizable, FormBorderStyle.FixedDialog)
        End Set
    End Property
#End Region

#Region "IBarManagerHolder Members"
    Private ReadOnly Property IBarManagerHolder_BarManager() As BarManager Implements IBarManagerHolder.BarManager
        Get
            Return ribbonControl.Manager
        End Get
    End Property
    Private Custom Event IBarManagerHolder_BarManagerChanged As EventHandler Implements IBarManagerHolder.BarManagerChanged
        AddHandler(ByVal value As EventHandler)
        End AddHandler
        RemoveHandler(ByVal value As EventHandler)
        End RemoveHandler
        RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
        End RaiseEvent
    End Event
#End Region

#Region "IContextMenuHolder"
    Private ReadOnly Property IContextMenuHolder_ContextMenu() As PopupMenu Implements IContextMenuHolder.ContextMenu
        Get
            Return templateContextMenu
        End Get
    End Property
#End Region

#Region "ISupportViewChanged Members"
    Private Custom Event ISupportViewChanged_ViewChanged As EventHandler(Of TemplateViewChangedEventArgs) Implements ISupportViewChanged.ViewChanged
        AddHandler(ByVal value As EventHandler(Of TemplateViewChangedEventArgs))
            Events.AddHandler(viewChanged, value)
        End AddHandler
        RemoveHandler(ByVal value As EventHandler(Of TemplateViewChangedEventArgs))
            Events.RemoveHandler(viewChanged, value)
        End RemoveHandler
        RaiseEvent(ByVal sender As Object, ByVal e As TemplateViewChangedEventArgs)
            Dim handler As EventHandler(Of TemplateViewChangedEventArgs) = CType(Events(viewChanged), EventHandler(Of TemplateViewChangedEventArgs))
            If (handler IsNot Nothing) Then
                handler.Invoke(sender, e)
            End If
        End RaiseEvent
    End Event
#End Region

#Region "ISupportUpdate Members"
    Private Sub ISupportUpdate_BeginUpdate() Implements ISupportUpdate.BeginUpdate
        If ribbonControl.Manager IsNot Nothing Then
            ribbonControl.Manager.BeginUpdate()
        End If
    End Sub
    Private Sub ISupportUpdate_EndUpdate() Implements ISupportUpdate.EndUpdate
        If ribbonControl.Manager IsNot Nothing Then
            ribbonControl.Manager.EndUpdate()
        End If
    End Sub
#End Region

#Region "IViewSiteTemplate Members"
    Private ReadOnly Property IViewSiteTemplate_ViewSiteControl() As Object Implements IViewSiteTemplate.ViewSiteControl
        Get
            Return viewSiteManager.ViewSiteControl
        End Get
    End Property
#End Region

#Region "ISupportStoreSettings Members"
    Private Sub ISupportStoreSettings_SetSettings(settings As IModelTemplate) Implements ISupportStoreSettings.SetSettings
        Dim templateModel As IModelTemplateWin = DirectCast(settings, IModelTemplateWin)
        Dim templatesHelper As New TemplatesHelper(templateModel)
        Dim formState As IModelFormState
        If ViewSiteManager.View IsNot Nothing Then
            formState = templatesHelper.GetFormStateNode(ViewSiteManager.View.Id)
        Else
            formState = templatesHelper.GetFormStateNode()
        End If
        formStateModelSynchronizer.Model = formState
        templatesHelper.SetRibbonSettings(RibbonControl)
    End Sub
    Private Sub ISupportStoreSettings_ReloadSettings() Implements ISupportStoreSettings.ReloadSettings
        modelSynchronizationManager.ApplyModel()
        RaiseSettingsReloaded()
    End Sub
    Private Sub ISupportStoreSettings_SaveSettings() Implements ISupportStoreSettings.SaveSettings
        SuspendLayout()
        Try
            modelSynchronizationManager.SynchronizeModel()
        Finally
            ResumeLayout()
        End Try
    End Sub
    Private Custom Event ISupportStoreSettings_SettingsReloaded As EventHandler Implements ISupportStoreSettings.SettingsReloaded
        AddHandler(ByVal value As EventHandler)
            Events.AddHandler(settingsReloaded, value)
        End AddHandler
        RemoveHandler(ByVal value As EventHandler)
            Events.RemoveHandler(settingsReloaded, value)
        End RemoveHandler
        RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            Dim handler As EventHandler = CType(Events(settingsReloaded), EventHandler)
            If (handler IsNot Nothing) Then
                handler.Invoke(sender, e)
            End If
        End RaiseEvent
    End Event
#End Region

#Region "IViewHolder Members"
    Private ReadOnly Property IViewHolder_View() As DevExpress.ExpressApp.View Implements IViewHolder.View
        Get
            Return viewSiteManager.View
        End Get
    End Property
#End Region
End Class

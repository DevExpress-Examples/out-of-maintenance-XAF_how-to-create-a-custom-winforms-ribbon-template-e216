Partial Class DetailRibbonForm1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailRibbonForm1))
        Me.ribbonControl = New DevExpress.ExpressApp.Win.Templates.Ribbon.XafRibbonControlV2()
        Me.barActionContainerObjectsCreation = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerObjectsCreation = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerClose = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerClose = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerFile = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerFile = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerSave = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerSave = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerEdit = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerEdit = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerOpenObject = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerOpenObject = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerUndoRedo = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerUndoRedo = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerReports = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerReports = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerPrint = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerPrint = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerExport = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerExport = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerRecordEdit = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerRecordEdit = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerWorkflow = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerWorkflow = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerView = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerView = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerRecordsNavigation = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerRecordsNavigation = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerFilters = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerFilters = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerSearch = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerSearch = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerFullTextSearch = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerFullTextSearch = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerTools = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerTools = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerDiagnostic = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerDiagnostic = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerOptions = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerOptions = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerAbout = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerAbout = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerMenu = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerMenu = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.barActionContainerNotifications = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        Me.barContainerNotifications = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.applicationMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.barContainerStatusMessages = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.defaultPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonGroupObjectsCreation = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupSave = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupEdit = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupRecordEdit = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupOpenObject = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupWorkflow = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupView = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupRecordsNavigation = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupClose = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupFilters = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupSearch = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupFullTextSearch = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.toolsPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonGroupTools = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupOptions = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonGroupDiagnostic = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.viewSitePanel = New DevExpress.XtraEditors.PanelControl()
        Me.viewSiteManager = New DevExpress.ExpressApp.Win.Templates.ViewSiteManager(Me.components)
        Me.modelSynchronizationManager = New DevExpress.ExpressApp.Win.Templates.ModelSynchronizationManager(Me.components)
        Me.formStateModelSynchronizer = New DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer(Me.components)
        Me.templateContextMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.myRibbonPageCategory = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.myRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.myRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.barContainerMy = New DevExpress.XtraBars.BarLinkContainerExItem()
        Me.BarLinkActionControlContainer1 = New DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerObjectsCreation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerOpenObject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerUndoRedo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerRecordEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerWorkflow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerRecordsNavigation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerFullTextSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerTools, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerDiagnostic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barActionContainerNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.applicationMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.templateContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarLinkActionControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl
        '
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerObjectsCreation)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerClose)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerFile)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerSave)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerEdit)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerOpenObject)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerUndoRedo)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerReports)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerPrint)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerExport)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerRecordEdit)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerWorkflow)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerView)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerRecordsNavigation)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerFilters)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerSearch)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerFullTextSearch)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerTools)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerDiagnostic)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerOptions)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerAbout)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerMenu)
        Me.ribbonControl.ActionContainers.Add(Me.barActionContainerNotifications)
        Me.ribbonControl.ActionContainers.Add(Me.BarLinkActionControlContainer1)
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.applicationMenu
        Me.ribbonControl.AutoHideEmptyItems = True
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.barContainerFile, Me.barContainerObjectsCreation, Me.barContainerClose, Me.barContainerSave, Me.barContainerEdit, Me.barContainerOpenObject, Me.barContainerUndoRedo, Me.barContainerReports, Me.barContainerPrint, Me.barContainerExport, Me.barContainerWorkflow, Me.barContainerRecordEdit, Me.barContainerView, Me.barContainerRecordsNavigation, Me.barContainerSearch, Me.barContainerFullTextSearch, Me.barContainerAbout, Me.barContainerMenu, Me.barContainerNotifications, Me.barContainerStatusMessages, Me.barContainerMy})
        resources.ApplyResources(Me.ribbonControl, "ribbonControl")
        Me.ribbonControl.MaxItemId = 4
        Me.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.myRibbonPageCategory})
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.defaultPage, Me.toolsPage})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        '
        'barActionContainerObjectsCreation
        '
        Me.barActionContainerObjectsCreation.ActionCategory = "ObjectsCreation"
        Me.barActionContainerObjectsCreation.BarContainerItem = Me.barContainerObjectsCreation
        '
        'barContainerObjectsCreation
        '
        resources.ApplyResources(Me.barContainerObjectsCreation, "barContainerObjectsCreation")
        Me.barContainerObjectsCreation.Id = 17
        Me.barContainerObjectsCreation.MergeOrder = 1
        Me.barContainerObjectsCreation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerObjectsCreation.Name = "barContainerObjectsCreation"
        '
        'barActionContainerClose
        '
        Me.barActionContainerClose.ActionCategory = "Close"
        Me.barActionContainerClose.BarContainerItem = Me.barContainerClose
        '
        'barContainerClose
        '
        resources.ApplyResources(Me.barContainerClose, "barContainerClose")
        Me.barContainerClose.Id = 18
        Me.barContainerClose.MergeOrder = 2
        Me.barContainerClose.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerClose.Name = "barContainerClose"
        '
        'barActionContainerFile
        '
        Me.barActionContainerFile.ActionCategory = "File"
        Me.barActionContainerFile.BarContainerItem = Me.barContainerFile
        '
        'barContainerFile
        '
        resources.ApplyResources(Me.barContainerFile, "barContainerFile")
        Me.barContainerFile.Id = 5
        Me.barContainerFile.MergeOrder = 2
        Me.barContainerFile.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerFile.Name = "barContainerFile"
        '
        'barActionContainerSave
        '
        Me.barActionContainerSave.ActionCategory = "Save"
        Me.barActionContainerSave.BarContainerItem = Me.barContainerSave
        '
        'barContainerSave
        '
        resources.ApplyResources(Me.barContainerSave, "barContainerSave")
        Me.barContainerSave.Id = 17
        Me.barContainerSave.MergeOrder = 7
        Me.barContainerSave.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerSave.Name = "barContainerSave"
        '
        'barActionContainerEdit
        '
        Me.barActionContainerEdit.ActionCategory = "Edit"
        Me.barActionContainerEdit.BarContainerItem = Me.barContainerEdit
        '
        'barContainerEdit
        '
        resources.ApplyResources(Me.barContainerEdit, "barContainerEdit")
        Me.barContainerEdit.Id = 18
        Me.barContainerEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerEdit.Name = "barContainerEdit"
        '
        'barActionContainerOpenObject
        '
        Me.barActionContainerOpenObject.ActionCategory = "OpenObject"
        Me.barActionContainerOpenObject.BarContainerItem = Me.barContainerOpenObject
        '
        'barContainerOpenObject
        '
        resources.ApplyResources(Me.barContainerOpenObject, "barContainerOpenObject")
        Me.barContainerOpenObject.Id = 20
        Me.barContainerOpenObject.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerOpenObject.Name = "barContainerOpenObject"
        '
        'barActionContainerUndoRedo
        '
        Me.barActionContainerUndoRedo.ActionCategory = "UndoRedo"
        Me.barActionContainerUndoRedo.BarContainerItem = Me.barContainerUndoRedo
        '
        'barContainerUndoRedo
        '
        resources.ApplyResources(Me.barContainerUndoRedo, "barContainerUndoRedo")
        Me.barContainerUndoRedo.Id = 19
        Me.barContainerUndoRedo.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerUndoRedo.Name = "barContainerUndoRedo"
        '
        'barActionContainerReports
        '
        Me.barActionContainerReports.ActionCategory = "Reports"
        Me.barActionContainerReports.BarContainerItem = Me.barContainerReports
        '
        'barContainerReports
        '
        resources.ApplyResources(Me.barContainerReports, "barContainerReports")
        Me.barContainerReports.Id = 20
        Me.barContainerReports.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerReports.Name = "barContainerReports"
        '
        'barActionContainerPrint
        '
        Me.barActionContainerPrint.ActionCategory = "Print"
        Me.barActionContainerPrint.BarContainerItem = Me.barContainerPrint
        '
        'barContainerPrint
        '
        resources.ApplyResources(Me.barContainerPrint, "barContainerPrint")
        Me.barContainerPrint.Id = 6
        Me.barContainerPrint.MergeOrder = 11
        Me.barContainerPrint.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerPrint.Name = "barContainerPrint"
        '
        'barActionContainerExport
        '
        Me.barActionContainerExport.ActionCategory = "Export"
        Me.barActionContainerExport.BarContainerItem = Me.barContainerExport
        '
        'barContainerExport
        '
        resources.ApplyResources(Me.barContainerExport, "barContainerExport")
        Me.barContainerExport.Id = 7
        Me.barContainerExport.MergeOrder = 10
        Me.barContainerExport.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerExport.Name = "barContainerExport"
        '
        'barActionContainerRecordEdit
        '
        Me.barActionContainerRecordEdit.ActionCategory = "RecordEdit"
        Me.barActionContainerRecordEdit.BarContainerItem = Me.barContainerRecordEdit
        '
        'barContainerRecordEdit
        '
        resources.ApplyResources(Me.barContainerRecordEdit, "barContainerRecordEdit")
        Me.barContainerRecordEdit.Id = 9
        Me.barContainerRecordEdit.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerRecordEdit.Name = "barContainerRecordEdit"
        '
        'barActionContainerWorkflow
        '
        Me.barActionContainerWorkflow.ActionCategory = "Workflow"
        Me.barActionContainerWorkflow.BarContainerItem = Me.barContainerWorkflow
        '
        'barContainerWorkflow
        '
        resources.ApplyResources(Me.barContainerWorkflow, "barContainerWorkflow")
        Me.barContainerWorkflow.Id = 9
        Me.barContainerWorkflow.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerWorkflow.Name = "barContainerWorkflow"
        '
        'barActionContainerView
        '
        Me.barActionContainerView.ActionCategory = "View"
        Me.barActionContainerView.BarContainerItem = Me.barContainerView
        '
        'barContainerView
        '
        resources.ApplyResources(Me.barContainerView, "barContainerView")
        Me.barContainerView.Id = 12
        Me.barContainerView.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerView.Name = "barContainerView"
        '
        'barActionContainerRecordsNavigation
        '
        Me.barActionContainerRecordsNavigation.ActionCategory = "RecordsNavigation"
        Me.barActionContainerRecordsNavigation.BarContainerItem = Me.barContainerRecordsNavigation
        '
        'barContainerRecordsNavigation
        '
        resources.ApplyResources(Me.barContainerRecordsNavigation, "barContainerRecordsNavigation")
        Me.barContainerRecordsNavigation.Id = 10
        Me.barContainerRecordsNavigation.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerRecordsNavigation.Name = "barContainerRecordsNavigation"
        '
        'barActionContainerFilters
        '
        Me.barActionContainerFilters.ActionCategory = "Filters"
        Me.barActionContainerFilters.BarContainerItem = Me.barContainerFilters
        '
        'barContainerFilters
        '
        resources.ApplyResources(Me.barContainerFilters, "barContainerFilters")
        Me.barContainerFilters.Id = 26
        Me.barContainerFilters.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerFilters.Name = "barContainerFilters"
        '
        'barActionContainerSearch
        '
        Me.barActionContainerSearch.ActionCategory = "Search"
        Me.barActionContainerSearch.BarContainerItem = Me.barContainerSearch
        '
        'barContainerSearch
        '
        resources.ApplyResources(Me.barContainerSearch, "barContainerSearch")
        Me.barContainerSearch.Id = 11
        Me.barContainerSearch.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerSearch.Name = "barContainerSearch"
        '
        'barActionContainerFullTextSearch
        '
        Me.barActionContainerFullTextSearch.ActionCategory = "FullTextSearch"
        Me.barActionContainerFullTextSearch.BarContainerItem = Me.barContainerFullTextSearch
        '
        'barContainerFullTextSearch
        '
        resources.ApplyResources(Me.barContainerFullTextSearch, "barContainerFullTextSearch")
        Me.barContainerFullTextSearch.Id = 12
        Me.barContainerFullTextSearch.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerFullTextSearch.Name = "barContainerFullTextSearch"
        '
        'barActionContainerTools
        '
        Me.barActionContainerTools.ActionCategory = "Tools"
        Me.barActionContainerTools.BarContainerItem = Me.barContainerTools
        Me.barActionContainerTools.IsMenuMode = True
        '
        'barContainerTools
        '
        resources.ApplyResources(Me.barContainerTools, "barContainerTools")
        Me.barContainerTools.Id = 13
        Me.barContainerTools.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerTools.Name = "barContainerTools"
        '
        'barActionContainerDiagnostic
        '
        Me.barActionContainerDiagnostic.ActionCategory = "Diagnostic"
        Me.barActionContainerDiagnostic.BarContainerItem = Me.barContainerDiagnostic
        Me.barActionContainerDiagnostic.IsMenuMode = True
        '
        'barContainerDiagnostic
        '
        resources.ApplyResources(Me.barContainerDiagnostic, "barContainerDiagnostic")
        Me.barContainerDiagnostic.Id = 16
        Me.barContainerDiagnostic.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerDiagnostic.Name = "barContainerDiagnostic"
        '
        'barActionContainerOptions
        '
        Me.barActionContainerOptions.ActionCategory = "Options"
        Me.barActionContainerOptions.BarContainerItem = Me.barContainerOptions
        Me.barActionContainerOptions.IsMenuMode = True
        '
        'barContainerOptions
        '
        resources.ApplyResources(Me.barContainerOptions, "barContainerOptions")
        Me.barContainerOptions.Id = 14
        Me.barContainerOptions.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerOptions.Name = "barContainerOptions"
        '
        'barActionContainerAbout
        '
        Me.barActionContainerAbout.ActionCategory = "About"
        Me.barActionContainerAbout.BarContainerItem = Me.barContainerAbout
        Me.barActionContainerAbout.IsMenuMode = True
        '
        'barContainerAbout
        '
        resources.ApplyResources(Me.barContainerAbout, "barContainerAbout")
        Me.barContainerAbout.Id = 15
        Me.barContainerAbout.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerAbout.Name = "barContainerAbout"
        '
        'barActionContainerMenu
        '
        Me.barActionContainerMenu.ActionCategory = "Menu"
        Me.barActionContainerMenu.BarContainerItem = Me.barContainerMenu
        '
        'barContainerMenu
        '
        resources.ApplyResources(Me.barContainerMenu, "barContainerMenu")
        Me.barContainerMenu.Id = 8
        Me.barContainerMenu.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerMenu.Name = "barContainerMenu"
        '
        'barActionContainerNotifications
        '
        Me.barActionContainerNotifications.ActionCategory = "Notifications"
        Me.barActionContainerNotifications.BarContainerItem = Me.barContainerNotifications
        '
        'barContainerNotifications
        '
        Me.barContainerNotifications.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        resources.ApplyResources(Me.barContainerNotifications, "barContainerNotifications")
        Me.barContainerNotifications.Id = 28
        Me.barContainerNotifications.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerNotifications.Name = "barContainerNotifications"
        '
        'applicationMenu
        '
        Me.applicationMenu.ItemLinks.Add(Me.barContainerObjectsCreation, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerFile, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerClose, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerSave, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerExport, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerPrint, True)
        Me.applicationMenu.ItemLinks.Add(Me.barContainerAbout, True)
        Me.applicationMenu.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesText
        Me.applicationMenu.Name = "applicationMenu"
        Me.applicationMenu.Ribbon = Me.ribbonControl
        '
        'barContainerStatusMessages
        '
        resources.ApplyResources(Me.barContainerStatusMessages, "barContainerStatusMessages")
        Me.barContainerStatusMessages.Id = 27
        Me.barContainerStatusMessages.MergeType = DevExpress.XtraBars.BarMenuMerge.MergeItems
        Me.barContainerStatusMessages.Name = "barContainerStatusMessages"
        '
        'defaultPage
        '
        Me.defaultPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonGroupObjectsCreation, Me.ribbonGroupSave, Me.ribbonGroupEdit, Me.ribbonGroupRecordEdit, Me.ribbonGroupOpenObject, Me.ribbonGroupWorkflow, Me.ribbonGroupView, Me.ribbonGroupRecordsNavigation, Me.ribbonGroupClose, Me.ribbonGroupFilters, Me.ribbonGroupSearch, Me.ribbonGroupFullTextSearch})
        Me.defaultPage.Name = "defaultPage"
        resources.ApplyResources(Me.defaultPage, "defaultPage")
        '
        'ribbonGroupObjectsCreation
        '
        Me.ribbonGroupObjectsCreation.AllowTextClipping = False
        Me.ribbonGroupObjectsCreation.ItemLinks.Add(Me.barContainerObjectsCreation)
        Me.ribbonGroupObjectsCreation.Name = "ribbonGroupObjectsCreation"
        Me.ribbonGroupObjectsCreation.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupObjectsCreation, "ribbonGroupObjectsCreation")
        '
        'ribbonGroupSave
        '
        Me.ribbonGroupSave.AllowTextClipping = False
        Me.ribbonGroupSave.ItemLinks.Add(Me.barContainerSave)
        Me.ribbonGroupSave.Name = "ribbonGroupSave"
        Me.ribbonGroupSave.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupSave, "ribbonGroupSave")
        '
        'ribbonGroupEdit
        '
        Me.ribbonGroupEdit.AllowTextClipping = False
        Me.ribbonGroupEdit.ItemLinks.Add(Me.barContainerEdit)
        Me.ribbonGroupEdit.ItemLinks.Add(Me.barContainerUndoRedo)
        Me.ribbonGroupEdit.Name = "ribbonGroupEdit"
        Me.ribbonGroupEdit.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupEdit, "ribbonGroupEdit")
        '
        'ribbonGroupRecordEdit
        '
        Me.ribbonGroupRecordEdit.AllowTextClipping = False
        Me.ribbonGroupRecordEdit.ItemLinks.Add(Me.barContainerRecordEdit)
        Me.ribbonGroupRecordEdit.Name = "ribbonGroupRecordEdit"
        Me.ribbonGroupRecordEdit.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupRecordEdit, "ribbonGroupRecordEdit")
        '
        'ribbonGroupOpenObject
        '
        Me.ribbonGroupOpenObject.AllowTextClipping = False
        Me.ribbonGroupOpenObject.ItemLinks.Add(Me.barContainerOpenObject)
        Me.ribbonGroupOpenObject.Name = "ribbonGroupOpenObject"
        Me.ribbonGroupOpenObject.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupOpenObject, "ribbonGroupOpenObject")
        '
        'ribbonGroupWorkflow
        '
        Me.ribbonGroupWorkflow.AllowTextClipping = False
        Me.ribbonGroupWorkflow.ItemLinks.Add(Me.barContainerWorkflow)
        Me.ribbonGroupWorkflow.Name = "ribbonGroupWorkflow"
        Me.ribbonGroupWorkflow.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupWorkflow, "ribbonGroupWorkflow")
        '
        'ribbonGroupView
        '
        Me.ribbonGroupView.AllowTextClipping = False
        Me.ribbonGroupView.ItemLinks.Add(Me.barContainerView)
        Me.ribbonGroupView.ItemLinks.Add(Me.barContainerReports)
        Me.ribbonGroupView.Name = "ribbonGroupView"
        Me.ribbonGroupView.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupView, "ribbonGroupView")
        '
        'ribbonGroupRecordsNavigation
        '
        Me.ribbonGroupRecordsNavigation.AllowTextClipping = False
        Me.ribbonGroupRecordsNavigation.ItemLinks.Add(Me.barContainerRecordsNavigation)
        Me.ribbonGroupRecordsNavigation.Name = "ribbonGroupRecordsNavigation"
        Me.ribbonGroupRecordsNavigation.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupRecordsNavigation, "ribbonGroupRecordsNavigation")
        '
        'ribbonGroupClose
        '
        Me.ribbonGroupClose.AllowTextClipping = False
        Me.ribbonGroupClose.ItemLinks.Add(Me.barContainerClose)
        Me.ribbonGroupClose.Name = "ribbonGroupClose"
        Me.ribbonGroupClose.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupClose, "ribbonGroupClose")
        '
        'ribbonGroupFilters
        '
        Me.ribbonGroupFilters.AllowTextClipping = False
        Me.ribbonGroupFilters.ItemLinks.Add(Me.barContainerFilters)
        Me.ribbonGroupFilters.Name = "ribbonGroupFilters"
        Me.ribbonGroupFilters.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupFilters, "ribbonGroupFilters")
        '
        'ribbonGroupSearch
        '
        Me.ribbonGroupSearch.AllowTextClipping = False
        Me.ribbonGroupSearch.ItemLinks.Add(Me.barContainerSearch)
        Me.ribbonGroupSearch.Name = "ribbonGroupSearch"
        Me.ribbonGroupSearch.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupSearch, "ribbonGroupSearch")
        '
        'ribbonGroupFullTextSearch
        '
        Me.ribbonGroupFullTextSearch.AllowTextClipping = False
        Me.ribbonGroupFullTextSearch.ItemLinks.Add(Me.barContainerFullTextSearch)
        Me.ribbonGroupFullTextSearch.Name = "ribbonGroupFullTextSearch"
        Me.ribbonGroupFullTextSearch.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupFullTextSearch, "ribbonGroupFullTextSearch")
        '
        'toolsPage
        '
        Me.toolsPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonGroupTools, Me.ribbonGroupOptions, Me.ribbonGroupDiagnostic})
        Me.toolsPage.Name = "toolsPage"
        resources.ApplyResources(Me.toolsPage, "toolsPage")
        '
        'ribbonGroupTools
        '
        Me.ribbonGroupTools.AllowTextClipping = False
        Me.ribbonGroupTools.ItemLinks.Add(Me.barContainerTools)
        Me.ribbonGroupTools.Name = "ribbonGroupTools"
        Me.ribbonGroupTools.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupTools, "ribbonGroupTools")
        '
        'ribbonGroupOptions
        '
        Me.ribbonGroupOptions.AllowTextClipping = False
        Me.ribbonGroupOptions.ItemLinks.Add(Me.barContainerOptions)
        Me.ribbonGroupOptions.Name = "ribbonGroupOptions"
        Me.ribbonGroupOptions.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupOptions, "ribbonGroupOptions")
        '
        'ribbonGroupDiagnostic
        '
        Me.ribbonGroupDiagnostic.AllowTextClipping = False
        Me.ribbonGroupDiagnostic.ItemLinks.Add(Me.barContainerDiagnostic)
        Me.ribbonGroupDiagnostic.Name = "ribbonGroupDiagnostic"
        Me.ribbonGroupDiagnostic.ShowCaptionButton = False
        resources.ApplyResources(Me.ribbonGroupDiagnostic, "ribbonGroupDiagnostic")
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.barContainerStatusMessages)
        Me.ribbonStatusBar.ItemLinks.Add(Me.barContainerNotifications)
        resources.ApplyResources(Me.ribbonStatusBar, "ribbonStatusBar")
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        '
        'viewSitePanel
        '
        Me.viewSitePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        resources.ApplyResources(Me.viewSitePanel, "viewSitePanel")
        Me.viewSitePanel.Name = "viewSitePanel"
        '
        'viewSiteManager
        '
        Me.viewSiteManager.ViewSiteControl = Me.viewSitePanel
        '
        'modelSynchronizationManager
        '
        Me.modelSynchronizationManager.ModelSynchronizableComponents.Add(Me.formStateModelSynchronizer)
        '
        'formStateModelSynchronizer
        '
        Me.formStateModelSynchronizer.Form = Me
        '
        'templateContextMenu
        '
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerObjectsCreation, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerSave, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerEdit, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerOpenObject, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerUndoRedo, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerReports, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerClose, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerRecordEdit, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerView, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerPrint, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerExport, True)
        Me.templateContextMenu.ItemLinks.Add(Me.barContainerMenu, True)
        Me.templateContextMenu.Name = "templateContextMenu"
        Me.templateContextMenu.Ribbon = Me.ribbonControl
        '
        'myRibbonPageCategory
        '
        Me.myRibbonPageCategory.Name = "myRibbonPageCategory"
        Me.myRibbonPageCategory.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.myRibbonPage})
        resources.ApplyResources(Me.myRibbonPageCategory, "myRibbonPageCategory")
        '
        'myRibbonPage
        '
        Me.myRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.myRibbonPageGroup})
        Me.myRibbonPage.Name = "myRibbonPage"
        resources.ApplyResources(Me.myRibbonPage, "myRibbonPage")
        '
        'myRibbonPageGroup
        '
        Me.myRibbonPageGroup.AllowTextClipping = False
        Me.myRibbonPageGroup.ItemLinks.Add(Me.barContainerMy)
        Me.myRibbonPageGroup.Name = "myRibbonPageGroup"
        resources.ApplyResources(Me.myRibbonPageGroup, "myRibbonPageGroup")
        '
        'barContainerMy
        '
        resources.ApplyResources(Me.barContainerMy, "barContainerMy")
        Me.barContainerMy.Id = 3
        Me.barContainerMy.Name = "barContainerMy"
        '
        'BarLinkActionControlContainer1
        '
        Me.BarLinkActionControlContainer1.ActionCategory = "MyActionCategory"
        Me.BarLinkActionControlContainer1.BarContainerItem = Me.barContainerMy
        '
        'DetailRibbonForm1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.viewSitePanel)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "DetailRibbonForm1"
        Me.Ribbon = Me.ribbonControl
        Me.StatusBar = Me.ribbonStatusBar
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerObjectsCreation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerOpenObject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerUndoRedo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerRecordEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerWorkflow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerRecordsNavigation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerFullTextSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerTools, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerDiagnostic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerAbout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barActionContainerNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.applicationMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewSitePanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.templateContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarLinkActionControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private ribbonControl As DevExpress.ExpressApp.Win.Templates.Ribbon.XafRibbonControlV2
    Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private viewSitePanel As DevExpress.XtraEditors.PanelControl
    Private formStateModelSynchronizer As DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer
    Private modelSynchronizationManager As DevExpress.ExpressApp.Win.Templates.ModelSynchronizationManager
    Private viewSiteManager As DevExpress.ExpressApp.Win.Templates.ViewSiteManager
    Private templateContextMenu As DevExpress.XtraBars.PopupMenu
    Private defaultPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private toolsPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private applicationMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private ribbonGroupObjectsCreation As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupSave As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupEdit As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupOpenObject As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupRecordEdit As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupWorkflow As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupRecordsNavigation As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupSearch As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupFullTextSearch As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupFilters As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupView As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupTools As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupDiagnostic As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupOptions As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private ribbonGroupClose As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private barContainerFile As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerObjectsCreation As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerClose As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerSave As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerEdit As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerOpenObject As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerUndoRedo As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerReports As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerPrint As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerExport As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerRecordEdit As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerWorkflow As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerView As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerRecordsNavigation As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerFilters As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerSearch As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerFullTextSearch As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerTools As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerDiagnostic As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerOptions As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerAbout As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerMenu As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerNotifications As DevExpress.XtraBars.BarLinkContainerExItem
    Private barContainerStatusMessages As DevExpress.XtraBars.BarLinkContainerExItem
    Private barActionContainerFile As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerObjectsCreation As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerClose As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerSave As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerEdit As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerOpenObject As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerUndoRedo As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerReports As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerPrint As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerExport As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerRecordEdit As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerWorkflow As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerView As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerRecordsNavigation As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerFilters As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerSearch As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerFullTextSearch As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerTools As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerDiagnostic As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerOptions As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerAbout As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerMenu As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Private barActionContainerNotifications As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
    Friend WithEvents myRibbonPageCategory As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents myRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents myRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents barContainerMy As DevExpress.XtraBars.BarLinkContainerExItem
    Friend WithEvents BarLinkActionControlContainer1 As DevExpress.ExpressApp.Win.Templates.Bars.ActionControls.BarLinkActionControlContainer
End Class

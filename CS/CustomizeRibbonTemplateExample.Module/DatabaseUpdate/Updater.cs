using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;

namespace CustomizeRibbonTemplateExample.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            //string name = "MyName";
            //DomainObject1 theObject = ObjectSpace.FindObject<DomainObject1>(CriteriaOperator.Parse("Name=?", name));
            //if(theObject == null) {
            //    theObject = ObjectSpace.CreateObject<DomainObject1>();
            //    theObject.Name = name;
            //}
        }
        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
        private SecuritySystemRole CreateDefaultRole() {
            SecuritySystemRole defaultRole = ObjectSpace.FindObject<SecuritySystemRole>(new BinaryOperator("Name", "Default"));
            if(defaultRole == null) {
                defaultRole = ObjectSpace.CreateObject<SecuritySystemRole>();
                defaultRole.Name = "Default";

                defaultRole.AddObjectAccessPermission<SecuritySystemUser>("[Oid] = CurrentUserId()", SecurityOperations.ReadOnlyAccess);
                defaultRole.AddMemberAccessPermission<SecuritySystemUser>("ChangePasswordOnFirstLogon", SecurityOperations.Write);
                defaultRole.AddMemberAccessPermission<SecuritySystemUser>("StoredPassword", SecurityOperations.Write);
                defaultRole.SetTypePermissionsRecursively<SecuritySystemRole>(SecurityOperations.Read, SecuritySystemModifier.Allow);
                defaultRole.SetTypePermissionsRecursively<ModelDifference>(SecurityOperations.ReadWriteAccess, SecuritySystemModifier.Allow);
                defaultRole.SetTypePermissionsRecursively<ModelDifferenceAspect>(SecurityOperations.ReadWriteAccess, SecuritySystemModifier.Allow);
            }
            return defaultRole;
        }
    }
}

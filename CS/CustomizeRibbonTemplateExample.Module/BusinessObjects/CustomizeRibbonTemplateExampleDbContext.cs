using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;

namespace  CustomizeRibbonTemplateExample.Module.BusinessObjects {
	public class CustomizeRibbonTemplateExampleDbContext : DbContext {
		public CustomizeRibbonTemplateExampleDbContext(String connectionString)
			: base(connectionString) {
		}
		public CustomizeRibbonTemplateExampleDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<TypePermissionObject> TypePermissionObjects { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<ModelDifference> ModelDifferences { get; set; }
		public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
	}
}
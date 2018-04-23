using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;

namespace CustomizeRibbonTemplateExample.Module.Controllers {
    public class MyViewController : ViewController {
        public MyViewController() {
            SimpleAction myAction = new SimpleAction(this, "MyAction", "MyActionCategory");
            myAction.ImageName = "Action_SimpleAction";
        }
    }


}

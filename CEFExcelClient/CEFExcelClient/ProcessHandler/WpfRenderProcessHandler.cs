using CEFExcelClient.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xilium.CefGlue;

namespace CEFExcelClient.ProcessHandler
{
    //http://lingyuncxb.com/2018/05/26/CEFGlue%E4%B9%8B%E5%9B%9E%E5%BF%86%E7%AF%87/
    class WpfRenderProcessHandler : CefRenderProcessHandler
    {
        private MyV8Handler myHandle;
        protected override void OnWebKitInitialized()
        {
            myHandle = new MyV8Handler();

            const string jsCode = @"function myHandle() {}

        if (!myHandle) myHandle = {};

        (function() {

            myHandle.__defineGetter__('name',
            function() {
                native function GetName();
                return GetName();
            });

            myHandle.__defineSetter__('name',
            function(arg0) {
                native function SetName(arg0);
                SetName(arg0);
            });

            myHandle.myFunction = function() {
                native function MyFunction();
                return MyFunction();
            };

            myHandle.getEmail = function() {
                native function GetEmail();
                return GetEmail();
            };

            myHandle.setEmail = function(arg0) {
                native function SetEmail(arg0);
                SetEmail(arg0);
            };

        })();";

            CefRuntime.RegisterExtension("myHandleName", jsCode, myHandle);

            base.OnWebKitInitialized();
        }
    }
}

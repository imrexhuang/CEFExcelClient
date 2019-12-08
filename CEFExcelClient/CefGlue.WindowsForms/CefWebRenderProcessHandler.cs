using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xilium.CefGlue.WindowsForms
{
    /* BEG: modbyme */
    internal sealed class CefWebRenderProcessHandler : CefRenderProcessHandler
    {
        private readonly CefWebBrowser _core;

        public CefWebRenderProcessHandler(CefWebBrowser core)
        {
            _core = core;
        }

        protected override CefLoadHandler GetLoadHandler()
        {
            return base.GetLoadHandler();
        }

        //protected override void OnBrowserCreated(CefBrowser browser)
        //{
        //    base.OnBrowserCreated(browser);

        //}

        protected override void OnBrowserDestroyed(CefBrowser browser)
        {
            base.OnBrowserDestroyed(browser);
        }

        protected override void OnContextCreated(CefBrowser browser, CefFrame frame, CefV8Context context)
        {
            base.OnContextCreated(browser, frame, context);
        }

        protected override void OnContextReleased(CefBrowser browser, CefFrame frame, CefV8Context context)
        {
            base.OnContextReleased(browser, frame, context);
        }

        protected override void OnFocusedNodeChanged(CefBrowser browser, CefFrame frame, CefDomNode node)
        {
            base.OnFocusedNodeChanged(browser, frame, node);
        }

        //protected override bool OnProcessMessageReceived(CefBrowser browser, CefProcessId sourceProcess, CefProcessMessage message)
        //{
        //    return base.OnProcessMessageReceived(browser, sourceProcess, message);
        //}

        protected override void OnRenderThreadCreated(CefListValue extraInfo)
        {
            base.OnRenderThreadCreated(extraInfo);
        }

        protected override void OnUncaughtException(CefBrowser browser, CefFrame frame, CefV8Context context, CefV8Exception exception, CefV8StackTrace stackTrace)
        {
            base.OnUncaughtException(browser, frame, context, exception, stackTrace);
        }

        protected override void OnWebKitInitialized()
        {
            base.OnWebKitInitialized();
        }
    }
    /* END: modbyme */
}

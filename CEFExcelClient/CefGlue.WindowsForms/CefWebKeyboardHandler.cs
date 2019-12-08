using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Xilium.CefGlue.WindowsForms
{
    /* BEG: modbyme */
    internal sealed class CefWebKeyboardHandler : CefKeyboardHandler
    {
        private readonly CefWebBrowser _core;

        public CefWebKeyboardHandler(CefWebBrowser core)
        {
            _core = core;
        }

        protected override bool OnKeyEvent(CefBrowser browser, CefKeyEvent keyEvent, IntPtr osEvent)
        {
            if (keyEvent.WindowsKeyCode == Convert.ToInt32(Keys.F5))
            {
                browser.Reload();
            }

            if (keyEvent.WindowsKeyCode == Convert.ToInt32(Keys.F12))
            {
                CefWindowInfo windowInfo = CefWindowInfo.Create();

                windowInfo.SetAsPopup(IntPtr.Zero, "DevTools");

                browser.GetHost().ShowDevTools(windowInfo, new CefWebDevToolsClient(), new CefBrowserSettings(), new CefPoint(0, 0));
            }

            return base.OnKeyEvent(browser, keyEvent, osEvent);
        }

        protected override bool OnPreKeyEvent(CefBrowser browser, CefKeyEvent keyEvent, IntPtr os_event, out bool isKeyboardShortcut)
        {
            return base.OnPreKeyEvent(browser, keyEvent, os_event, out isKeyboardShortcut);
        }
    }
    /* END: modbyme */
}

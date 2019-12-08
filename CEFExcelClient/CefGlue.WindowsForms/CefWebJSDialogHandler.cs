using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xilium.CefGlue.WindowsForms
{
    /* BEG: modbyme */
    internal sealed class CefWebJSDialogHandler : CefJSDialogHandler
    {
        private readonly CefWebBrowser _core;

        public CefWebJSDialogHandler(CefWebBrowser core)
        {
            _core = core;
        }

        protected override bool OnBeforeUnloadDialog(CefBrowser browser, string messageText, bool isReload, CefJSDialogCallback callback)
        {
            //throw new NotImplementedException();
            return true;
        }

        protected override void OnDialogClosed(CefBrowser browser)
        {
            //throw new NotImplementedException();
        }

        protected override bool OnJSDialog(CefBrowser browser, string originUrl, CefJSDialogType dialogType, string message_text, string default_prompt_text, CefJSDialogCallback callback, out bool suppress_message)
        {
            if (dialogType == CefJSDialogType.Alert)
            {
                MessageBox.Show(message_text, "CEF");
                suppress_message = true;
                return false;
            }
            if (dialogType == CefJSDialogType.Confirm)
            {
                DialogResult dialogResult = MessageBox.Show(message_text, "CEF", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    callback.Continue(true, string.Empty);
                    suppress_message = false;
                    return true;
                }
                if (dialogResult == DialogResult.Cancel)
                {
                    callback.Continue(false, string.Empty);
                    suppress_message = false;
                    return true;
                }
            }
            suppress_message = true;
            return false;
        }

        protected override void OnResetDialogState(CefBrowser browser)
        {
            //throw new NotImplementedException();
        }
    }
    /* END: modbyme */
}

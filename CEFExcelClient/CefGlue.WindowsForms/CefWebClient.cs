namespace Xilium.CefGlue.WindowsForms
{
    using System;
    using System.Collections.Generic;
    using Xilium.CefGlue;

    public class CefWebClient : CefClient
    {
        private readonly CefWebBrowser _core;
        private readonly CefWebLifeSpanHandler _lifeSpanHandler;
        private readonly CefWebDisplayHandler _displayHandler;
        private readonly CefWebLoadHandler _loadHandler;
        private readonly CefWebRequestHandler _requestHandler;

        /* BEG:modbyme */
        private readonly CefJSDialogHandler _jsDialogHandler;
        private readonly CefKeyboardHandler _keyboardHandler;
        /* END:modbyme */

        public CefWebClient(CefWebBrowser core)
        {
            _core = core;
            _lifeSpanHandler = new CefWebLifeSpanHandler(_core);
            _displayHandler = new CefWebDisplayHandler(_core);
            _loadHandler = new CefWebLoadHandler(_core);
            _requestHandler = new CefWebRequestHandler(_core);

            /* BEG:modbyme */
            _jsDialogHandler = new CefWebJSDialogHandler(_core);
            _keyboardHandler = new CefWebKeyboardHandler(_core);
            /* END:modbyme */
        }

        protected CefWebBrowser Core { get { return _core; } }

        protected override CefLifeSpanHandler GetLifeSpanHandler()
        {
            return _lifeSpanHandler;
        }

        protected override CefDisplayHandler GetDisplayHandler()
        {
            return _displayHandler;
        }

        protected override CefLoadHandler GetLoadHandler()
        {
            return _loadHandler;
        }

        protected override CefRequestHandler GetRequestHandler()
        {
            return _requestHandler;
        }

        /* BEG:modbyme */
        protected override CefJSDialogHandler GetJSDialogHandler()
        {
            return _jsDialogHandler;
        }

        protected override CefKeyboardHandler GetKeyboardHandler()
        {
            return _keyboardHandler;
        }

        /* END:modbyme */
    }
}

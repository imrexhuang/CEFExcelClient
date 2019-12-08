using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xilium.CefGlue;

namespace CEFExcelClient.Handler
{
    //http://lingyuncxb.com/2018/05/26/CEFGlue%E4%B9%8B%E5%9B%9E%E5%BF%86%E7%AF%87/
    public class MyV8Handler : CefV8Handler
    {
        public MyV8Handler()
        {
            this.name = "lingyun";
        }

        private string name;
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public void MyFunction()
        {
            MessageBox.Show("JS调用C# : MyFunction");
        }

        private string email;
        public string GetEmail()
        {
            return this.email;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

        protected override bool Execute(string name, CefV8Value obj, CefV8Value[] arguments, out CefV8Value returnValue, out string exception)
        {
            string result = string.Empty;
            switch (name)
            {
                case "MyFunction":
                    MyFunction();
                    break;

                case "GetEmail":
                    result = GetEmail();
                    break;

                case "SetEmail":
                    SetEmail(arguments[0].GetStringValue());
                    break;

                default:
                    break;
            }

            returnValue = CefV8Value.CreateString(result);
            exception = null;
            return true;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEFExcelClient
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            cefWebBrowser1.StartUrl = Path.GetFullPath(@"Content\index.html");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;

namespace EdBotApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var responseString = "WEBSERVER1"
            .PostUrlEncodedAsync(new { Hey = "hi"})
            .ReceiveString();

            lblMain.Text = responseString.Result.ToString();


        }

    }
    
}

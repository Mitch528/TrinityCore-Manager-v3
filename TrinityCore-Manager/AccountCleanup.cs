﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TrinityCore_Manager.Database;
using TrinityCore_Manager.Properties;
using TrinityCore_Manager.Security;

namespace TrinityCore_Manager
{
    public partial class AccountCleanup : DevComponents.DotNetBar.Office2007Form
    {
        public AccountCleanup()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            /*
             * 
             * DELETE FROM `auth`.`account` WHERE `last_login` < @date AND `joindate` < @date; -- this will check if account was created long time ago
               or 
               DELETE FROM `auth`.`account` WHERE `last_login` < @date AND `last_login` <> '0000-00-00 00:00:00'; -- this will check if last_login != default value
             * 
             */


            var database = TCManager.Instance.AuthDatabase;

            DateTime combined = dateTimeInput.Value.Date + timeInput.Value.TimeOfDay;

            database.CleanupAccounts(combined);

            this.Close();
        
        }
    }
}

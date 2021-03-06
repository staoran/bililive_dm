﻿using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace Bililive_dm
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class ObjectForScriptingHelper
    {
        MainWindow mExternalWPF;
        public ObjectForScriptingHelper(MainWindow w)
        {
            this.mExternalWPF = w;
        }
        public void OpenGitHub()
        {
            System.Diagnostics.Process.Start("https://github.com/copyliu/bililive_dm"); ;
        }
        public void OpenUWPStore()
        {
            System.Diagnostics.Process.Start("https://www.microsoft.com/store/apps/9PBVHQH1P2BV"); ;
        }

    }
}
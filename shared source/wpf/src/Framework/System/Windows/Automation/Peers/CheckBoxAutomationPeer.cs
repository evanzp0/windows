using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;

using MS.Internal;
using MS.Win32;

namespace System.Windows.Automation.Peers
{

    /// 
    public class CheckBoxAutomationPeer : ToggleButtonAutomationPeer
    {
        ///
        public CheckBoxAutomationPeer(CheckBox owner): base(owner)
        {}
    
        ///
        override protected string GetClassNameCore()
        {
            return "CheckBox";
        }

        ///
        override protected AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.CheckBox;
        }
    }
}


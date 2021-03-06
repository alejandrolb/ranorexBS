﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace RegressionTest_v1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenLedgerModule recording.
    /// </summary>
    [TestModule("bec48827-64c3-45b2-ac7f-d3bcd0993a92", ModuleType.Recording, 1)]
    public partial class OpenLedgerModule : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RegressionTest_v1Repository repository.
        /// </summary>
        public static RegressionTest_v1Repository repo = RegressionTest_v1Repository.Instance;

        static OpenLedgerModule instance = new OpenLedgerModule();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenLedgerModule()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenLedgerModule Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(0));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardFinanceAndOperations.generalLedger' at Center.", repo.DashboardFinanceAndOperations.generalLedgerInfo, new RecordItemIndex(1));
            repo.DashboardFinanceAndOperations.generalLedger.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardFinanceAndOperations.generalJournals' at Center.", repo.DashboardFinanceAndOperations.generalJournalsInfo, new RecordItemIndex(2));
            repo.DashboardFinanceAndOperations.generalJournals.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

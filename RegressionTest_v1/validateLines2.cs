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
    ///The validateLines2 recording.
    /// </summary>
    [TestModule("e6cc56e6-3705-4965-a6b5-1d7847d7fc4d", ModuleType.Recording, 1)]
    public partial class validateLines2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RegressionTest_v1Repository repository.
        /// </summary>
        public static RegressionTest_v1Repository repo = RegressionTest_v1Repository.Instance;

        static validateLines2 instance = new validateLines2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public validateLines2()
        {
            tagMainAccount = "511151000";
            tagCostCenter = "yourtext";
            tagChannel = "";
            tagBrandHouse = "";
            tagBrand = "";
            tagSubBrand = "";
            tagTradinkMarket = "";
            tagFunctionalArea = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static validateLines2 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable tagMainAccount.
        /// </summary>
        [TestVariable("5e6e934a-9e13-4346-83a9-42a213e965bf")]
        public string tagMainAccount
        {
            get { return repo.tagMainAccount; }
            set { repo.tagMainAccount = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagCostCenter.
        /// </summary>
        [TestVariable("3df981f0-21db-46fd-8e9b-e162b8056a5c")]
        public string tagCostCenter
        {
            get { return repo.tagCostCenter; }
            set { repo.tagCostCenter = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagChannel.
        /// </summary>
        [TestVariable("4620574e-041f-42b9-acc6-c1afee8437f1")]
        public string tagChannel
        {
            get { return repo.tagChannel; }
            set { repo.tagChannel = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagBrandHouse.
        /// </summary>
        [TestVariable("3f1a8a86-5cb2-4735-808e-ca50dde1f1a1")]
        public string tagBrandHouse
        {
            get { return repo.tagBrandHouse; }
            set { repo.tagBrandHouse = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagBrand.
        /// </summary>
        [TestVariable("11137edc-c841-4c67-89a6-6fe98842523d")]
        public string tagBrand
        {
            get { return repo.tagBrand; }
            set { repo.tagBrand = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagSubBrand.
        /// </summary>
        [TestVariable("b44b033b-2376-4034-99c4-b007e6455eb4")]
        public string tagSubBrand
        {
            get { return repo.tagSubBrand; }
            set { repo.tagSubBrand = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagTradinkMarket.
        /// </summary>
        [TestVariable("cace9fd9-01be-4fd4-b8d7-f2d9d0d9c67a")]
        public string tagTradinkMarket
        {
            get { return repo.tagTradinkMarket; }
            set { repo.tagTradinkMarket = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagFunctionalArea.
        /// </summary>
        [TestVariable("9206a7bf-339d-421e-85c5-67b2664fbcbc")]
        public string tagFunctionalArea
        {
            get { return repo.tagFunctionalArea; }
            set { repo.tagFunctionalArea = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DimensionFields.ClickMainAccount' at Center.", repo.DimensionFields.ClickMainAccountInfo, new RecordItemIndex(0));
            repo.DimensionFields.ClickMainAccount.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$tagMainAccount) on item 'DimensionTags.tagMainAccount'.", repo.DimensionTags.tagMainAccountInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.DimensionTags.tagMainAccountInfo, "TagValue", tagMainAccount);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(2));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DimensionFields.clickCostCenter' at Center.", repo.DimensionFields.clickCostCenterInfo, new RecordItemIndex(3));
            repo.DimensionFields.clickCostCenter.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$tagCostCenter) on item 'DimensionTags.tagCostCenter'.", repo.DimensionTags.tagCostCenterInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.DimensionTags.tagCostCenterInfo, "TagValue", tagCostCenter);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(5));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DimensionFields.clickChannel' at Center.", repo.DimensionFields.clickChannelInfo, new RecordItemIndex(6));
            repo.DimensionFields.clickChannel.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$tagChannel) on item 'DimensionTags.tagChannel'.", repo.DimensionTags.tagChannelInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.DimensionTags.tagChannelInfo, "TagValue", tagChannel);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}{Tab}{Tab}{Tab}'.", new RecordItemIndex(8));
            Keyboard.Press("{Tab}{Tab}{Tab}{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DimensionFields.clickBrandHouse' at Center.", repo.DimensionFields.clickBrandHouseInfo, new RecordItemIndex(9));
            repo.DimensionFields.clickBrandHouse.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$tagBrandHouse) on item 'DimensionTags.tagBrandHouse'.", repo.DimensionTags.tagBrandHouseInfo, new RecordItemIndex(10));
            Validate.Attribute(repo.DimensionTags.tagBrandHouseInfo, "TagValue", tagBrandHouse);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(11));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DimensionFields.clickBrand' at Center.", repo.DimensionFields.clickBrandInfo, new RecordItemIndex(12));
            repo.DimensionFields.clickBrand.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$tagBrand) on item 'DimensionTags.tagBrand'.", repo.DimensionTags.tagBrandInfo, new RecordItemIndex(13));
            Validate.Attribute(repo.DimensionTags.tagBrandInfo, "TagValue", tagBrand);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(14));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DimensionFields.clickSubBrand' at Center.", repo.DimensionFields.clickSubBrandInfo, new RecordItemIndex(15));
            repo.DimensionFields.clickSubBrand.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$tagSubBrand) on item 'DimensionTags.tagSubBrand'.", repo.DimensionTags.tagSubBrandInfo, new RecordItemIndex(16));
            Validate.Attribute(repo.DimensionTags.tagSubBrandInfo, "TagValue", tagSubBrand);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(17));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DimensionFields.clickTradingMarket' at Center.", repo.DimensionFields.clickTradingMarketInfo, new RecordItemIndex(18));
            repo.DimensionFields.clickTradingMarket.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$tagTradinkMarket) on item 'DimensionTags.tagTradingMarket'.", repo.DimensionTags.tagTradingMarketInfo, new RecordItemIndex(19));
            Validate.Attribute(repo.DimensionTags.tagTradingMarketInfo, "TagValue", tagTradinkMarket);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(20));
            Keyboard.Press("{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DimensionTags.tagFunctionalArea' at Center.", repo.DimensionTags.tagFunctionalAreaInfo, new RecordItemIndex(21));
            repo.DimensionTags.tagFunctionalArea.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue=$tagFunctionalArea) on item 'DimensionTags.tagFunctionalArea'.", repo.DimensionTags.tagFunctionalAreaInfo, new RecordItemIndex(22));
            Validate.Attribute(repo.DimensionTags.tagFunctionalAreaInfo, "TagValue", tagFunctionalArea);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardFinanceAndOperations.LookupButton' at Center.", repo.DashboardFinanceAndOperations.LookupButtonInfo, new RecordItemIndex(23));
            repo.DashboardFinanceAndOperations.LookupButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

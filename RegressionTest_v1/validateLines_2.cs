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
    ///The validateLines_2 recording.
    /// </summary>
    [TestModule("eddf4d9e-8607-4124-95a4-6d8ba60d67d3", ModuleType.Recording, 1)]
    public partial class ValidateLines_2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RegressionTest_v1Repository repository.
        /// </summary>
        public static RegressionTest_v1Repository repo = RegressionTest_v1Repository.Instance;

        static ValidateLines_2 instance = new ValidateLines_2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateLines_2()
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
        public static ValidateLines_2 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable tagMainAccount.
        /// </summary>
        [TestVariable("d27fc76c-1c48-4d94-8242-ac990f9c483e")]
        public string tagMainAccount
        {
            get { return repo.tagMainAccount; }
            set { repo.tagMainAccount = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagCostCenter.
        /// </summary>
        [TestVariable("1907b3d0-0157-417d-90f3-e450c9c1bdac")]
        public string tagCostCenter
        {
            get { return repo.tagCostCenter; }
            set { repo.tagCostCenter = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagChannel.
        /// </summary>
        [TestVariable("8da84c40-4d16-4f20-8a73-26756baf1507")]
        public string tagChannel
        {
            get { return repo.tagChannel; }
            set { repo.tagChannel = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagBrandHouse.
        /// </summary>
        [TestVariable("5dda3c7a-f86d-4c42-ad06-6ca287c53a4f")]
        public string tagBrandHouse
        {
            get { return repo.tagBrandHouse; }
            set { repo.tagBrandHouse = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagBrand.
        /// </summary>
        [TestVariable("b33be771-fafa-4cbd-b756-4a3704519b18")]
        public string tagBrand
        {
            get { return repo.tagBrand; }
            set { repo.tagBrand = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagSubBrand.
        /// </summary>
        [TestVariable("7acdfe2e-df76-453e-843f-98202e7be211")]
        public string tagSubBrand
        {
            get { return repo.tagSubBrand; }
            set { repo.tagSubBrand = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagTradinkMarket.
        /// </summary>
        [TestVariable("1b4119f4-fa8d-4a9a-b2c1-718f09cc4027")]
        public string tagTradinkMarket
        {
            get { return repo.tagTradinkMarket; }
            set { repo.tagTradinkMarket = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tagFunctionalArea.
        /// </summary>
        [TestVariable("3e2d0892-f63f-4dd2-8c47-121991b17161")]
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

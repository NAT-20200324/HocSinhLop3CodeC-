﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCacChucNangKhac
{
    [TestClass()]
    public class SqlServerUnitTestUpGhiChu : SqlDatabaseTestClass
    {

        public SqlServerUnitTestUpGhiChu()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_UpGhiChuTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTestUpGhiChu));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            this.dbo_UpGhiChuTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_UpGhiChuTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            checksumCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            // 
            // dbo_UpGhiChuTestData
            // 
            this.dbo_UpGhiChuTestData.PosttestAction = null;
            this.dbo_UpGhiChuTestData.PretestAction = null;
            this.dbo_UpGhiChuTestData.TestAction = dbo_UpGhiChuTest_TestAction;
            // 
            // dbo_UpGhiChuTest_TestAction
            // 
            dbo_UpGhiChuTest_TestAction.Conditions.Add(checksumCondition1);
            resources.ApplyResources(dbo_UpGhiChuTest_TestAction, "dbo_UpGhiChuTest_TestAction");
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "659269635";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion


        [TestMethod()]
        public void dbo_UpGhiChuTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_UpGhiChuTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        private SqlDatabaseTestActions dbo_UpGhiChuTestData;
    }
}
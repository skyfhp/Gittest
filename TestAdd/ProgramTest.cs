using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAdd
{
    /// <summary>
    ///这是 ProgramTest 的测试类，旨在
    ///包含所有 ProgramTest 单元测试
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {
        private TestContext testContextInstance;
        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///Add 的测试
        ///</summary>
        [TestMethod()]//说明下面是一个测试用例
        public void AddTest()
        {
            Program target = new Program(); // TODO: 初始化为适当的值
            int a = 3; // TODO: 初始化为适当的值 被测函数的输入参数，即测试用例需要输入的值
            int b = 3; // TODO: 初始化为适当的值
            int expected = 6; // TODO: 初始化为适当的值 ，定义了期望值并初始化
            int actual; //定义了实际值，默认
            actual = target.Add(a, b);
            Assert.AreEqual(expected, actual);//断言期望值和实际值相等
            //Assert.Inconclusive("验证此测试方法的正确性。");//默认代码中Assert.Inconclusive 
                                                         //表明这是一个未经验证的单元测试。
                                                      //在实际的程序中可以注释掉。

        }

        /// <summary>
        ///Dec 的测试
        ///</summary>
        [TestMethod()]
        public void DecTest()
        {
            Program target = new Program(); // TODO: 初始化为适当的值
            int a = 3; // TODO: 初始化为适当的值
            int b = 2; // TODO: 初始化为适当的值
            int expected = 1; // TODO: 初始化为适当的值
            int actual;
            actual = target.Dec(a, b);
            Assert.AreEqual(expected, actual);
          //  Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Div 的测试
        ///</summary>
        [TestMethod()]
        public void DivTest()
        {
            Program target = new Program(); // TODO: 初始化为适当的值
            int a = 2; // TODO: 初始化为适当的值
            int b = 2; // TODO: 初始化为适当的值
            int expected = 1; // TODO: 初始化为适当的值
            int actual;
            actual = target.Div(a, b);
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("验证此测试方法的正确性。");
        }

        [TestMethod()]
        public void DivTestzero()
        {
            Program target = new Program(); // TODO: 初始化为适当的值
            int a = 2; // TODO: 初始化为适当的值
            int b = 0; // TODO: 初始化为适当的值
            int expected = 0; // TODO: 初始化为适当的值
            int actual;
            actual = target.Div(a, b);
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}

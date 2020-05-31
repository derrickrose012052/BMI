using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMI;

namespace bmitest
{
    [TestClass]
    public class bmihelper_test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //案例1
            UserInfo user1 = new UserInfo {weight=60,tall=175,sex=true };
            
            string result= bmihelper.calculatebmi(user1);

            Assert.AreEqual("正常??", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //案例2
            UserInfo user2 = new UserInfo { weight = 100, tall = 165, sex = false };

            string result = bmihelper.calculatebmi(user2);
            Assert.AreEqual("過胖嗎", result);
        }
    }
}

﻿using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Summerschool.Controllers;


namespace UnitTestProject_Summer_school
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange

            var controller = new ValuesController();

            //Act
            var result = controller.bmi(1, 1);
            
            

            //Assert
            Assert.AreEqual(1,result);
            
            

        }

        
    }
}

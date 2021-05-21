﻿using ACME.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceValid()
        {
            var source = "PreethiPrakash";
            var expected = "Preethi Prakash";
            var handler = new StringHandler();
            var actual = handler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod] 
        public void InsertSpacesTestWithExisitingSpaces()
        {
            var source = "Sun Flower";
            var expected = "Sun Flower";
            var handler = new StringHandler();
            var actual = handler.InsertSpaces(source);

            Assert.AreEqual(expected, actual);
        }
    }
}
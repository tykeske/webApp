/*
    Author:         Nick Dechativong
    Created Date:   05/01/2020
    Class:          CIS 234A
    Objective:      Unit testing for the utilityService class 
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountManagement.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagement.Services.Tests
{
    [TestClass()]
    public class utilityServiceTests
    {
        // Test for non-original password, 
        // password should be hashed and should not be the same as the original one
        [TestMethod()]
        [Timeout(2000)]  // Milliseconds
        public void passwordHasher_NotEqual()
        {
            // arrange
            string passWord = "TeamApex123$!";
            var util = new utilityService();

            // act
            String passWordHash = util.passwordHasher(passWord);

            // assert
            Assert.AreNotEqual(passWord, passWordHash);
        }

        // Test for non-empty password hash,
        // the password hash should not be empty
        [TestMethod()]
        [Timeout(2000)]  // Milliseconds
        public void passwordHasher_NotEmpty()
        {
            // arrange
            string passWord = "TeamApex123$!";
            var util = new utilityService();

            // act
            String passWordHash = util.passwordHasher(passWord);

            // assert
            Assert.AreNotEqual("", passWordHash);
        }
    }
}
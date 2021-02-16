using System;
using System.Collections.Generic;
using System.Text;
using HackathonNew.Controllers;
using HackathonNew.Interface;
using Xunit;
using HackathonNew.Service;
using Microsoft.AspNetCore.Mvc;
using HackathonNew.Model;

namespace APITest
{
     public class UserTest
    {
        userController _controller;
        IUserService _service;

        public UserTest()
        {
            _service = new UserServiceFacke();
            _controller = new userController(_service);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
           // var okResult = _controller.Get().Result as OkObjectResult;
            var okResult = _controller.Get().Result;
            // Assert
            var items = Assert.IsType<List<User>>(okResult);
            Assert.Equal(3, items.Count);
        }

    }
}

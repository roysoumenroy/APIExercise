using AITExcercise.Models;
using AITExcercise.Service.Interface;
using AjmeraInfoTechExcercise.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AInfotecExerciseTest
{
    public class BookControllerTest
    {
        private readonly BookController _controller;
        private readonly IBookService _service;

        public BookControllerTest(IBookTestService bookTestService)
        {
            _service = (IBookService)bookTestService;
            _controller = new BookController(_service);
        }

        [Fact]
        public async void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = await _controller.GetAllBooks();

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public async Task Get_WhenCalled_ReturnsAllItemsAsync()
        {
            // Act
            var okResult = await _controller.GetAllBooks() as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<GetBookResult>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
    }

}

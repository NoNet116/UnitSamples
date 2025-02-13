﻿using Moq;
using UnitSamples.Task_16_3_2;

using Xunit;

namespace XUnitSamples.Test
{
    public class BookRepositoryTests
    {
        [Fact]
        public void FindAllMustReturnCorrectValue()
        {
            var list = new List<Book>
            {
              new Book(){Title = "Война и мир" },
              new Book() {Title = "Человек-невидимка"},
              new Book(){Title = "Анна Каренина"}};
            Mock<IBookRepository> mock = new Mock<IBookRepository>();

            mock.Setup(v => v.FindAll()).Returns(list);

            Assert.Contains(mock.Object.FindAll(), user => user.Title == "Война и мир");
            Assert.Contains(mock.Object.FindAll(), user => user.Title == "Человек-невидимка");
            Assert.Contains(mock.Object.FindAll(), user => user.Title == "Анна Каренина");
        }
    }
}

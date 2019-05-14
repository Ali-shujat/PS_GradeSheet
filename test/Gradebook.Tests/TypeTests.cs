using System;
using GradeBook;
using Xunit;

namespace Gradebook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42, x);

        }

        private void SetInt(ref int z)
        {
           z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CsharpIsPassByRef()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");
            // ACT
            //Assert
            Assert.Equal("New Name", book1.Name);
        }
        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }
        [Fact]
        public void CsharpIsPassByValue()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");
            // ACT
            //Assert
            Assert.Equal("Book 1", book1.Name);
        }
        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }
        [Fact]
        public void CanSetNameFromRefernce()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            // ACT
            //Assert
            Assert.Equal("New Name", book1.Name);
        }
        private void SetName(Book book1, string name)
        {
            book1.Name = name;
        }
        [Fact]
        public void GetBookReturnDiffObjects()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            // ACT
            //Assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }
        [Fact]
        public void TwoVarRefernceObject()
        {
            // Arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;
            // ACT
            //Assert
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}

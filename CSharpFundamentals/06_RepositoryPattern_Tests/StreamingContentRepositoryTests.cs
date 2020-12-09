﻿using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        [TestInitialize]

        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode and goes on a murderous rampage through the California desert.", "R", 5.8, false, GenreType.Horror);

            _repo.AddContentToList(_content);

        }


        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            // Arrange --> Setting up the playing field
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";
            StreamingContentRepository repository = new StreamingContentRepository();

            // Act --> Get/run the code we want to test
            repository.AddContentToList(content);
            StreamingContent contentFromDirectory = repository.GetContentByTitle("Toy Story");

            // Assert --> Use the assert class to verify the expected outcome
            Assert.IsNotNull(contentFromDirectory);
        }

        // Update
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            // Arrange
            // TestInitialize
            StreamingContent newContent = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode and goes on a murderous rampage through the California desert.", "R", 10, false, GenreType.Horror);

            // Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //Assert
            Assert.IsTrue(updateResult);
        }

        [DataTestMethod]
        [DataRow("Rubber", true)]
        [DataRow("Toy Story", false)]
        public void UpdateExistingContent_ShouldMatchGivenBool(string originalTitle, bool shouldUpdate)
        {
            // Arrange
            // TestInitialize
            StreamingContent newContent = new StreamingContent("Rubber 2", "A car tire comes to life with the power to make people explode and goes on a murderous rampage through the California desert.", "R", 10, false, GenreType.Horror);

            // Act
            bool updateResult = _repo.UpdateExistingContent(originalTitle, newContent);

            //Assert
            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            // Arrange

            // Act
            bool deleteResult = _repo.RemoveContentFromList(_content.Title);

            // Assert
            Assert.IsTrue(deleteResult);

        }

    }
}

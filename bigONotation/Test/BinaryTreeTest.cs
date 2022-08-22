using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bigONotation.Domain;
using bigONotation.Test.Comun;
using FluentAssertions;
using Xunit;

namespace bigONotation.Test
{
    public class BinaryTreeTest
    {
        [Fact]
        public void When_SearchNode_should_return_expected_result()
        {
            // Given
            Node root = DataGenerator.DefaultTree();

            // When
            var result = BinarySearchTree.Search(root, 41);
            // Then
            result.value.Should().Be(41);
        }
        [Fact]
        public void When_Insert_Should_return_when_searched_expected_result()
        {
            // Given
            Node root = DataGenerator.DefaultTree();
            int expected = 84;

            // When
            BinarySearchTree.Insert(root, expected);

            // Then
            root.right.right.right.value.Should().Be(expected);
        }
    }
}
using Assignment_1_CSharp_RPGCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RPG_Char_Tests
{
    public class CharacterTests
    {
        [Fact]
        public void Character_OnCreation_IsLevelOne()
        {
            // Arrange
            Mage testCharacter = new("Pippin");
            int expected = 1;

            // Act
            int actual = testCharacter.level;

            // Assert
            Assert.Equal(expected, actual);

        }
    
       

    }
}
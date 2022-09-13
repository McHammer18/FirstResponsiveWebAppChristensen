using System.Security.Cryptography.X509Certificates;

namespace FirstUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void PassingCaseTest()
        {
            //Arrange
            string name = "Victor";
            int birthYear = 1983;
            int actual;
            int expected = 39;
            UserAgeModel ageModel = new UserAgeModel();
            ageModel.birthYear = birthYear;
            ageModel.Name = name;
            //Act
            actual = ageModel.AgeThisYear();
            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class UnitTest2
    {
        public void PassingCaseTest()
        {
            //Arrange
            string name = "Dave";
            int birthYear = 2015;
            int actual;
            int expected = 7;
            UserAgeModel ageModel = new UserAgeModel();
            ageModel.birthYear = birthYear;
            ageModel.Name = name;
            //Act
            actual = ageModel.AgeThisYear();
            //Assert
            Assert.Equal(expected, actual);
        }
    }

    public class UnitTest3
    {
        public void PassingCaseTest2()
        {
            //Arrange
            string name = "Ferdinand";
            int birthYear = 1923;
            int actual;
            int expected = 99;
            UserAgeModel ageModel = new UserAgeModel();
            ageModel.birthYear = birthYear;
            ageModel.Name = name;
            //Act
            actual = ageModel.AgeThisYear();
            //Assert
            Assert.Equal(expected, actual);
        }
    }

}
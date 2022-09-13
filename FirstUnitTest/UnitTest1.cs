namespace FirstUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void PassingCaseTest()
        {
            //Arrange
            int Year = 2022;
            int birthYear = 1986;

            int expected = 36;
            int actual;

            //Act
            actual = FirstResponsiveWebAppChristensen.Models.UserAgeModel.AgeThisYear();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
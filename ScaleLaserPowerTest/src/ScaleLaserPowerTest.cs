using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ScaleLaserPower
{
    [TestClass]
    public class ScaleLaserPowerTest
    {
        Mock<FileHandler> fileHandlerMock = new Mock<FileHandler>("");
        private ScaleLaserPower sut;

        [TestInitialize]
        public void SetUp()
        {
            sut = new ScaleLaserPower(fileHandlerMock.Object);
        }

        [TestMethod]
        public void ScaleLineTo100_When_Null_Then_Empty()
        {
            var actual = sut.ScaleLineTo100(null);

            Assert.AreEqual("", actual);
        }

        [TestMethod]
        public void ScaleLineTo100_When_Empty_Then_Empty()
        {
            var actual = sut.ScaleLineTo100("");

            Assert.AreEqual("", actual);
        }

        [TestMethod]
        public void ScaleLineTo100_When_OtherLine_Then_OtherLine()
        {
            var actual = sut.ScaleLineTo100("G1 X10");

            Assert.AreEqual("G1 X10", actual);
        }

        [TestMethod]
        public void ScaleLineTo100_When_M306_Then_M306()
        {
            var actual = sut.ScaleLineTo100("M306 X0 Y0");

            Assert.AreEqual("M306 X0 Y0", actual);
        }

        [TestMethod]
        public void ScaleLineTo100_When_M3S0_Then_M3S0()
        {
            var actual = sut.ScaleLineTo100("M3 S0");

            Assert.AreEqual("M03 S0", actual);
        }

        [TestMethod]
        public void ScaleLineTo100_When_M3S128_Then_M3S50()
        {
            var actual = sut.ScaleLineTo100("M3 S128");

            Assert.AreEqual("M03 S50", actual);
        }

        [TestMethod]
        public void ScaleLineTo100_When_M3SpaceS128_Then_M3S100()
        {
            var actual = sut.ScaleLineTo100("M03  S128");

            Assert.AreEqual("M03 S50", actual);
        }

        [TestMethod]
        public void ScaleLineTo100_When_M3S255_Then_M3S100()
        {
            var actual = sut.ScaleLineTo100("M3 S255");

            Assert.AreEqual("M03 S100", actual);
        }

        [TestMethod]
        public void ScaleLineTo100_When_M3_Then_M3FullPower()
        {
            var actual = sut.ScaleLineTo100("M3");

            Assert.AreEqual("M03 S100", actual);
        }

        [TestMethod]
        public void ScaleLineTo100_When_M03_Then_M3FullPower()
        {
            var actual = sut.ScaleLineTo100("M03");

            Assert.AreEqual("M03 S100", actual);
        }

        [TestMethod]
        public void CreateOutputName_When_NasPath_Then_NasPathWithSuffix()
        {
            var actual = sut.CreateOutputName("\\\\NAS\\Documents\\v5_Stars_test_engrave_speed1500_pscale1_0001_Gray_gcode.gcode");

            Assert.AreEqual("\\\\NAS\\Documents\\v5_Stars_test_engrave_speed1500_pscale1_0001_Gray_gcode_scaledTo100.gcode", actual);
        }

        [TestMethod]
        public void CreateOutputName_When_DrivePath_Then_DrivePathWithSuffix()
        {
            var actual = sut.CreateOutputName("C:\\Documents\\v5_Stars_test_engrave_speed1500_pscale1_0001_Gray_gcode.gcode");

            Assert.AreEqual("C:\\Documents\\v5_Stars_test_engrave_speed1500_pscale1_0001_Gray_gcode_scaledTo100.gcode", actual);
        }
    }
}

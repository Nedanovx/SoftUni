namespace Television.Tests
{
    using System;
    using NUnit.Framework;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldCreateTelevion()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            Assert.That(tv, Is.Not.Null);
            Assert.That(tv.Brand, Is.EqualTo("LG"));
            Assert.That(tv.Price, Is.EqualTo(10.99));
            Assert.That(tv.ScreenWidth, Is.EqualTo(23));
            Assert.That(tv.ScreenHeigth, Is.EqualTo(8));
        }
        [Test]
        public void ShouldSwitchOnTelevision()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            string result = tv.SwitchOn();
            Assert.That(tv.IsMuted, Is.False);
            Assert.That(tv.CurrentChannel, Is.EqualTo(0));
            Assert.That(result, Is.EqualTo($"Cahnnel {tv.CurrentChannel} - Volume {tv.Volume} - Sound On"));
        }
        [Test]
        public void ShouldThrowExeptionWhenChannelIsLessThenZero()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            tv.SwitchOn();
            ArgumentException exception = Assert.Throws<ArgumentException>(() => tv.ChangeChannel(-3));
            Assert.That(exception.Message, Is.EqualTo("Invalid key!"));
        }

        [Test]
        public void ShouldChangeChannel()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            tv.SwitchOn();
            int result = tv.ChangeChannel(8);
            Assert.That(tv.CurrentChannel, Is.EqualTo(8));
            Assert.That(result, Is.EqualTo(tv.CurrentChannel));
        }

        [Test]
        public void ShouldChangeVolume()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            tv.SwitchOn();
            string result = tv.VolumeChange("UP", 3);
            Assert.That(tv.Volume, Is.EqualTo(16));
            Assert.That(result, Is.EqualTo($"Volume: {tv.Volume}"));
        }
        [Test]
        public void ShouldSetVolumeToMaxWhenValueIsMoreThen100()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            tv.SwitchOn();
            string result = tv.VolumeChange("UP", 100);
            Assert.That(tv.Volume, Is.EqualTo(100));
            Assert.That(result, Is.EqualTo($"Volume: {tv.Volume}"));
        }
        [Test]
        public void ShouldSetVolumeToMax()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            tv.SwitchOn();
            string result = tv.VolumeChange("UP", 87);
            Assert.That(tv.Volume, Is.EqualTo(100));
            Assert.That(result, Is.EqualTo($"Volume: {tv.Volume}"));
        }
        [Test]
        public void ShouldChangeVolumeDown()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            tv.SwitchOn();
            string result = tv.VolumeChange("DOWN", 6);
            Assert.That(tv.Volume, Is.EqualTo(7));
            Assert.That(result, Is.EqualTo($"Volume: {tv.Volume}"));
        }
        [Test]
        public void ShouldChangeVolumeDownWithExactValue()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            tv.SwitchOn();
            string result = tv.VolumeChange("DOWN", 13);
            Assert.That(tv.Volume, Is.EqualTo(0));
            Assert.That(result, Is.EqualTo($"Volume: {tv.Volume}"));
        }
        [Test]
        public void ShouldSetVolumeToZeroWhenValueIsMore()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            tv.SwitchOn();
            string result = tv.VolumeChange("DOWN", 625);
            Assert.That(tv.Volume, Is.EqualTo(0));
            Assert.That(result, Is.EqualTo($"Volume: {tv.Volume}"));
        }
        [Test]
        public void ShouldMuteTv()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            tv.SwitchOn();
            bool result = tv.MuteDevice();
            Assert.That(tv.IsMuted, Is.True);
            Assert.That(result, Is.True);
        }
        [Test]
        public void ShouldUnmuteTv()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            tv.SwitchOn();
            tv.MuteDevice();
            bool result = tv.MuteDevice();
            Assert.That(tv.IsMuted, Is.False);
            Assert.That(result, Is.False);
        }
        [Test]
        public void ReturnToString()
        {
            TelevisionDevice tv = new TelevisionDevice("LG", 10.99, 23, 8);
            string result = tv.ToString();
            Assert.That(result, Is.EqualTo($"TV Device: {tv.Brand}, Screen Resolution: {tv.ScreenWidth}x{tv.ScreenHeigth}, Price {tv.Price}$"));
        }
    }
}
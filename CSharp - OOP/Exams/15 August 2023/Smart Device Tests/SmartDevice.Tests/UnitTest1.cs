namespace SmartDevice.Tests
{
    using NUnit.Framework;
    using System;
    using System.Text;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeviceConstructorShouldCreateDeviceCorrectly()
        {
            Device device = new Device(150);
            Assert.That(device.AvailableMemory, Is.EqualTo(150));
            Assert.That(device.MemoryCapacity, Is.EqualTo(150));
            Assert.That(device.Photos, Is.EqualTo(0));
            Assert.That(device.Applications.Count, Is.EqualTo(0));
        }

        [Test]
        public void TakePhotoWithEnoughMemoryShouldReturnTrue()
        {
            Device device = new Device(150);
            Assert.IsTrue(device.TakePhoto(40));
            Assert.That(device.AvailableMemory, Is.EqualTo(110));
            Assert.That(device.Photos, Is.EqualTo(1));
        }
        [Test]
        public void TakePhotoWithOutEnoughMemoryShouldReturnFalse()
        {
            Device device = new Device(150);
            device.TakePhoto(40);
            Assert.IsFalse(device.TakePhoto(200));
            Assert.That(device.AvailableMemory, Is.EqualTo(110));
            Assert.That(device.Photos, Is.EqualTo(1));
        }
        [Test]
        public void InstalAppWithEnoughMemoryShouldWorkCorretcly()
        {
            Device device = new Device(150);
            Assert.That(device.InstallApp("Netflix", 50), Is.EqualTo($"Netflix is installed successfully. Run application?"));
            Assert.That(device.AvailableMemory, Is.EqualTo(100));
            Assert.That(device.Applications.Count, Is.EqualTo(1));
            Assert.IsTrue(device.Applications.Contains("Netflix"));
        }

        [Test]
        public void InstalAppWithOutEnoughMemoryShouldReturnInvalidOperationException()
        {
            Device device = new Device(150);
            var ex = Assert.Throws<InvalidOperationException>(() => device.InstallApp("Netflix", 200));
            Assert.That(ex.Message, Is.EqualTo("Not enough available memory to install the app."));
            Assert.That(device.AvailableMemory, Is.EqualTo(150));
            Assert.That(device.Applications.Count, Is.EqualTo (0));
        }
        [Test]
        public void FormatShouldWorkCorretcly()
        {
            Device device = new Device(150);
            device.TakePhoto(2);
            device.TakePhoto(15);
            device.InstallApp("Netflix", 50);
            device.FormatDevice();
            Assert.That(device.AvailableMemory, Is.EqualTo(150));
            Assert.That(device.MemoryCapacity, Is.EqualTo(150));
            Assert.That(device.Photos, Is.EqualTo(0));
            Assert.That(device.Applications.Count, Is.EqualTo(0));
        }

        [Test]
        public void GetDeviceStatusShouldWorkCorretcly()
        {
            Device device = new Device(150);
            device.TakePhoto(2);
            device.TakePhoto(15);
            device.InstallApp("Netflix", 50);
            device.InstallApp("Snake", 10);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Memory Capacity: {device.MemoryCapacity} MB, Available Memory: {device.AvailableMemory} MB");
            sb.AppendLine(($"Photos Count: {device.Photos}"));
            sb.AppendLine($"Applications Installed: {string.Join(", ", device.Applications)}");
            Assert.That(sb.ToString().TrimEnd(), Is.EqualTo(device.GetDeviceStatus().ToString()));
        }
    }
}
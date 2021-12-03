using Phoneshop.Business;
using Phoneshop.Domain.Objects;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using System;
using Xunit;
using Xunit.Sdk;

namespace Phoneshop.Tests.ImportServiceTests
{
    public class ConvertXmlToList
    {
        private readonly ImportService importService;

        public ConvertXmlToList()
        {
            importService = new ImportService();
        }

        [Fact]
        public void Should()
{
            var XmlString = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<!--Phone list--><Phones><Phone><Brand>Apple</Brand><Type>iPhone 12 Pro 128GB Zwart</Type><Price>1028</Price>" +
                "<Description>The iPhone 12 Pro is part of the Fall 2020 iPhone 12 series. It comes with the impressive specs we've come to expect from Apple, including a gorgeous 6.1-inch screen, excellent camera and blazing-fast hardware. " +
                "It also looks great with its matte and angular finish. With support for 5G Internet, you'll have access to the fastest network and be ready for the future. All in all, Apple has delivered another great device! " +
                "Super powerful processor " +
                "To drive everything, the iPhone 12 Pro is equipped with the A14 processor, which was developed by Apple itself.This makes it work optimally with the software, and it can run the heaviest apps effortlessly.Multitasking is also not an issue. " +
                "Three cameras on the back " +
                "Like its predecessor, this smartphone is a true winner when it comes to photos.It has three lenses that all have their own function, like zooming in or capturing a wider angle.Thanks to the night mode, you can also shoot beautiful pictures in low light. " +
                "Another great feature is portrait mode, which lets you take professional-looking photos.Animojis lets you create a fun digital avatar to send to your friends.Face ID is an accurate face-recognition feature that lets only you unlock your phone! " +
                "LiDAR scanner " +
                "The iPhone 12 Pro features a LiDAR scanner.This is a depth sensor that measures how long it takes for light to be reflected from an object, in order to measure the distance to that object.This technology was previously found in the iPad Pro and is used in Artificial Reality. " +
                "Premium design " +
                "The design of the iPhone 12 Pro is a striking change from the iPhone 11 Pro.It has a more angular design, something familiar from older iPhones like the iPhone 5.The back has a cool matte finish, giving it a stylish look. " +
                "5G support " +
                "The 12-series iPhones are the first iPhones that can connect to the new 5G network.This is becoming increasingly available in the Netherlands, so you have access to this super fast internet! So stream your favourite films and series even faster. " +
                "Magnetic accessories " +
                "The iPhone 12 Pro has a new feature called MagSafe.This was the brand name of magnetic chargers for MacBooks and now it covers magnetic accessories.This means you can quickly and easily attach MagSafe accessories to your iPhone, such as wireless chargers, cases, and card holders. " +
                "Box Contents " +
                "A smartphone often comes with a charging adapter and earbuds for listening to music.Apple has decided not to do that anymore, with the idea that it saves waste and packaging.However, this does mean that you will have to buy these separately if you don't already have them. You do get a Lightning to USB-C cable, though.</Description><Stock>17</Stock></Phone>";
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace HKX2.Tests
{
    [TestClass]
    public class CompareTests
    {
        [TestMethod]
        public void XmlToXmlDeepCompare()
        {
            var hkxDir = new DirectoryInfo("./xml");
            foreach (var item in Directory.EnumerateFiles(hkxDir.ToString(), "*.xml", SearchOption.AllDirectories))
            {
                Trace.WriteLine(item);
                var root = Util.ReadXml(item, HKXHeader.SkyrimSE());

                MemoryStream ms = new();
                Util.WriteXml(root, HKXHeader.SkyrimSE(), ms);
                ms.Position = 0;

                var root2 = Util.ReadXml(ms, HKXHeader.SkyrimSE());

                Assert.IsTrue(root.Equals(root2));
            }

        }

        [TestMethod]
        public void HhkToHkxDeepCompare()
        {
            var hkxDir = new DirectoryInfo("./hkx");
            foreach (var item in Directory.EnumerateFiles(hkxDir.ToString(), "*.hkx", SearchOption.AllDirectories))
            {
                Trace.WriteLine(item);
                var root = Util.ReadHKX(item);

                MemoryStream ms = new();
                Util.WriteHKX(root, HKXHeader.SkyrimSE(), ms);
                ms.Position = 0;

                var root2 = Util.ReadHKX(ms);

                Assert.IsTrue(root.Equals(root2));
            }

        }

        [TestMethod]
        public void HhkToXmlToHkxDeepCompare()
        {
            DirectoryInfo hkxDir = new DirectoryInfo("./hkx");
            foreach (var item in Directory.EnumerateFiles(hkxDir.ToString(), "*.hkx", SearchOption.AllDirectories))
            {
                Trace.WriteLine(item);
                var root = (hkRootLevelContainer)Util.ReadHKX(item);

                MemoryStream ms = new();
                Util.WriteXml(root, HKXHeader.SkyrimSE(), ms);
                ms.Position = 0;

                var root2 = (hkRootLevelContainer)Util.ReadXml(ms, HKXHeader.SkyrimSE());

                Assert.IsTrue(root.Equals(root2));
            }
        }

        [TestMethod]
        public void XmlToHkxToXmlDeepCompare()
        {
            var xmlDir = new DirectoryInfo("./xml");
            foreach (var item in Directory.EnumerateFiles(xmlDir.ToString(), "*.xml", SearchOption.AllDirectories))
            {
                Trace.WriteLine(item);
                var root = (hkRootLevelContainer)Util.ReadXml(item, HKXHeader.SkyrimSE());

                MemoryStream ms = new();
                Util.WriteHKX(root, HKXHeader.SkyrimSE(), ms);
                ms.Position = 0;

                var root2 = (hkRootLevelContainer)Util.ReadHKX(ms);

                Assert.IsTrue(root.Equals(root2));
            }
        }
    }
}
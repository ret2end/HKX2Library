using Microsoft.VisualStudio.TestTools.UnitTesting;
using HKX2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KellermanSoftware.CompareNetObjects;
using System.Numerics;
using System.Reflection;
using System.Diagnostics;
using KellermanSoftware.CompareNetObjects.TypeComparers;

namespace HKX2.Tests
{
    [TestClass]
    public class CompareTests
    {
        [TestMethod]
        public void XmlToXmlDeepCompare()
        {
            CompareLogic compareLogic = new CompareLogic();
            compareLogic.Config.SkipInvalidIndexers = true;
            compareLogic.Config.IgnoreUnknownObjectTypes = true;
            compareLogic.Config.MaxDifferences = 1;
            compareLogic.Config.CompareFields = false;
            compareLogic.Config.CompareReadOnly = false;
            compareLogic.Config.CompareStaticFields = false;
            compareLogic.Config.CompareStaticProperties = false;
            compareLogic.Config.ComparePrivateFields = false;
            compareLogic.Config.ComparePrivateProperties = false;
            compareLogic.Config.TypesToIgnore.Add(typeof(object));

            DirectoryInfo hkxDir = new DirectoryInfo("./xml");
            foreach (var item in Directory.EnumerateFiles(hkxDir.ToString(), "*.xml", SearchOption.AllDirectories))
            {
                Trace.WriteLine(item);
                var root = Util.ReadXml(item, HKXHeader.SkyrimSE());

                MemoryStream ms = new();
                Util.WriteXml(root, HKXHeader.SkyrimSE(), ms);
                ms.Position = 0;

                var root2 = Util.ReadXml(ms, HKXHeader.SkyrimSE());

                var result = compareLogic.Compare(root, root2);
                if (!result.AreEqual)
                    Trace.WriteLine($"{item}:{result.DifferencesString}");
                Assert.IsTrue(result.AreEqual);
            }

        }

        [TestMethod]
        public void HhkToHkxDeepCompare()
        {
            CompareLogic compareLogic = new CompareLogic();
            compareLogic.Config.SkipInvalidIndexers = true;
            compareLogic.Config.IgnoreUnknownObjectTypes = true;
            compareLogic.Config.MaxDifferences = 1;
            compareLogic.Config.CompareFields = false;
            compareLogic.Config.CompareReadOnly = false;
            compareLogic.Config.CompareStaticFields = false;
            compareLogic.Config.CompareStaticProperties = false;
            compareLogic.Config.ComparePrivateFields = false;
            compareLogic.Config.ComparePrivateProperties = false;
            compareLogic.Config.TypesToIgnore.Add(typeof(object));

            compareLogic.Config.AutoClearCache = false;

            DirectoryInfo hkxDir = new DirectoryInfo("./hkx");
            foreach (var item in Directory.EnumerateFiles(hkxDir.ToString(), "*.hkx", SearchOption.AllDirectories))
            {
                Trace.WriteLine(item);
                var root = Util.ReadHKX(item);

                MemoryStream ms = new();
                Util.WriteHKX(root, HKXHeader.SkyrimSE(), ms);
                ms.Position = 0;

                var root2 = Util.ReadHKX(ms);

                var result = compareLogic.Compare(root, root2);
                if (!result.AreEqual)
                    Trace.WriteLine($"{item}:{result.DifferencesString}");
                Assert.IsTrue(result.AreEqual);
            }

        }

        [TestMethod]
        public void HhkToXmlToHkxDeepCompare()
        {
            CompareLogic compareLogic = new CompareLogic();
            compareLogic.Config.SkipInvalidIndexers = true;
            compareLogic.Config.IgnoreUnknownObjectTypes = true;
            compareLogic.Config.MaxDifferences = 1;
            compareLogic.Config.CompareFields = false;
            compareLogic.Config.CompareReadOnly = false;
            compareLogic.Config.CompareStaticFields = false;
            compareLogic.Config.CompareStaticProperties = false;
            compareLogic.Config.ComparePrivateFields = false;
            compareLogic.Config.ComparePrivateProperties = false;
            compareLogic.Config.TreatStringEmptyAndNullTheSame = true;
            compareLogic.Config.TypesToIgnore.Add(typeof(object));

            compareLogic.Config.CustomComparers.Add(new CustomComparer<float, float>((f1, f2) => (Math.Abs(f1 - f2) <= 0.000001)));
            compareLogic.Config.CustomComparers.Add(new CustomComparer<string, string>((s1, s2) => (s1.Trim() == s2.Trim())));

            // skip unknown bit issues
            compareLogic.Config.IgnoreProperty<hkbRoleAttribute>(x => x.m_flags);

            compareLogic.Config.AutoClearCache = false;

            DirectoryInfo hkxDir = new DirectoryInfo("./hkx");
            foreach (var item in Directory.EnumerateFiles(hkxDir.ToString(), "*.hkx", SearchOption.AllDirectories))
            {
                Trace.WriteLine(item);
                var root = Util.ReadHKX(item);

                MemoryStream ms = new();
                Util.WriteXml(root, HKXHeader.SkyrimSE(), ms);
                ms.Position = 0;

                var root2 = Util.ReadXml(ms, HKXHeader.SkyrimSE());

                var result = compareLogic.Compare(root, root2);
                if (!result.AreEqual)
                    Trace.WriteLine($"{item}:{result.DifferencesString}");
                Assert.IsTrue(result.AreEqual);
            }

        }
    }
}
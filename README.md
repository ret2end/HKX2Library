# HKX2Library

A standalone customized version of Katalash's HKX2 library for Havok packfile deserialization and serialization used in DSMapStudio.

### Differences

- Supports Breath of the Wild packfiles used on Wii U and Switch (might support other games that use the same classes).
- Supports conversion of packfiles between those two platforms.
- Padding improvements which allow for perfectly matching Navmesh (.hknm2) files.

### Known issues

- Ragdoll files (.hkrg) differ from vanilla files because of different fixup ordering. This issue shouldn't affect functionality.

### Usage

`git submodule add https://gitlab.com/HKX2/HKX2Library <your-repo-dir>/some/path/HKX2Library`

Then reference it in your solution and project.

```C#
using HKX2;

namespace PlatformConverter
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            string inFile = args[0];
            string outFile = args[1];
            string outPlatform = args[2];

            HKXHeader header = outPlatform switch
            {
                "wiiu" => HKXHeader.BotwWiiu(),
                "nx" => HKXHeader.BotwNx(),
                _ => throw new ArgumentException("Invalid platform!")
            };

            using (FileStream rs = File.OpenRead(inFile))
            {
                var br = new BinaryReaderEx(rs);
                var des = new PackFileDeserializer();

                var root = (hkRootLevelContainer) des.Deserialize(br);

                using (FileStream ws = File.Create(outFile))
                {
                    var bw = new BinaryWriterEx(ws);
                    var s = new PackFileSerializer();

                    s.Serialize(root, bw, header);
                }
            }
        }
    }
}
```

### Technical details

- `./HKX2/Autogen/` contains Havok classes generated from Breath of the Wild [reflection information dump](https://raw.githubusercontent.com/zephenryus/havok-reflection/master/reflection_data.json).
- `./HKX2/Manual/` also contains generated classes, but edited to the best of my patience and capabilities to match both Wii U and Switch files.
- Differences in class structure between games and platforms is dependent on Havok version used and platform's header information (pointer size, endian, padding option).

### Credits

- [katalash](https://github.com/katalash) - The original HKX2 library included in [DSMapStudio](https://github.com/katalash/DSMapStudio)
- [JKAnderson](https://github.com/JKAnderson) - BinaryReaderEx and BinaryWriterEx included in [SoulsFormats](https://github.com/JKAnderson/SoulsFormats)

# HKX2Library

A standalone customized version of Katalash's HKX2 library for Havok packfile deserialization and serialization used in DSMapStudio.

This fork modified classes for Skyrim SE hkx file.

### Differences

- **Serialize** and **Deserialize** .hkx file. (include **behaviors**, **skeleton** and **aniamtions**)
- Export to **XML**.
- ~XML to HKX~ use [figment/hkxcmd](https://github.com/figment/hkxcmd), [nexus](https://www.nexusmods.com/skyrim/mods/1797)
- ~Supports Breath of the Wild packfiles used on Wii U and Switch (might support other games that use the same classes).~ (Skyrim SE only)
- ~Supports conversion of packfiles between those two platforms.~ (SE only)

### Known issues

- ~Ragdoll files (.hkrg) differ from vanilla files because of different fixup ordering. This issue shouldn't affect functionality.~
- can't deserialize some old FNIS generated hkx files due to malformed(?) `__classname__` or virtualFixup section or wrong assigned member (`hkbBlendingTransitionEffec` assign to `hkbStateMachineTransitionInfoArray`)

### Usage

`git submodule add https://github.com/ret2end/HKX2Library <your-repo-dir>/some/path/HKX2Library`

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

            HKXHeader header = HKXHeader.SkyrimSE();

            using (FileStream rs = File.OpenRead(inFile))
            {
                var br = new BinaryReaderEx(rs);
                var des = new PackFileDeserializer();

                var root = (hkRootLevelContainer) des.Deserialize(br);

                using (FileStream ws = File.Create(outFile))
                {   
                    // to hkx
                    var bw = new BinaryWriterEx(ws);
                    var s = new PackFileSerializer();

                    s.Serialize(root, bw, header);
                    
                    // or to xml
                    var xs = new XmlSerializer();
                    xs.Serialize(root, header, ws);
                }
            }
        }
    }
}
```

### Technical details

- `./HKX2/Autogen/` contains Havok classes generated from dumped skyrim classes by SKSE plugin.
- `./HKX2/Manual/` also contains generated classes with small adjustment.
- ~Differences in class structure between games and platforms is dependent on Havok version used and platform's header information (pointer size, endian, padding option).~ no

### TODO

- Unit test
- xml to 64bit hkx?
- export animation?

### Credits

- [katalash](https://github.com/katalash) - The original HKX2 library included in [DSMapStudio](https://github.com/katalash/DSMapStudio)
- [JKAnderson](https://github.com/JKAnderson) - BinaryReaderEx and BinaryWriterEx included in [SoulsFormats](https://github.com/JKAnderson/SoulsFormats)
- [krenyy](https://gitlab.com/HKX2/HKX2Library) - HKX2 library by krenyy
- [Dexesttp](https://github.com/Dexesttp/hkxpack/tree/main/doc/hkx%20findings) with hkx research documentary
- SkyrimSE RE and SkyrimGuild community with valuable skse plugin, hkx, animation, behavior information

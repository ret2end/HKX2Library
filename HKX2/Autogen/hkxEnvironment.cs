using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxEnvironment Signatire: 0x41e1aa5 size: 32 flags: FLAGS_NONE

    // m_variables m_class: hkxEnvironmentVariable Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkxEnvironment : hkReferencedObject
    {

        public List<hkxEnvironmentVariable> m_variables;

        public override uint Signature => 0x41e1aa5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_variables = des.ReadClassArray<hkxEnvironmentVariable>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkxEnvironmentVariable>(bw, m_variables);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}


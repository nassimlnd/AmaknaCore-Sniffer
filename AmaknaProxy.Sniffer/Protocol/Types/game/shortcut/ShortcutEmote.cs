

// Generated on 04/03/2020 21:59:12
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.IO;

namespace AmaknaProxy.API.Protocol.Types
{
    public class ShortcutEmote : Shortcut
    {
        public const short Id = 389;
        public override short TypeId
        {
            get { return Id; }
        }
        
        public byte emoteId;
        
        public ShortcutEmote()
        {
        }
        
        public ShortcutEmote(sbyte slot, byte emoteId)
         : base(slot)
        {
            this.emoteId = emoteId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(emoteId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            emoteId = reader.ReadByte();
        }
        
    }
    
}
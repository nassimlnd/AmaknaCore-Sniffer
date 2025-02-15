

// Generated on 04/03/2020 21:58:57
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class PartyAcceptInvitationMessage : AbstractPartyMessage
    {
        public const uint Id = 5580;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public PartyAcceptInvitationMessage()
        {
        }
        
        public PartyAcceptInvitationMessage(uint partyId)
         : base(partyId)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}
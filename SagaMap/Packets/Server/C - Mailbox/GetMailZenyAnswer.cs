using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;
using SagaDB.Mail;

namespace SagaMap.Packets.Server
{
    public class GetMailZenyAnswer : Packet
    {
        public enum Results
        {
            OK,
            FAILED,            
        }

        public GetMailZenyAnswer()
        {
            this.data = new byte[5];
            this.ID = 0x0C05;
            this.offset = 4;
        }

        public void SetResult(Results r)
        {
            this.PutByte((byte)r, 4);
        }
    }
}

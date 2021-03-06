using System;
using System.Collections.Generic;

using SagaMap;
 
using SagaDB.Actors;
using SagaDB.Items;

namespace Hod02
{
    public class Dunstan : Npc
    {
        public override void OnInit()
        {
            MapName = "Hod_f02";
            Type = 1066;
            Name = "Kundi Dunstan";
            StartX = -47181F;
            StartY = -31652F;
            StartZ = 5045;
            Startyaw = 19608;
            SetScript(3);
            AddButton(Functions.EverydayConversation, new func(OnButton));
        }

        public void OnButton(ActorPC pc)
        {
            NPCChat(pc, 823);
        }

    }
}
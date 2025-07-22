using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_427 : SimTemplate //* 雷霆绽放 Lightning Bloom
	{
		//Gain 2 Mana Crystals this turn only.<b>Overload:</b> (2)
		//仅在本回合中，获得两个法力水晶。<b>过载：</b>（2）
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.mana+=2;
				p.ueberladung += 2;
            }
        }
	}
}

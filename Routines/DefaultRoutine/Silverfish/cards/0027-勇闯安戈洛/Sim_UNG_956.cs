using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_956 : SimTemplate //* 灵魂回响 Spirit Echo
//Give your minions "<b>Deathrattle:</b> Return _this to your hand."
//使你的所有随从获得“<b>亡语：</b>将该随从移回你的手牌”。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                m.returnToHand++;
            }
		}
	}
}
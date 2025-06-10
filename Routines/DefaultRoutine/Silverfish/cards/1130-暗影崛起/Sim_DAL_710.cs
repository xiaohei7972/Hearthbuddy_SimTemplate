using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_710 : SimTemplate //* 鱼人之魂 Soul of the Murloc
//Give your minions "<b>Deathrattle:</b> Summon a 1/1 Murloc."
//使你的所有随从获得“<b>亡语：</b>召唤一个1/1的鱼人。” 
	{



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                m.souloftheforest++;
            }
		}

	}
}
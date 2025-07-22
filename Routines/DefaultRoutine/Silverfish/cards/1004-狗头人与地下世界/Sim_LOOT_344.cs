using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_344 : SimTemplate //* 原始护身符 Primal Talismans
//Give your minions "<b>Deathrattle:</b> Summon a random basic Totem."
//使你的所有随从获得“<b>亡语：</b>随机召唤一个基础图腾。” 
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
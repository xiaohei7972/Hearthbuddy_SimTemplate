using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_526 : SimTemplate //* 巴罗夫领主 Lord Barov
	{
		//[x]<b>Battlecry:</b> Set the Healthof all other minions to 1.<b>Deathrattle:</b> Deal 1 damageto all minions.
		//<b>战吼：</b>将所有其他随从的生命值变为1。<b>亡语：</b>对所有随从造成1点伤害。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            foreach (Minion m in p.ownMinions)
            {
                p.minionSetLifetoX(m, 1);
            }
            foreach (Minion m in p.enemyMinions)
            {
                p.minionSetLifetoX(m, 1);
            }
        }
		public override void onDeathrattle(Playfield p, Minion m)
        {
            p.allMinionsGetDamage(1);
        }	
	}
}

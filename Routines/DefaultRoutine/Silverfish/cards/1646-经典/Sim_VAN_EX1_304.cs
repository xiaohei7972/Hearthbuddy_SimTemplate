using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_304 : SimTemplate //* 虚空恐魔 Void Terror
	{
		//[x]<b>Battlecry:</b> Destroy bothadjacent minions and gain their Attack and Health.
		//<b>战吼：</b>消灭该随从两侧的随从，并获得他们的攻击力和生命值。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;

            int angr = 0;
            int hp = 0;
            foreach (Minion m in temp)
            {
                if (m.zonepos == own.zonepos - 1 || m.zonepos == own.zonepos + 1)
                {
                    angr += m.Angr;
                    hp += m.Hp;
                    p.minionGetDestroyed(m);
                }
            }
            p.minionGetBuffed(own, angr, hp);
		}
	}
}
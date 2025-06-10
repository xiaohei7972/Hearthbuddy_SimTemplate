using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_093 : SimTemplate //* 阿古斯防御者 Defender of Argus
	{
		//<b>Battlecry:</b> Give adjacent minions +1/+1 and <b>Taunt</b>.
		//<b>战吼：</b>使相邻的随从获得+1/+1和<b>嘲讽</b>。

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.zonepos == own.zonepos - 1 || m.zonepos == own.zonepos + 1)
                {
                    p.minionGetBuffed(m, 1, 1);
                    if (!m.taunt)
                    {
                        m.taunt = true;
                        if (m.own) p.anzOwnTaunt++;
                        else p.anzEnemyTaunt++;
                    }
                }
            }
		}
	}
}
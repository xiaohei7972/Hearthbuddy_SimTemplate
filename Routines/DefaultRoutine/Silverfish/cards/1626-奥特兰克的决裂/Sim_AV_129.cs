using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_129 : SimTemplate //* 血卫士 bloodguard
	{
        //每当该随从受到伤害时，使你的随从获得+1攻击力。
        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
                for (int i = 0; i < tmp; i++)
                {
                    foreach (Minion mn in temp)
                    {
                        p.minionGetBuffed(mn, 1, 0);
                    }
                }
            }
        }

    }
}

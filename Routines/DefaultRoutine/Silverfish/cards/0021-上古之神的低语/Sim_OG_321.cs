using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_321 : SimTemplate //* 疯狂的信徒 Crazed Worshipper
//<b>Taunt.</b> Whenever this minion takes damage, give your C'Thun +1/+1 <i>(wherever it is).</i>
//<b>嘲讽</b>。每当该随从受到伤害，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i> 
	{
		

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                p.cthunGetBuffed(tmp, tmp, 0);
            }
        }
	}
}
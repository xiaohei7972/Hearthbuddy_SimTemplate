using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_900 : SimTemplate //* 灵魂歌者安布拉 Spiritsinger Umbra
//After you summon a minion, trigger its <b>Deathrattle</b> effect.
//在你召唤一个随从后，触发其<b>亡语</b>。 
	{
		

        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            if (m.entitiyID != summonedMinion.entitiyID && m.own == summonedMinion.own)
            {
                p.doDeathrattles(new List<Minion>() { summonedMinion });
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_218: SimTemplate //* 咆哮魔 Howlfiend
//Whenever this minion takes damage, discard a_random card.
//每当该随从受到伤害，随机弃掉一张牌。 
    {
        

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0) p.discardCards(m.anzGotDmg, m.own);
        }
    }
}

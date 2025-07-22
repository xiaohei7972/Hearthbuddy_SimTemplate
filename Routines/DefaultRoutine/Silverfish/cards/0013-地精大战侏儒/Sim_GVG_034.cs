using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_034 : SimTemplate //* 机械野兽 Mech-Bear-Cat
//Whenever this minion takes damage, add a <b>Spare Part</b> card to your hand.
//每当该随从受到伤害，将一张<b>零件</b>牌置入你的手牌。 
    {
        

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                for (int i = 0; i < tmp; i++)
                {
                    p.drawACard(CardDB.cardNameEN.armorplating, m.own, true);
                }
            }
        }
    }
}
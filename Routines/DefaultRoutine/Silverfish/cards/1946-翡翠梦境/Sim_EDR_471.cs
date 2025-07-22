using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 战士 费用：10 攻击力：1 生命值：30
    //Tortolla
    //托尔托拉
    //[x]<b>Taunt</b>, <b>Elusive</b>After this takes damage,gain 1 Armor and givethis minion +1 Attack.
    //<b>嘲讽</b>。<b>扰魔</b>在本随从受到伤害后，获得1点护甲值并使本随从获得+1攻击力。
    class Sim_EDR_471 : SimTemplate
    {

        public override void onMinionGotDmgTrigger(Playfield p, Minion m, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            if (m.anzGotDmg > 0)
            {
                int tmp = m.anzGotDmg;
                m.anzGotDmg = 0;
                for (int i = 0; i < tmp; i++)
                {
                    p.minionGetArmor(p.ownHero, 1);
                }
            }
        }
    }
}

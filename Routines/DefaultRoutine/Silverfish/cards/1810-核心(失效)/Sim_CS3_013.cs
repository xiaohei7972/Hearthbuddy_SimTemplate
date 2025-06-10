using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS3_013 : SimTemplate //* 暗影之灵 Shadowed Spirit
	{
        //[x]<b>Deathrattle:</b> Deal 3damage to theenemy hero.
        //<b>亡语：</b>对敌方英雄造成3点伤害。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.minionGetDamageOrHeal(p.enemyHero, 3);
        }

    }
}

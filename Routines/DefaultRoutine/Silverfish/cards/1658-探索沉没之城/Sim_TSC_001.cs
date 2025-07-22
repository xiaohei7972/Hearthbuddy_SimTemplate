using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：0 生命值：2
	//Naval Mine
	//海军水雷
	//[x]<b>Deathrattle:</b> Deal 4 damageto the enemy hero.
	//<b>亡语：</b>对敌方英雄造成4点伤害。
	class Sim_TSC_001 : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.minionGetDamageOrHeal(m.own ? p.enemyHero : p.ownHero, 4);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Amulet of Energy
	//能量护符
	//Restore #12 Healthto your hero.<i>(Then take $6 damage!)</i>
	//为你的英雄恢复#12点生命值。<i>（然后受到$6点伤害！）</i>
	class Sim_VAC_959t08 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 为你的英雄恢复12点生命值
            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -12);

            // 然后对你的英雄造成6点伤害
            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, 6);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Amulet of Energy
	//能量护符
	//Restore #12 Healthto your hero.
	//为你的英雄恢复#12点生命值。
	class Sim_VAC_959t08t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 为你的英雄恢复12点生命值
            p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -12);
        }


    }
}

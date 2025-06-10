using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：4 攻击力：4 生命值：4
	//Glowstone Gyreworm
	//亮石旋岩虫
	//<b>Forged</b>, <b>Lifesteal</b><b>Battlecry:</b> Deal 5 damage.
	//<b>已锻造</b><b>吸血</b>。<b>战吼：</b>造成5点伤害。
	class Sim_DEEP_024t : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion ownMinion, Minion target, int choice)
        {
            // 造成5点伤害
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, 5);
                p.minionGetDamageOrHeal(p.ownHero, -5); // 吸血效果，恢复等同于伤害的生命值
            }
        }

    }
}

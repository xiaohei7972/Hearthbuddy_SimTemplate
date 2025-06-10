using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：4 攻击力：4 生命值：4
	//Glowstone Gyreworm
	//亮石旋岩虫
	//[x]<b><b>Lifesteal</b>Quickdraw:</b> Deal 5 damage.<b>Forge:</b> Change <b>Quickdraw</b>to <b>Battlecry</b>.
	//<b><b>吸血</b>。快枪：</b>造成5点伤害。<b>锻造：</b>将<b>快枪</b>变为<b>战吼</b>。
	class Sim_DEEP_024 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
        {
			if (hc.card.Quickdraw) 
			{
                p.minionGetDamageOrHeal(target, 5);

                // 吸血效果，恢复等量生命值
                p.minionGetDamageOrHeal(p.ownHero, -5);
            }
        }
    }
}

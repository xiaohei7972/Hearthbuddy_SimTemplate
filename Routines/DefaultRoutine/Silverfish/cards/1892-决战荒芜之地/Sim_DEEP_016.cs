using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 巫妖王 费用：4 攻击力：3 耐久度：3
	//Quartzite Crusher
	//石英碎击槌
	//<b>Lifesteal</b>. <b>Freeze</b> any character damaged by your hero.
	//<b>吸血</b>。<b>冻结</b>任何受到你的英雄伤害的角色。
	class Sim_DEEP_016 : SimTemplate
	{
        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            // 处理冻结效果
            if (target != null) // 目标为随从
            {
                p.minionGetFrozen(target);
            }
            else // 目标为英雄
            {
                p.enemyHero.frozen = true;
            }
        }
    }
}

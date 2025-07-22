using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：2 攻击力：2 生命值：3
	//Papercraft Angel
	//纸艺天使
	//Your Hero Power costs (0).
	//你的英雄技能的法力值消耗为（0）点。
	class Sim_TOY_381 : SimTemplate
	{
        public override void onAuraStarts(Playfield p, Minion own)
        {
            // 将英雄技能的法力值消耗设置为0
            if (own.own)
            {
                p.ownHeroAblility.manacost = 0;
            }
            else
            {
                p.enemyHeroAblility.manacost = 0;
            }
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            // 恢复英雄技能的法力值消耗为正常值（通常为2点）
            if (own.own)
            {
                p.ownHeroAblility.manacost = 2;
            }
            else
            {
                p.enemyHeroAblility.manacost = 2;
            }
        }
    }
}

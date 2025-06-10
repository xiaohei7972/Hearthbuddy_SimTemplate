using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：3 攻击力：4 生命值：2
	//Hiffar
	//霍法
	//Your spells cost (1) less.
	//你的法术的法力值消耗减少（1）点。
	class Sim_DEEP_002t : SimTemplate
	{

        // 当该随从进入战场时
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                // 对己方的法术施加减费效果
                p.ownSpelsCostMore -= 1;
            }
        }

        // 当该随从离开战场时
        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                // 移除减费效果
                p.ownSpelsCostMore += 1;
            }
        }
    }
}

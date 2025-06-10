using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：3 攻击力：2 生命值：4
	//Luekk
	//烙欧克
	//<b>Spell Damage +2</b>
	//<b>法术伤害+2</b>
	class Sim_DEEP_002t2 : SimTemplate
	{

        // 当该随从进入战场时
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                // 增加己方法术伤害
                p.spellpower += 2;
            }
        }

        // 当该随从离开战场时
        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                // 减少己方法术伤害
                p.spellpower -= 2;
            }
        }
    }
}

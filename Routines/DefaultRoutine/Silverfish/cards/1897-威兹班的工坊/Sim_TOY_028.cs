using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：2 攻击力：0 生命值：3
	//Spirit of the Team
	//团队之灵
	//<b>Stealth</b> for 1 turn.Your hero has +2 Attackon your turn.
	//<b>潜行</b>一回合。你的英雄在你的回合拥有+2攻击力。
	class Sim_TOY_028 : SimTemplate
	{
        public override void onAuraStarts(Playfield p, Minion own)
        {
            // 当随从进入场上时，给予英雄 +2 攻击力
            if (own.own)
            {
                p.ownHero.Angr += 2;
            }
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            // 当随从离开场上时，移除英雄的 +2 攻击力
            if (own.own)
            {
                p.ownHero.Angr -= 2;
            }
        }
    }
}

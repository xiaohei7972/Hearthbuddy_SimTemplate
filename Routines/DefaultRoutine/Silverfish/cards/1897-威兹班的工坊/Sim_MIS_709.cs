using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：4
	//Holy Glowsticks
	//圣光荧光棒
	//<b>Lifesteal</b>Deal $4 damage.Costs (1) if you've casta Holy spell this turn.
	//<b>吸血</b>。造成$4点伤害。如果你在本回合中施放过神圣法术，则法力值消耗为（1）点。
	class Sim_MIS_709 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 处理造成4点伤害并吸血
            int damage = 4;
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, damage, true); // 造成伤害并吸血
                p.minionGetDamageOrHeal(ownplay ? p.ownHero : p.enemyHero, -damage); // 吸血效果
            }
        }
    }
}

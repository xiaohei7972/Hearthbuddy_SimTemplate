using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：4 攻击力：4 生命值：4
	//Snow Shredder
	//滑雪高手
	//Costs (1) if a characteris <b>Frozen</b>.
	//如果有被<b>冻结</b>的角色，则法力值消耗为（1）点。
	class Sim_VAC_429 : SimTemplate
	{
        public override void onAuraStarts(Playfield p, Minion own)
        {
            // 检查是否有任何角色被冻结
            bool isAnyCharacterFrozen = false;

            foreach (Minion m in p.ownMinions)
            {
                if (m.frozen)
                {
                    isAnyCharacterFrozen = true;
                    break;
                }
            }

            foreach (Minion m in p.enemyMinions)
            {
                if (m.frozen)
                {
                    isAnyCharacterFrozen = true;
                    break;
                }
            }

            if (p.ownHero.frozen || p.enemyHero.frozen)
            {
                isAnyCharacterFrozen = true;
            }

            // 如果有冻结的角色，将法力值消耗设置为1
            if (isAnyCharacterFrozen)
            {
                own.handcard.manacost = 1;
            }
        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            // 还原卡牌的法力值消耗到正常值
            own.handcard.manacost = own.handcard.card.cost;
        }
    }
}

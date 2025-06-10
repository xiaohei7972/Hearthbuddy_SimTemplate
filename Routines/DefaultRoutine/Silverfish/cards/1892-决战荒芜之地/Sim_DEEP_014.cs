using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 牧师 费用：2 攻击力：1 耐久度：2
	//Quick Pick
	//疾速矿锄
	//After your hero attacks, draw a card.
	//在你的英雄攻击后，抽一张牌。
	class Sim_DEEP_014 : SimTemplate
	{
        public override void onHeroattack(Playfield p, Minion own, Minion target)
        {
            // 检查己方英雄是否装备了“疾速矿锄”
            if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.DEEP_014)
            {
                // 抽一张牌
                p.drawACard(CardDB.cardIDEnum.None, own.own);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：2 攻击力：2 生命值：3
	//Toy Boat
	//玩具船
	//After you summon a Pirate, draw a card.
	//在你召唤一个海盗后，抽一张牌。
	class Sim_TOY_505 : SimTemplate
	{
        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            // 检查召唤的随从是否是海盗
            if ((TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.PIRATE && m.own)
            {
                // 抽一张牌
                p.drawACard(CardDB.cardIDEnum.None, m.own);
            }
        }
    }
}

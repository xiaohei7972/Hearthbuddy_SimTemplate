using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 术士 费用：3
	//Chamber of Viscidus
	//维希度斯的窟穴
	//[x]Look at 3 cards in yourhand and choose one todiscard. Draw two cards.
	//检视你手牌中的三张牌，选择一张弃掉。抽两张牌。
	class Sim_WON_103 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            if (triggerMinion.handcard.card.CooldownTurn == 0)
            {
                // 抽两张牌
                p.drawACard(CardDB.cardIDEnum.None, true);
                p.drawACard(CardDB.cardIDEnum.None, true);
            }
        }

    }
}

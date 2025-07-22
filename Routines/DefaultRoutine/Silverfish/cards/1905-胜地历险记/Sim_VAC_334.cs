using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 牧师 费用：3
	//Knickknack Shack
	//小玩物小屋
	//[x]Draw a card. If you playit this turn, reopen this.
	//抽一张牌。如果你在本回合中使用抽到的这张牌，重新开启本地标。
	class Sim_VAC_334 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 抽一张牌
            if (triggerMinion.handcard.card.CooldownTurn == 0) p.drawACard(CardDB.cardIDEnum.None, true);
        }

    }
}

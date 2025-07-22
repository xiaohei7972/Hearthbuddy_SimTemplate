using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：6
	//Under the Sea
	//畅游海底
	//Draw a different spell. Summon arandom minion of thatspell's Cost.
	//抽一张与本牌不同的法术牌，随机召唤一个法力值消耗与其相同的随从。
	class Sim_VAC_431 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 抽一张法术牌
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
        }
    }
}

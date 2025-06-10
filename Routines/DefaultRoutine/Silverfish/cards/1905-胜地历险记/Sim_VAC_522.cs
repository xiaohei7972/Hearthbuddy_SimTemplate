using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 法师 费用：3
	//Tide Pools
	//潮汐之池
	//[x]<b>Discover</b> a spell thatcosts (3) or less.After you cast a spell,reopen this.
	//<b>发现</b>一张法力值消耗小于或等于（3）点的法术牌。在你施放一个法术后，重新开启本地标。
	class Sim_VAC_522 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 发现一张法力值消耗小于或等于3的法术牌
            if (triggerMinion.handcard.card.CooldownTurn == 0) p.drawACard(CardDB.cardIDEnum.None, true);
        }

    }
}

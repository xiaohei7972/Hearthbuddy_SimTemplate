using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：1 攻击力：1 生命值：2
	//Ship's Chirurgeon
	//随船外科医师
	//After you summon a minion, give it +1 Health.
	//在你召唤一个随从后，使其获得+1生命值。
	class Sim_CORE_WON_065 : SimTemplate
	{
        public override void onMinionWasSummoned(Playfield p, Minion ownMinion, Minion summonedMinion)
        {
            if (ownMinion.own) // 判断是否是自己的随从召唤
            {
                p.minionGetBuffed(summonedMinion, 0, 1); // 给予召唤的随从+1生命值
            }
        }
    }
}

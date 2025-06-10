using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 牧师 费用：3
	//The Crystal Cove
	//水晶海湾
	//[x]The next minion yousummon this turn hasits stats set to 5/5.
	//在本回合中，你召唤的下一个随从的属性值变为5/5。
	class Sim_TOY_512 : SimTemplate
	{

        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 激活效果，标记本回合中下一个召唤的随从将成为5/5
            p.nextMinionBecomesFiveFive = true;
        }
    }
}

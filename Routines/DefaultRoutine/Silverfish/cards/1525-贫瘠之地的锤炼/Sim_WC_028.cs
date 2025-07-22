using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_028 : SimTemplate //* 集合石 Meeting Stone
	{
        //[x]At the end of your turn,add a 2/2 Adventurerwith a random bonus effectto your hand.
        //在你的回合结束时，将一张2/2并具有随机效果的冒险者置入你的手牌。
        public override void onAuraEnds(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.WC_034t2, true, true);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：4
	//Helm of Humiliation
	//屈辱头盔
	//Give a minion -5/-5. Give a minion in your hand +5/+5.
	//使一个随从获得-5/-5。使你手牌中的一张随从牌获得+5/+5。
	class Sim_MIS_100 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 使目标随从获得 -5/-5
            if (target != null)
            {
                p.minionGetBuffed(target, -5, -5);
            }
        }
    }
}

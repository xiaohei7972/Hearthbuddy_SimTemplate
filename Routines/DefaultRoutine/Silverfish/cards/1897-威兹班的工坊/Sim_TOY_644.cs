using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：1
	//Red Card
	//红牌
	//Make a minion go <b>Dormant</b> for 2 turns.
	//使一个随从<b>休眠</b>2回合。
	class Sim_TOY_644 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                target.dormant = 2; // 使目标随从休眠2回合
            }
        }
    }
}

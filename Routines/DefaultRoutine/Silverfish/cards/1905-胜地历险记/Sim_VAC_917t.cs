using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Sunscreen
	//防晒霜
	//Give a minion +1/+2.
	//使一个随从获得+1/+2。
	class Sim_VAC_917t : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 1, 2); // 给目标随从增加+1攻击力和+2生命值
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET)    // 目标必须是随从
            };
        }
    }
}

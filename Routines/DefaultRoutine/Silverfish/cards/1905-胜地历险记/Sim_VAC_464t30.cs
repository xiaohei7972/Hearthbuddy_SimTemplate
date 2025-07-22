using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Hilt of Quel'Delar
	//奎尔德拉的剑柄
	//Give a minion +3/+3.
	//使一个随从获得+3/+3。
	class Sim_VAC_464t30 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 3, 3); // 使随从获得+3/+3
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),   // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET)    // 目标必须是随从
            };
        }
    }
}

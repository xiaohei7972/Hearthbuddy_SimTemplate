using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：2
	//Mutating Injection
	//变异注射
	//Give a minion +4/+4 and <b>Taunt</b>.
	//使一个随从获得+4/+4和<b>嘲讽</b>。
	class Sim_VAC_464t3 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 4, 4); // 使随从获得+4/+4
                target.taunt = true; // 赋予随从嘲讽
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

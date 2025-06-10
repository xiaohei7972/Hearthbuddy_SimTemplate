using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：3
	//Cryopractor
	//冰冷整脊师
	//<b>Battlecry:</b> Give a minion +3/+3 and <b>Freeze</b> it.
	//<b>战吼：</b>使一个随从获得+3/+3并使其<b>冻结</b>。
	class Sim_VAC_327 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 3, 3); // 使目标随从获得+3/+3
                target.frozen = true; // 使目标随从冻结
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是随从
            };
        }
    }
}

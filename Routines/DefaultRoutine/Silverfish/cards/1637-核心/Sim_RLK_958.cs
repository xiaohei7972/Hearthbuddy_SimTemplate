using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_RLK_958 : SimTemplate
    {
        // 处理战吼效果的方法
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 判断目标是否为友方亡灵
            if (target != null && target.own && target.handcard.card.race == CardDB.Race.UNDEAD)
            {
                // 给目标亡灵随从+2攻击力
                p.minionGetBuffed(target, 2, 0);
            }

        }
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 11), // 目标只能是亡灵
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 没有目标时也可以使用
            };
        }

    }
}

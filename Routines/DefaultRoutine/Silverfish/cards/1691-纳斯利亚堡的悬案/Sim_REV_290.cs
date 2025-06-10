using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_REV_290 : SimTemplate //* 赎罪教堂 Cathedral of Atonement
                                    //使一个随从获得+2/+1。抽一张牌。
                                    //Give a minion +2/+1 and draw a card.
    {
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 检查目标是否为有效随从
            if (target != null)
            {
                // 为目标随从增加2点攻击力和1点生命值
                p.minionGetBuffed(target, 2, 1);
            }

            // 抽一张牌
            p.drawACard(CardDB.cardIDEnum.None, triggerMinion.own);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]
            {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标必须是友方随从
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是一个随从
            };
        }
    }
}

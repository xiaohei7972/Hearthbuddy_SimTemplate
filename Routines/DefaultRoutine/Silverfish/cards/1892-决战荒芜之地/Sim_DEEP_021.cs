using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //法术 潜行者 费用：5
    //Shadow Word: Steal
    //暗言术：窃
    //Return an enemy minion to YOUR hand.
    //将一个敌方随从移回<b>你</b>的手牌。
    class Sim_DEEP_021 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null) // 确保目标是敌方随从
            {
                // 将目标随从移回玩家的手牌
                p.minionReturnToHand(target, ownplay, 0);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要目标   
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 需要随从目标
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 需要敌方目标
            };
        }
    }
}

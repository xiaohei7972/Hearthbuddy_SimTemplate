using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：2
	//Eat! The! Imp!
	//吃掉小鬼！
	//Destroy a friendlyminion to draw 3 cards.
	//消灭一个友方随从以抽三张牌。
	class Sim_VAC_939 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null && target.own)
            {
                p.minionGetDestroyed(target); // 消灭目标友方随从
                for (int i = 0; i < 3; i++)
                {
                    p.drawACard(CardDB.cardIDEnum.None, ownplay, true); // 抽三张牌
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),    // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET)   // 目标必须是友方随从
            };
        }
    }
}

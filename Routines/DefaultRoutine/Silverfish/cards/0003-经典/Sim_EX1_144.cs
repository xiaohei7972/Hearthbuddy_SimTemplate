using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_144 : SimTemplate //* 暗影步 Shadowstep
	{
		//Return a friendly minion to your hand. It_costs (2) less.
		//将一个友方随从移回你的手牌，它的法力值消耗减少（2）点。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            // 将目标随从移回玩家手牌，并减少其法力值消耗2点
            p.minionReturnToHand(target, ownplay, -2);
		}

        // 获取卡牌的使用要求
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),     // 需要指定目标
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),   // 目标必须是友方随从
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),     // 目标必须是随从
            };
        }
	}
}

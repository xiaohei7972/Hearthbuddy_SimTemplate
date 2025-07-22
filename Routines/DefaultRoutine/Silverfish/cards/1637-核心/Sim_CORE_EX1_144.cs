using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    // 定义一个新的模拟类，表示暗影步卡牌的效果
	class Sim_CORE_EX1_144 : SimTemplate //* shadowstep
	{
        // 暗影步：将一个友方随从移回你的手牌。该随从的法力值消耗减少（2）点。
        // Shadowstep: Return a friendly minion to your hand. It costs (2) less.

        // 当卡牌被使用时，执行此方法
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            // 将目标随从移回手牌，并使其法力值消耗减少2点
            p.minionReturnToHand(target, ownplay, -2);
		}

        // 获取此卡牌的使用要求
        public override PlayReq[] GetPlayReqs()
        {
            // 返回一组使用要求：
            // 1. 需要一个目标才能使用（REQ_TARGET_TO_PLAY）
            // 2. 目标必须是一个随从（REQ_MINION_TARGET）
            // 3. 目标必须是友方随从（REQ_FRIENDLY_TARGET）
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}

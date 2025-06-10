using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    // 定义一个新的模拟类，表示“冷血”卡牌的效果
	class Sim_CS2_073 : SimTemplate //* 冷血 Cold Blood
	{
		// 冷血：使一个随从获得+2攻击力；<b>连击：</b>改为获得+4攻击力。
        // Cold Blood: Give a minion +2 Attack. <b>Combo:</b> +4 Attack instead.

        // 当卡牌被使用时，执行此方法
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            // 仅判断我方本回合是否已经使用过其他卡牌
            int ag = (ownplay && p.cardsPlayedThisTurn >= 1) ? 4 : 2; // 如果我方本回合已经使用过其他卡牌，则增加4点攻击力，否则增加2点攻击力。
            
            // 为目标随从增加攻击力
            p.minionGetBuffed(target, ag, 0);
		}

        // 获取此卡牌的使用要求
        public override PlayReq[] GetPlayReqs()
        {
            // 返回一组使用要求：
            // 1. 需要一个目标才能使用（REQ_TARGET_TO_PLAY）
            // 2. 目标必须是一个随从（REQ_MINION_TARGET）
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_CS2_073 : SimTemplate //* 冷血 Cold Blood
    {
        //Give a minion +2 Attack. <b>Combo:</b> +4 Attack instead.
        //使一个随从获得+2攻击力；<b>连击：</b>改为获得+4攻击力。

        // 当这张卡牌被使用时，调用 onCardPlay 方法
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 根据当前回合是否已经使用过其他卡牌来决定攻击力加成
            // 如果满足连击条件（本回合已经使用过至少一张卡牌，或者是对手使用该卡牌），则获得+4攻击力；否则获得+2攻击力。
            int ag = (p.cardsPlayedThisTurn >= 1 || !ownplay) ? 4 : 2;

            // 给目标随从增加相应的攻击力
            p.minionGetBuffed(target, ag, 0);
        }

        // 获取这张卡牌的使用条件
        public override PlayReq[] GetPlayReqs()
        {
            // 返回卡牌的使用要求：
            // 1. 需要选择一个目标才能使用
            // 2. 目标必须是一个随从
            // 3. 目标必须是友方随从
            return new PlayReq[] {
            new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),      // 需要选择一个目标
            new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),       // 目标必须是随从
            new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET)      // 目标必须是友方随从
        };
        }
    }
}

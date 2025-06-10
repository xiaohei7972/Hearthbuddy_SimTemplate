using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 牧师 费用：1 攻击力：2 生命值：1
	//Prize Plunderer
	//奖品掠夺者
	//[x]<b>Combo:</b> Deal 1 damage toa minion for each other cardyou've played this turn.
	//<b>连击：</b>在本回合中，你每使用一张其他牌，便对一个随从造成1点伤害。
	class Sim_DMF_519_COPY : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 如果这张牌是玩家自己使用的
            if (own.own)
            {
                // 检查本回合已打出的牌数量（不包括当前这张牌）
                int damage = p.cardsPlayedThisTurn - 1;

                // 确保伤害值为非负数
                if (damage > 0 && target != null)
                {
                    p.minionGetDamageOrHeal(target, damage);
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                // 要求有一个目标才能使用这张牌
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                // 目标必须是一个随从
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                // 目标必须是敌方随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
    }
}

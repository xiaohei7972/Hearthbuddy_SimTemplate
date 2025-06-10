using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 潜行者 费用：5 攻击力：5 生命值：5
	//Raza the Resealed
	//重封者拉兹
	//[x]<b>Battlecry:</b> For the rest ofthe game, your Hero Powerrefreshes whenever youplay a card.
	//<b>战吼：</b>在本局对战的剩余时间内，每当你使用卡牌时，复原你的英雄技能。
	class Sim_TOY_383 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 设置一个标志，表示在本局对战的剩余时间内，每当你使用卡牌时复原英雄技能
            if (own.own)
            {
                p.ownHeroPowerCanBeUsedMultipleTimes = true; // 假设这是一个标志，表示英雄技能可以多次使用
            }
        }

        public override void onCardWasPlayed(Playfield p, CardDB.Card card, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 每当玩家使用卡牌时，如果标志被激活，则复原英雄技能
            if (wasOwnCard && p.ownHeroPowerCanBeUsedMultipleTimes)
            {
                p.ownAbilityReady = true; // 复原英雄技能
            }
        }
    }
}

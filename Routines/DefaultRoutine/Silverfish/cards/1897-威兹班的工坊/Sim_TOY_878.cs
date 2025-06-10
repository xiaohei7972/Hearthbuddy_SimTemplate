using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：3 攻击力：3 生命值：4
	//Cosplay Contestant
	//扮装选手
	//After your opponent plays a minion, transform into a 3/4 copy of it.
	//在你的对手使用一张随从牌后，变形成为它的3/4的复制。
	class Sim_TOY_878 : SimTemplate
	{
        public override void onCardWasPlayed(Playfield p, CardDB.Card card, bool wasOwnCard, Minion triggerEffectMinion)
        {
            // 检查是否是对手打出的随从牌，并且触发随从是否是扮装选手
            if (!wasOwnCard && card.type == CardDB.cardtype.MOB && triggerEffectMinion.name == CardDB.cardNameEN.cosplaycontestant)
            {
                // 变形为对手打出的随从的3/4复制
                p.minionTransform(triggerEffectMinion, card);
                triggerEffectMinion.Hp = 4; // 设置生命值为4
                triggerEffectMinion.maxHp = 4;
                triggerEffectMinion.Angr = 3; // 设置攻击力为3
            }
        }

    }
}

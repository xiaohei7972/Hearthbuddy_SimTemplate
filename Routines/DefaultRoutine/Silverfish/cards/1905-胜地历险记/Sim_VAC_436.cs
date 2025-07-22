using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：2 攻击力：1 生命值：4
	//Brittlebone Buccaneer
	//脆骨海盗
	//Whenever you play a <b>Deathrattle</b> minion,give it <b>Reborn</b>.
	//每当你使用一张<b>亡语</b>随从牌时，使其获得<b>复生</b>。
	class Sim_VAC_436 : SimTemplate
	{
        public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            // 检查触发效果的随从是否是“脆骨海盗”
            if (triggerEffectMinion.own && triggerEffectMinion.name == CardDB.cardNameEN.brittlebonebuccaneer)
            {
                // 检查被召唤的随从是否具有亡语效果
                if (summonedMinion.handcard.card.deathrattle)
                {
                    // 给予复生效果
                    summonedMinion.reborn = true;
                }
            }
        }

    }
}

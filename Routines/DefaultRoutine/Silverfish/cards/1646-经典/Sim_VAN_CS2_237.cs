using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_237 : SimTemplate //* 饥饿的秃鹫 Starving Buzzard
	{
		//Whenever you summon a Beast, draw a card.
		//每当你召唤一个野兽，抽一张牌。
        public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.own == summonedMinion.own && (TAG_RACE)summonedMinion.handcard.card.race == TAG_RACE.PET)
            {
                p.drawACard(CardDB.cardIDEnum.None, triggerEffectMinion.own);
            }
        }

	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_235 : SimTemplate //* 北郡牧师 Northshire Cleric
//Whenever a minion is healed, draw a card.
//每当一个随从获得治疗时，抽一张牌。 
	{
        

        public override void onAMinionGotHealedTrigger(Playfield p, Minion triggerEffectMinion, int minionsGotHealed)
        {
            for (int i = 0; i < minionsGotHealed; i++)
            {
                p.drawACard(CardDB.cardIDEnum.None, triggerEffectMinion.own);
            }
        }
	}
}
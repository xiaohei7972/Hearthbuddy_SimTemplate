using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Mekka1 : SimTemplate //* 导航小鸡 Homing Chicken
//At the start of your turn, destroy this minion and draw 3 cards.
//在你的回合开始时，消灭该随从，并抽三张牌。 
	{



        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (turnStartOfOwner == triggerEffectMinion.own)
            {
                p.minionGetDestroyed(triggerEffectMinion);
                p.drawACard(CardDB.cardIDEnum.None, turnStartOfOwner);
                p.drawACard(CardDB.cardIDEnum.None, turnStartOfOwner);
                p.drawACard(CardDB.cardIDEnum.None, turnStartOfOwner);
            }
        }

	}
}
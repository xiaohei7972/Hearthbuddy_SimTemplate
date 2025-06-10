using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_663 : SimTemplate //* 暗金教恶魔商贩 Kabal Trafficker
//[x]At the end of your turn,add a random Demonto your hand.
//在你的回合结束时，随机将一张恶魔牌置入你的手牌。 
	{
		

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                p.drawACard(CardDB.cardNameEN.malchezaarsimp, turnEndOfOwner, true);
            }
        }
    }
}
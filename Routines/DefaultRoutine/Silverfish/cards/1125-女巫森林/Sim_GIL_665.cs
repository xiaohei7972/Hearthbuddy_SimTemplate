using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_665 : SimTemplate //* 虚弱诅咒 Curse of Weakness
//<b>Echo</b>Give all enemy minions -2_Attack until your next_turn.
//<b>回响</b>直到你的下个回合，使所有敌方随从获得-2攻击力。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.enemyMinions : p.ownMinions;
            foreach (Minion m in temp)
            {
                p.minionGetTempBuff(m, -2, 0);
            }
			p.drawACard(CardDB.cardIDEnum.GIL_665, ownplay, true);
		}
		
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			p.discardCards(1, turnEndOfOwner);
		}
	}
}
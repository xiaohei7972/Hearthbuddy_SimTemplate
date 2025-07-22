using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_607t : SimTemplate //* 狩猎犬 Hunting Mastiff
//<b>Echo</b><b>Rush</b>
//<b>回响，突袭</b> 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.GIL_607t, own.own, true);
		}
		
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			p.discardCards(1, turnEndOfOwner);
        }
		
	}
}
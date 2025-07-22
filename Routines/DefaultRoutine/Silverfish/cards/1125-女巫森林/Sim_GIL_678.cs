using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_678 : SimTemplate //* 冥光鱼人 Ghost Light Angler
//<b>Echo</b>
//<b>回响</b> 
	{
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.mana >= 6 && p.owncards.Count <=4)
			{	
			    p.drawACard(CardDB.cardIDEnum.GIL_678, own.own);
			}
		}
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			p.discardCards(1, turnEndOfOwner);
		}
	}
}
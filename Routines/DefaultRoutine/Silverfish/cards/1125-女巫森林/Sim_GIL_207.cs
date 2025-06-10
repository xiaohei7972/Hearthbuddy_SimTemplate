using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_207 : SimTemplate //* 魅影民兵 Phantom Militia
//<b>Echo</b><b>Taunt</b>
//<b>回响，嘲讽</b> 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.GIL_207, own.own, true);
		}
		
		public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
		{
			p.discardCards(1, turnEndOfOwner);
        }


	}
}
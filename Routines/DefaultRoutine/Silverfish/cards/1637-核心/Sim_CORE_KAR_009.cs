using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CORE_KAR_009 : SimTemplate //* Babbling Book
	{
		//Battlecry: Add a random Mage spell to your hand.
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.frostbolt, own.own, true);
		}
	}
}
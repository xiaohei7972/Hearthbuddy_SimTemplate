using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_007 : SimTemplate //* 嗜法者 Spellslinger
//<b>Battlecry:</b> Add a random spell to each player's hand.
//<b>战吼：</b>随机将一张法术牌置入每个玩家的手牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.frostbolt, true, true);
            p.drawACard(CardDB.cardNameEN.frostbolt, false, true);
		}
	}
}
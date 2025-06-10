using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_998l : SimTemplate //* 奇迹之杖 Wondrous Wand
//Draw 3 cards. Reduce their Costs to (0).
//抽三张牌，其法力值消耗为（0）点。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
			if (ownplay) p.evaluatePenality -= 20;
		}
	}
}
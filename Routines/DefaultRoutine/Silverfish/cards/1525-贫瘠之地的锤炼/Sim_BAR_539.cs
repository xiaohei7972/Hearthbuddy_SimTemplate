using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_539 : SimTemplate //* 超凡之盟 Celestial Alignment
	{
		//Set each player to 0 Mana Crystals. Set the Cost of cards in all hands and decks to (1).
		//将双方玩家的法力水晶重置为零个。将所有手牌和牌库中的牌的法力值消耗变为（1）点。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.ownMaxMana = 0;
			p.enemyMaxMana = 0;
			foreach (Handmanager.Handcard ohc in p.owncards)
			{
				ohc.manacost = 0;
			}
		}
		
	}
}

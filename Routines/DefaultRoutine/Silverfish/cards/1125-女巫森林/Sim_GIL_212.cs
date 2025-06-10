using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_212 : SimTemplate //* 唤鸦者 Ravencaller
//[x]<b>Battlecry:</b> Add tworandom 1-Cost minionsto your hand.
//<b>战吼：</b>随机将两张法力值消耗为（1）的随从牌置入你的手牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.murlocraider, true, true);
            p.drawACard(CardDB.cardNameEN.murlocraider, true, true);
		}
	}
}
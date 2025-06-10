using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_122 : SimTemplate //* 山谷之王穆克拉 Mukla, Tyrant of the Vale
//<b>Battlecry:</b> Add 2 Bananas to your hand.
//<b>战吼：</b>将两根香蕉置入你的手牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.bananas, own.own, true);
            p.drawACard(CardDB.cardNameEN.bananas, own.own, true);
		}
	}
}
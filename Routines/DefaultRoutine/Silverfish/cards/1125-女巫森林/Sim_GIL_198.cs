using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_198 : SimTemplate //* 窃魂者阿扎莉娜 Azalina Soulthief
//<b>Battlecry:</b> Replace your hand with a copy of your_opponent's.
//<b>战吼：</b>将你的手牌替换成对手手牌的复制。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int diff = (own.own) ? p.enemyAnzCards - p.owncards.Count :  p.owncards.Count - p.enemyAnzCards;
            if (diff >= 1)
            {
                for (int i = 0; i < diff; i++)
                {
                    
                    p.drawACard(CardDB.cardNameEN.unknown, own.own);
                }
            }
		}

	}
}
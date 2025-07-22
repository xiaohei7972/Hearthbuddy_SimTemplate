using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_054 : SimTemplate //* 唤雾者伊戈瓦尔 The Mistcaller
//<b>Battlecry:</b> Give all minions in your hand and deck +1/+1.
//<b>战吼：</b>使你的手牌和牌库里的所有随从牌获得+1/+1。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB)
                    {
                        hc.addattack++;
                        hc.addHp++;
                    }
                }
			}
		}
	}
}
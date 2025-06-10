using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_072 : SimTemplate //* 瓦里安·乌瑞恩 Varian Wrynn
//<b>Battlecry:</b> Draw 3 cards.Put any minions you drew directly into the battlefield.
//<b>战吼：</b>抽三张牌。将抽到的随从牌直接置入战场。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				int tmpCard = p.owncards.Count;
				p.drawACard(CardDB.cardIDEnum.None, own.own);
				if (tmpCard < 10)
				{
					p.owncards.RemoveRange(p.owncards.Count - 1, 1);
					p.owncarddraw--;
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_120), p.ownMinions.Count, own.own, false);
				}
				p.drawACard(CardDB.cardIDEnum.None, own.own);
				if (tmpCard < 10)
				{
					p.owncards.RemoveRange(p.owncards.Count - 1, 1);
					p.owncarddraw--;
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_048), p.ownMinions.Count, own.own, false);
				}
				p.drawACard(CardDB.cardIDEnum.None, own.own);
			}
		}
	}
}
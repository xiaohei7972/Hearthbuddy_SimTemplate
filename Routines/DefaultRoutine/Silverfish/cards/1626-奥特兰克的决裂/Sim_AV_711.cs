using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_711 : SimTemplate //* 双面间谍 doubleagent
	{
		//<b>战吼：</b> 如果你的手牌中有另一职业的卡牌，召唤一个该随从的复制。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_711);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				int heroClass = (int)p.ownHeroStartClass;
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.Class != heroClass && hc.card.Class != 0)
					{
						if (p.ownMinions.Count < 7)
						{
							p.callKid(kid, own.zonepos, own.own);
							List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
							temp[own.zonepos].setMinionToMinion(own);
						}
					}
				}
			}
		}

	}
}

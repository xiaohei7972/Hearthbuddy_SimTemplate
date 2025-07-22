using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_402 : SimTemplate //* 萨索瓦尔 Sathrovarr
	{
		//<b>Battlecry:</b> Choose a friendly minion. Add a copy of it to your hand, deck, and battlefield.
		//<b>战吼：</b>选择一个友方随从。将它的一个复制置入你的手牌，牌库以及战场。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			if (target != null)
			{
				if (m.own)
				{
					p.drawACard(target.handcard.card.nameEN, m.own, true);
					p.ownDeckSize++;
				}
				else p.enemyDeckSize++;
			}
			if (target != null && p.ownMinions.Count < 7)
			{
				p.callKid(target.handcard.card, m.zonepos, m.own);
				p.ownMinions[m.zonepos].setMinionToMinion(target);
			}
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
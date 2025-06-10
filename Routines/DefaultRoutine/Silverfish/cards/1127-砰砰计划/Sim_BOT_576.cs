using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_576 : SimTemplate //* 疯狂的药剂师 Crazed Chemist
//<b>Combo:</b> Give a friendly minion +4 Attack.
//<b>连击：</b>使一个友方随从获得+4攻击力。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.cardsPlayedThisTurn >= 1 && target != null)
            {
                int ag = (p.cardsPlayedThisTurn >= 1 || !own.own) ? 4 : 4;
				p.minionGetBuffed(target, ag, 4);
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_FOR_COMBO),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
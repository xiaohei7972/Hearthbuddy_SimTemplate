using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_516 : SimTemplate //* 蛇发女妖佐拉 Zola the Gorgon
//<b>Battlecry:</b> Choose a friendly minion. Add a Golden copy of it to your hand.
//<b>战吼：</b>选择一个友方随从。将它的金色复制置入你的手牌。 
	{



		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target != null) p.drawACard(target.handcard.card.nameEN, own.own, true);
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
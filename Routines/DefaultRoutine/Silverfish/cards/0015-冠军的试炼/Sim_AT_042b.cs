using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_042b : SimTemplate //* 黑豹形态 Panther Form
//<b>Stealth</b>
//<b>潜行</b> 
	{
		
		
        CardDB.Card Stealth = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_042t2);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionTransform(target, Stealth);
        }
	}
}
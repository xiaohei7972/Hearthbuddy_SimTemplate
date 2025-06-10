using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_112 : SimTemplate //* 格尔宾·梅卡托克 Gelbin Mekkatorque
//<b>Battlecry:</b> Summon an AWESOME invention.
//<b>战吼：</b>进行一次惊人的发明。 
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.Mekka1);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, own.zonepos, own.own);
		}


	}
}
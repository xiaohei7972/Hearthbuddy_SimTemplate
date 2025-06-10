using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_156 : SimTemplate //* 怒鳍猎潮者 Bilefin Tidehunter
//<b>Battlecry:</b> Summon a 1/1 Ooze with <b>Taunt</b>.
//<b>战吼：</b>召唤一个1/1并具有<b>嘲讽</b>的软泥怪。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_156a);
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, own.zonepos, own.own);
		}
	}
}
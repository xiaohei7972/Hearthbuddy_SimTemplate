using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_710 : SimTemplate //* 奥能铁匠 Arcanosmith
//<b>Battlecry:</b> Summon a 0/5 minion with <b>Taunt</b>.
//<b>战吼：</b>召唤一个0/5并具有<b>嘲讽</b>的随从。 
	{
		
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_710m);
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, own.zonepos, own.own);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_151 : SimTemplate //* 退役冠军 Former Champ
//<b>Battlecry:</b> Summon a 5/5_Hotshot.
//<b>战吼：</b>召唤一个5/5的赛场新秀。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_151t);
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, own.zonepos, own.own);
		}
	}
}
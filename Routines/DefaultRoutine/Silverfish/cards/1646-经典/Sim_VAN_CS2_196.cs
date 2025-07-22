using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_196 : SimTemplate //* 剃刀猎手 Razorfen Hunter
	{
		//<b>Battlecry:</b> Summon a 1/1_Boar.
		//<b>战吼：</b>召唤一个1/1的野猪。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_CS2_boar); //boar

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, own.zonepos, own.own);
		}
	}
}
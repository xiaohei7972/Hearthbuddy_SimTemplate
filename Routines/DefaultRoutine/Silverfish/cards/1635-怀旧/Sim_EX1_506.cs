using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_506 : SimTemplate //* 鱼人猎潮者 Murloc Tidehunter
	{
		//<b>Battlecry:</b> Summon a 1/1_Murloc Scout.
		//<b>战吼：</b>召唤一个1/1的鱼人斥候。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_506a);//murlocscout
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, own.zonepos, own.own);
		}


	}
}
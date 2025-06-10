using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_116 : SimTemplate //* 火车王里诺艾 Leeroy Jenkins
//<b>Charge</b>. <b>Battlecry:</b> Summon two 1/1 Whelps for your opponent.
//<b>冲锋，战吼：</b>为你的对手召唤两条1/1的雏龙。 
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_116t);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{

            int pos = (own.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(kid, pos, !own.own);
            p.callKid(kid, pos, !own.own);
		}
	}
}
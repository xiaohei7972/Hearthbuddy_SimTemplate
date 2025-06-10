using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_926 : SimTemplate //* 身陷绝境的哨卫 Cornered Sentry
//<b>Taunt</b>. <b>Battlecry:</b> Summon three 1/1 Raptors for your_opponent.
//<b>嘲讽，战吼：</b>为你的对手召唤三只1/1的迅猛龙。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_076t1); 

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int pos = (own.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(kid, pos, !own.own);
            p.callKid(kid, pos, !own.own);
            p.callKid(kid, pos, !own.own);
		}
	}
}
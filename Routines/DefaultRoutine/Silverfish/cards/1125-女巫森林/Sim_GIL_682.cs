using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_682 : SimTemplate //* 泥沼狩猎者 Muck Hunter
//<b>Rush</b><b>Battlecry:</b> Summon two 2/1_Mucklings for your opponent.
//<b>突袭，战吼：</b>为你的对手召唤两个2/1的泥沼怪。 
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_682t);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{

            int pos = (own.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            p.callKid(kid, pos, !own.own);
            p.callKid(kid, pos, !own.own);
		}
	}
}
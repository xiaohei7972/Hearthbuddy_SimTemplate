using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_080t3 : SimTemplate //* 大型法术翡翠 Greater Emerald Spellstone
//Summon four 3/3_Wolves.
//召唤四只3/3的狼。 
	{
        

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_077t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			
		}
	}
}
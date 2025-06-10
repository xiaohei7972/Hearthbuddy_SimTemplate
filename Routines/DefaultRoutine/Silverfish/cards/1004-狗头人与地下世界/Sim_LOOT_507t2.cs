using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_507t2 : SimTemplate //* 大型法术钻石 Greater Diamond Spellstone
//Resurrect 4 different friendly minions.
//复活四个不同的友方随从。 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.ownMaxMana == 10)
            {
                int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                CardDB.Card kid = CardDB.Instance.getCardDataFromID((p.OwnLastDiedMinion == CardDB.cardIDEnum.None) ? CardDB.cardIDEnum.EX1_345t : p.OwnLastDiedMinion); 
                p.callKid(kid, posi, ownplay, false);
				p.callKid(kid, posi, ownplay);
				p.callKid(kid, posi, ownplay);
				p.callKid(kid, posi, ownplay);
				
            }
		}
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_621t39 : SimTemplate //* 亡灵腐液 Ichor of Undeath
//Summon 3 friendly minions that died this game.
//召唤三个在本局对战中死亡的友方随从。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			if (p.OwnLastDiedMinion != CardDB.cardIDEnum.None)
			{
				p.callKid(CardDB.Instance.getCardDataFromID(p.OwnLastDiedMinion), pos, ownplay, false); 
				p.callKid(CardDB.Instance.getCardDataFromID(p.OwnLastDiedMinion), pos, ownplay);
				p.callKid(CardDB.Instance.getCardDataFromID(p.OwnLastDiedMinion), pos, ownplay);
			}
        }
    }
}
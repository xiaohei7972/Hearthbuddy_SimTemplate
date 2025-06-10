using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_507 : SimTemplate //* 小型法术钻石 Lesser Diamond Spellstone
//Resurrect 2 different friendly minions. @<i>(Cast 4 spells to upgrade.)</i>
//复活两个不同的友方随从。@<i>（施放四个法术后升级。）</i> 
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.ownMaxMana == 10)
            {
                int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                CardDB.Card kid = CardDB.Instance.getCardDataFromID((p.OwnLastDiedMinion == CardDB.cardIDEnum.None) ? CardDB.cardIDEnum.EX1_345t : p.OwnLastDiedMinion); 
                p.callKid(kid, posi, ownplay, false);
				p.callKid(kid, posi, ownplay);
				
            }
		}
	}
}
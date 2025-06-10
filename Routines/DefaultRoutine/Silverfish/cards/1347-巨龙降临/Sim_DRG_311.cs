using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_311 : SimTemplate //* 树木援军 Treenforcements
	{
		//[x]<b>Choose One -</b> Give aminion +2 Health and<b>Taunt</b>; or Summon a2/2 Treant.
		//<b>抉择：</b>使一个随从获得+2生命值和<b>嘲讽</b>；或者召唤一个2/2的树人。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_311t); //树人
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, place, ownplay);
			}
			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				p.minionGetBuffed(target, 0, 2);
				if (!target.taunt)
				{
					target.taunt = true;
					if (target.own) p.anzOwnTaunt++;
					else p.anzEnemyTaunt++;
				}
			}			
		}
	}
}
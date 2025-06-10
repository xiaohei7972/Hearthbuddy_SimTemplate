using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_422 : SimTemplate //* 播种施肥 Sow the Soil
	{
		//<b>Choose One</b> - Give your minions +1 Attack; or_ Summon a 2/2 Treant.
		//<b>抉择：</b>使你的所有随从获得+1攻击力；或者召唤一个2/2的树人。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_422t);//panther

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				p.allMinionOfASideGetBuffed(ownplay, 1, 1);
			}
			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay, false);

			}
		}
	}
}
		
	


using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_160 : SimTemplate //* 野性之力 Power of the Wild
	{
		//<b>Choose One -</b> Give your minions +1/+1; or Summon a 3/2 Panther.
		//<b>抉择：</b>使你的所有随从获得+1/+1；或者召唤一个3/2的猎豹。

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_160t);//panther

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
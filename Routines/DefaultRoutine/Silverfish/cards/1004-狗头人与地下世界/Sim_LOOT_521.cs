using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_521 : SimTemplate //* 欧克哈特大师 Master Oakheart
//<b>Battlecry:</b> <b>Recruit</b> a 1, 2, and 3-Attack minion.
//<b>战吼：</b><b>招募</b>攻击力为1，2，3的随从各一个。 
	{
        

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_835);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
			if (ownplay) p.evaluatePenality -= 10;
			
		}

	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_003 : SimTemplate //* 虚空之风传送门 Netherwind Portal
	{
		//<b>Secret:</b> After your opponent casts a spell, summon a random4-Cost minion.
		//<b>奥秘：</b>在你的对手施放一个法术后，随机召唤一个法力值消耗为（4）的随从。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_182);//Panther - Cat in a Hat

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
        }
		
		
	}
}

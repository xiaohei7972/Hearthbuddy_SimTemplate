using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_203 : SimTemplate //* 集群战术 Pack Tactics
	{
		//<b>Secret:</b> When a friendly minion is attacked, summon a 3/3 copy.
		//<b>奥秘：</b>当一个友方随从受到攻击时，召唤一个该随从的3/3的复制。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_800);//Ironfur Grizzly

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, place, ownplay);
        }
		
		
	}
}

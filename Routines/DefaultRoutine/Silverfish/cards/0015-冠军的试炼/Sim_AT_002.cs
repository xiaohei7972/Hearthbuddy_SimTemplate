using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_002 : SimTemplate //* 轮回 Effigy
//<b>Secret:</b> When a friendly minion dies, summon a random minion with the same Cost.
//<b>奥秘：</b>当一个友方随从死亡时，随机召唤一个法力值消耗相同的随从。 
	{
		public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)//奥秘触发
        {
                p.callKid(p.getRandomCardForManaMinion(target.handcard.card.cost), target.zonepos, ownplay);
        }
	}
}

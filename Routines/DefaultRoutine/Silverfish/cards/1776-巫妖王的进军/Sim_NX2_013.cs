using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//ZOMBEEEES!!!
	//僵尸蜂群
	//<b>Secret:</b> After your opponent plays a minion, summon four 1/1 Zombees to attack it.
	//<b>奥秘：</b>在你的对手使用一张随从牌后，召唤四只1/1的尸蜂攻击它。
	class Sim_NX2_013 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.NX2_013t);
		public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
		{
			List<int> kidpos = new List<int>();
			for (int i = 0; i < 4; i++)
			{
				int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, ownplay);
				kidpos.Add(pos);
			}

			for (int i = 0; i < kidpos.Count; i++)
			{
				if (target != null)
				{
					Minion m = ownplay ? p.ownMinions[kidpos[i]] : p.enemyMinions[kidpos[i]];
					p.minionAttacksMinion(m, target);
				}
			}

		}

	}
}

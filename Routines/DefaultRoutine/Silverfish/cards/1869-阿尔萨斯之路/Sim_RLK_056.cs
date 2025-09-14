using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：2
	//Unholy Frenzy
	//邪恶狂热
	//[x]Choose an enemy minion.Your minions attack it.Resummon any that die.
	//选择一个敌方随从，使你的所有随从攻击该随从。再次召唤死亡的友方随从。
	class Sim_RLK_056 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				if (target != null)
				{
					List<Minion> deathMinion = new List<Minion>();
					foreach (Minion minion in p.ownMinions)
					{
						if (minion.untouchable) continue;
						p.minionAttacksMinion(minion, target);
						if (minion.Hp <= target.Angr)
							deathMinion.Add(minion);
						
					}

					foreach (Minion minion in deathMinion)
					{
						int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
						p.callKid(minion.handcard.card, pos, ownplay);
					}
				}
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 目标只能是敌方
            };
		}

	}
}

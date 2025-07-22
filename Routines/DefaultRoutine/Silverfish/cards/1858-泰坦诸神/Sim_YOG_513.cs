using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：4
	//Sinister Soulcage
	//邪恶魂笼
	//[x]Give a friendly Undead+2/+2. Spend 5 <b>Corpses</b>to summon a copy of it.
	//使一个友方亡灵获得+2/+2。消耗5份<b>残骸</b>，召唤一个它的复制。
	class Sim_YOG_513 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			// 如果目标是友方亡灵
			if (target != null && target.own &&  (CardDB.Race)target.handcard.card.race == CardDB.Race.UNDEAD)
			{
				// 增加2点攻击力和2点生命值
				p.minionGetBuffed(target, 2, 2);
				if (p.getCorpseCount() >= 5)
				{
					p.corpseConsumption(5);
					int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
					if (pos < 7)
					{
						p.callKid(target.handcard.card, target.zonepos, ownplay);
						List<Minion> minions = ownplay ? p.ownMinions : p.enemyMinions;
						minions[target.zonepos - 1].setMinionToMinion(target);
					}
				}
			}
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 11), // 目标只能是亡灵
            };
		}

	}
}

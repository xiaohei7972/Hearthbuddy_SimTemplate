using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：2
	//Blood Tap
	//活力分流
	//Give all minions in your hand +1/+1.Spend 2 <b>Corpses</b> to give them +1/+1 more.
	//使你手牌中的所有随从牌获得+1/+1。消耗2份<b>残骸</b>，再获得+1/+1。
	class Sim_RLK_712 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (ownplay)
			{
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if (hc.card.type == CardDB.cardtype.MOB)
					{
						hc.addattack++;
						hc.addHp++;
						p.anzOwnExtraAngrHp += 2;
					}
				}

				if (p.getCorpseCount() >= 2)
				{
					p.corpseConsumption(2);
					foreach (Handmanager.Handcard hc in p.owncards)
					{
						if (hc.card.type == CardDB.cardtype.MOB)
						{
							hc.addattack++;
							hc.addHp++;
							p.anzOwnExtraAngrHp += 2;
						}
					}
				}
			}

		}

	}
}

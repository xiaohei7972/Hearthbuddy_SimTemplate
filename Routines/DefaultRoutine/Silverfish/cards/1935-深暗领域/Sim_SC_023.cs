using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 术士 费用：2 攻击力：1 生命值：6
	//Spine Crawler
	//脊针爬虫
	//[x]<b>Taunt</b>. Can't attack.Has +3 Attack if youcontrol a location.
	//<b>嘲讽</b>。无法攻击。如果你控制着地标，则拥有+3攻击力。
	class Sim_SC_023 : SimTemplate
	{
		//还需要完善SimTemplate,在添加个随从的onCardPlay
		public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
		{
			if (triggerEffectMinion.own)
			{
				// 默认场面没有地标
				bool noLocation = true;
				foreach (Minion minion in p.ownMinions)
				{
					// 检测有地标
					if (minion.handcard.card.type == CardDB.cardtype.LOCATION)
					{
						noLocation = false;
						break;
					}
				}

				if (summonedMinion.handcard.card.type == CardDB.cardtype.LOCATION && !noLocation)
				{
					p.minionGetBuffed(triggerEffectMinion, 3, 0);
				}
			}
		}

		public override void onMinionDiedTrigger(Playfield p, Minion triggerEffectMinion, Minion diedMinion)
		{
			if (triggerEffectMinion.own)
			{
				// 默认场面没有地标
				bool noLocation = true;
				foreach (Minion minion in p.ownMinions)
				{
					// 检测有地标
					if (minion.handcard.card.type == CardDB.cardtype.LOCATION)
					{
						noLocation = false;
						break;
					}
				}
				if (diedMinion.handcard.card.type == CardDB.cardtype.LOCATION && noLocation)
				{
					p.minionGetBuffed(triggerEffectMinion, -3, 0);
				}
			}
		}


	}
}

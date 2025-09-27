using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：2
	//Abyssal Curse
	//深渊诅咒
	//[x]At the start of your turn,take {0} damage. Each Curseis worse than the last.<i>({1} |4(turn,turns) remaining).</i>
	//在你的回合开始时，受到{0}点伤害。每一次诅咒都会比上一次更严重。<i>（还剩{1}回合。）</i>
	class Sim_TSC_955t : SimTemplate
	{
		public override void onTurnStartTrigger(Playfield p, Handmanager.Handcard hc, bool turnStartOfOwner)
		{
			if (turnStartOfOwner)
			{
				p.minionGetDamageOrHeal(turnStartOfOwner ? p.ownHero : p.enemyHero, hc.card.TAG_SCRIPT_DATA_NUM_1, true);
			}
		}

        public override void onTurnEndsTrigger(Playfield p, Handmanager.Handcard hc, bool turnEndOfOwner)
        {
			if (turnEndOfOwner)
			{
				if (hc.card.TAG_SCRIPT_DATA_NUM_2 == 0)
				{
					p.removeCard(hc);
				}
			}
        }
		
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_076 : SimTemplate //* 莫尔杉哨所 Mor'shan Watch Post
	{
		//[x]Can't attack. After youropponent plays a minion,_summon a 2/2 Grunt.
		//无法攻击。在你的对手使用一张随从牌后，召唤一个2/2的步兵。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_352t);
		
		public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
		{
			if (triggerEffectMinion.own != summonedMinion.own )
			{
				int pos = triggerEffectMinion.zonepos;
                p.callKid(kid, pos, triggerEffectMinion.own);
			}
		}
	}
}

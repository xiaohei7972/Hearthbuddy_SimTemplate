using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：7
	//Story of Umbra
	//安布拉的故事
	//[x]<b>Discover</b> a <b>Deathrattle</b>minion that costs (5) ormore. Summon it andtrigger its <b>Deathrattle</b>.
	//<b>发现</b>一个法力值消耗大于或等于（5）点的<b>亡语</b>随从，召唤该随从并触发其<b>亡语</b>。
	class Sim_DINO_415 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			CardDB.Card selectedCard = CardDB.Instance.getCardDataFromID(Hrtprozis.Instance.enchs.LastOrDefault());
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			if (pos < 7)
			{
				p.callKid(selectedCard, pos, ownplay);
				Minion minion = ownplay ? p.ownMinions[Math.Max(0,pos - 1)] : p.enemyMinions[Math.Max(0,pos - 1)];
				minion.handcard.card.sim_card.onDeathrattle(p, minion);
			}

		}

	}
}

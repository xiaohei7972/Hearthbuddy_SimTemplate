using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace HREngine.Bots
{
	//法术 圣骑士 费用：8
	//Hero's Welcome
	//英雄欢迎仪式
	//<b>Discover</b> a <b>Legendary</b> minion to summon. Set its stats to 10/10.
	//<b>发现</b>并召唤一个<b>传说</b>随从，将其属性值变为10/10。
	class Sim_DINO_424 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			CardDB.Card selectedCard = CardDB.Instance.getCardDataFromID(Hrtprozis.Instance.enchs.LastOrDefault());
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(selectedCard, pos, ownplay);
		}

	}
}

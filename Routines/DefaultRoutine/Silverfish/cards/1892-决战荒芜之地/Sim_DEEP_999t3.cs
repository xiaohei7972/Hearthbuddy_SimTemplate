using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：3
	//World Pillar Fragment
	//世界之柱碎片
	//<b>Discover</b> an Elemental to summon. Add the others to your hand.
	//<b>发现</b>一个元素并召唤，并将其余的置入你的手牌。
	class Sim_DEEP_999t3 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_283);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
			p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
		}
		
	}
}

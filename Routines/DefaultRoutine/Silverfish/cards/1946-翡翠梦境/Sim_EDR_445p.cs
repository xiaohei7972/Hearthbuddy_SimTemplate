using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 圣骑士 费用：1
	//Blessing of the Dragon
	//巨龙的祝福
	//[x]Shuffle two EmeraldPortals into your deck.<i>(Your Portals summon<b>@</b>-Cost Dragons.)</i>
	//将两张翡翠传送门洗入你的牌库。<i>（你的传送门会召唤法力值消耗为<b>@</b>的龙。）</i>
	class Sim_EDR_445p : SimTemplate
	{
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_445pt3);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.AddToDeck(card);
			p.AddToDeck(card);
		}

	}
}

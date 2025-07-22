using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄技能 牧师 费用：1
	//Way of the Shell
	//隐甲之道
	//Draw 2 cardsthat didn't startin your deck.
	//抽两张你套牌之外的牌。
	class Sim_TLC_513hp : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}

	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：2
	//Quality Assurance
	//质量保证
	//Draw 2 <b>Taunt</b> minions.
	//抽两张<b>嘲讽</b>随从牌。
	class Sim_TOY_605 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
		}
		
	}
}

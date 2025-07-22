using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//山谷植根 
	//抽一张牌。 
	class Sim_AV_205pb : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
		}

	}
}
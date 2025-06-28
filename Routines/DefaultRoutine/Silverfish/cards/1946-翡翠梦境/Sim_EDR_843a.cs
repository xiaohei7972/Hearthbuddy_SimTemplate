using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Aid of the Forest
	//森林之援
	//Draw a spell.
	//抽一张法术牌。
	class Sim_EDR_843a : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			// 抽法术
			List<CardDB.cardIDEnum> spell = p.CheckTurnDeckForType(CardDB.cardtype.SPELL, 1);
			CardDB.cardIDEnum spellcard = spell.Count == 1 ? spell[0] : CardDB.cardIDEnum.None;
			p.drawACard(spellcard, ownplay);
		}

	}
}

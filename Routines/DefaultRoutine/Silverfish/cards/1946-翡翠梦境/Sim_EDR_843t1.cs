using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Reforestation
	//森林再生
	//Draw a spell and a minion.
	//抽一张法术牌和一张随从牌。
	class Sim_EDR_843t1 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			// 抽法术
			List<CardDB.cardIDEnum> spell = p.CheckTurnDeckForType(CardDB.cardtype.SPELL, 1);
			CardDB.cardIDEnum spellcard = spell.Count == 1 ? spell[0] : CardDB.cardIDEnum.None;
			p.drawACard(spellcard, ownplay);
			// 抽随从
			List<CardDB.cardIDEnum> mob = p.CheckTurnDeckForType(CardDB.cardtype.MOB, 1);
			CardDB.cardIDEnum mobcard = mob.Count == 1 ? mob[0] : CardDB.cardIDEnum.None;
			p.drawACard(mobcard, ownplay);

		}

	}
}

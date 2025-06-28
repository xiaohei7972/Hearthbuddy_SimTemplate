using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：2
	//Reforestation
	//森林再生
	//[x]<b>Choose One -</b> Draw aspell; or Draw a minion.<i>(Hold this for @ |4(turn, turns)to do_both!)</i>
	//<b>抉择：</b>抽一张法术牌；或者抽一张随从牌。<i>（本牌在你手中@回合即可同时拥有两种效果！）</i>
	class Sim_EDR_843 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				// 抽法术
				List<CardDB.cardIDEnum> spell = p.CheckTurnDeckForType(CardDB.cardtype.SPELL, 1);
				CardDB.cardIDEnum spellcard = spell.Count == 1 ? spell[0] : CardDB.cardIDEnum.None;
				p.drawACard(spellcard, ownplay);
			}
			if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
			{
				// 抽随从
				List<CardDB.cardIDEnum> mob = p.CheckTurnDeckForType(CardDB.cardtype.MOB, 1);
				CardDB.cardIDEnum mobcard = mob.Count == 1 ? mob[0] : CardDB.cardIDEnum.None;
				p.drawACard(mobcard, ownplay);
			}
		}

	}
}

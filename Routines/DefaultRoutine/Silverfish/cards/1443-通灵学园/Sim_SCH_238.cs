using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_238 : SimTemplate //* 收割之镰 Reaper's Scythe
	{
		//[x]<b>Spellburst</b>: Alsodamages adjacentminions this turn.
		//<b>法术迸发：</b>在本回合中同时对攻击目标相邻的随从造成伤害。
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_238);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
		{
			if (m.own == ownplay && m.Spellburst && hc.card.type == CardDB.cardtype.SPELL)
			{
				m.Spellburst = false;

			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_121 : SimTemplate //* 被禁锢的甘尔葛 Imprisoned Gan'arg
	{
		//<b>Dormant</b> for 2 turns.When this awakens,equip a 3/2 Axe.
		//<b>休眠</b>两回合。唤醒时，装备一把3/2的斧子。
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_106);
		public override void onDormantEndsTrigger(Playfield p, Minion m)
		{
			p.equipWeapon(weapon, m.own);
		}

	}
}

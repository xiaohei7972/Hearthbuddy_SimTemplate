using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_082 : SimTemplate //* 黏指狗头人 Kobold Stickyfinger
	{
		//<b>Battlecry:</b> Steal your opponent's weapon.
		//<b>战吼：</b>偷取对手的武器。
		CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_080);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.lowerWeaponDurability(1000, !own.own);
			p.equipWeapon(w, true);
		}
	}
}
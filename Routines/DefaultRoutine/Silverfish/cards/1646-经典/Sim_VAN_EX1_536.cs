using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_536 : SimTemplate //* 鹰角弓 Eaglehorn Bow
	{
		//[x]Whenever a friendly<b>Secret</b> is revealed,gain +1 Durability.
		//每当有一张你的<b>奥秘</b>牌被揭示时，便获得+1耐久度。

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_EX1_536);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(weapon, ownplay);
		}

	}
}
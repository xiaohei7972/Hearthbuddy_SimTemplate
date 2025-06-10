using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_567 : SimTemplate //* 毁灭之锤 Doomhammer
	{
		//<b>Windfury, Overload:</b> (2)
		//<b>风怒，过载：</b>（2）
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_567);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(card, ownplay);
            if (ownplay) p.ueberladung += 2;
		}

	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_247 : SimTemplate //* 雷铸战斧 Stormforged Axe
	{
		//<b>Overload:</b> (1)
		//<b>过载：</b>（1）
        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_EX1_247);
        //
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(card,ownplay);
            if (ownplay) p.ueberladung ++;
        }

	}
}
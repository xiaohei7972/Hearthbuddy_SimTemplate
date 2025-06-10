using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_112 : SimTemplate //奥金斧
	{

        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_CS2_112);
        //
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(card,ownplay);
        }

	}
}
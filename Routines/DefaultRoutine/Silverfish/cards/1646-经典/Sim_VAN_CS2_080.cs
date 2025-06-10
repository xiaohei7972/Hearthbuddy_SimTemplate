using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_080 : SimTemplate //刺客之刃 Assassin's Blade
	{

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_CS2_080);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
        }

	}
}
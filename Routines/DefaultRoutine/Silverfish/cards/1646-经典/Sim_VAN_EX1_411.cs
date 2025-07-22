using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_411 : SimTemplate //* 血吼 Gorehowl
	{
		//Attacking a minion costs 1 Attack instead of 1 Durability.
		//攻击随从不会消耗耐久度，改为降低1点攻击力。
        CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_411);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(wcard, ownplay);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_521 : SimTemplate //* N'Zoth's First Mate
	{
		//Battlecry: Equip a 1/3 Rusty Hook.

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DMF_521t);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(w, own.own);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_042t : SimTemplate //* 电圆锯 Gearblade
//
// 
	{


        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BOT_042t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
        }

	}
}
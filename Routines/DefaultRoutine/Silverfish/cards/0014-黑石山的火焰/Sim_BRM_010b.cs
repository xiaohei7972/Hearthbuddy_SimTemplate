using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRM_010b : SimTemplate //* 火鹰形态 Fire Hawk Form
//
// 
	{
		

        CardDB.Card hawk = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BRM_010t2);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionTransform(target, hawk);
        }
	}
}
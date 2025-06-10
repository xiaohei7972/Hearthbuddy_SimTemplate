using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_058 : SimTemplate //* 锈蚀铁钩 Rusty Hook
//
// 
	{
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_058);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active56 : SimTemplate //* 许愿术 Wish
	{
		//Fill your board with <b>Legendary</b> minions. Fully heal your hero.
		//召唤数个<b>传说</b>随从，直到你的随从数量达到上限。为你的英雄恢复所有生命值。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}

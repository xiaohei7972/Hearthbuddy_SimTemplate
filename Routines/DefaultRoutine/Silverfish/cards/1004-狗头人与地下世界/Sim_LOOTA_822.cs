using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOTA_822 : SimTemplate //* 燃烧权杖 Rod of Roasting
	{
		//Cast 'Pyroblast' randomly until a_hero_dies.
		//随机施放炎爆术直到一方英雄死亡。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_541 : SimTemplate //* 符文宝珠 Runed Orb
	{
		//Deal $2 damage. <b>Discover</b> a spell.
		//造成$2点伤害。<b>发现</b>一张法术牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}

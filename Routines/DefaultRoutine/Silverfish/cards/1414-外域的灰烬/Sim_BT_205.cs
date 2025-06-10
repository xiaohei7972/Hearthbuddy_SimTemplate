using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_205 : SimTemplate //* 废铁射击 Scrap Shot
	{
		//Deal $3 damage.Give a random Beast in_your hand +3/+3.
		//造成$3点伤害。随机使你手牌中的一张野兽牌获得+3/+3。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}

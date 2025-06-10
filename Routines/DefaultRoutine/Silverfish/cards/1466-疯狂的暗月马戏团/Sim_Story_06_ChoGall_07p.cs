using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_06_ChoGall_07p : SimTemplate //* 暗影箭雨 Shadow Volley
	{
		//[x]<b>Passive Hero Power</b>Deal 2 damage to the enemyhero and discard the lowestcost card in their hand.
		//<b>被动英雄技能</b>对敌方英雄造成2点伤害，并弃掉其手牌中法力值消耗最低的牌。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 2),
            };
        }
	}
}

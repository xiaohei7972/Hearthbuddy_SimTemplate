using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_68p : SimTemplate //* “高级”物种 "Upgraded" Fauna
	{
		//[x]<b>Hero Power</b>Deal 1 damage to anenemy minion for eachBeast you control.
		//<b>英雄技能</b>对一个敌方随从造成等同于你控制的野兽数量的伤害。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINIMUM_ENEMY_MINIONS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_Story_04_HolyWrath : SimTemplate //* 神圣愤怒 Holy Wrath
	{
		//Draw a card and deal_damage equal to_its Cost.
		//抽一张牌，并造成等同于其法力值消耗的伤害。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}

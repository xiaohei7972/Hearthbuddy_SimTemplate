using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_561 : SimTemplate //* 阿莱克丝塔萨 Alexstrasza
	{
		//<b>Battlecry:</b> Set a hero's remaining Health to 15.
		//<b>战吼：</b>将一方英雄的剩余生命值变为15。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            target.Hp = 15;
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_HERO_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
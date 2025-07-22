using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_403 : SimTemplate //* 赛拉辛疾行 cerathinefleetrunner
	{
		//<b>战吼：</b>将你手牌和牌库中的随从牌替换成另一职业的。这些牌的法力值消耗减少（2）点。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards) hc.manacost-= 2;
            }
        }
		
	}
}

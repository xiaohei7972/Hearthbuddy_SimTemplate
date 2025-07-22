using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_710 : SimTemplate //* 侦察 reconnaissance
	{
		//<b>发现</b>一张另一职业的<b>亡语</b>随从牌， 其法力值消耗减少（2）点。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.unknown, own.own, true);
        }
		
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_407 : SimTemplate //* 茶水小弟 Waterboy
//<b>Battlecry:</b> Your next Hero Power this turn costs (0).
//<b>战吼：</b>在本回合中，你的下一个英雄技能的法力值消耗为（0）点。 
    {
        
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own) p.ownHeroPowerCostLessOnce -= 2;
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
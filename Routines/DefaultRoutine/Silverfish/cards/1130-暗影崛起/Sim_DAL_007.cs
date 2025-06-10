using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_007 : SimTemplate //* 拉法姆的阴谋 Rafaam's Scheme
	{
		//Summon @ 1/1 |4(Imp, Imps). <i>(Upgrades each turn!)</i>
		//召唤@个1/1的小鬼。<i>（每回合都会升级！）</i>
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}

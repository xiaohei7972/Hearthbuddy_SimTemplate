using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_011 : SimTemplate //* 拉祖尔的阴谋 Lazul's Scheme
	{
		//Reduce the Attack of an enemy minion by@ until your next turn. <i>(Upgrades each turn!)</i>
		//直到你的下个回合，使一个敌方随从的攻击力降低@点。<i>（每回合都会升级！）</i>
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
	}
}

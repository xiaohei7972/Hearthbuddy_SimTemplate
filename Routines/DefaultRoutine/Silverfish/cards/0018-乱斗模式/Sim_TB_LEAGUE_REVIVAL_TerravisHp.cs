using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_LEAGUE_REVIVAL_TerravisHp : SimTemplate //* 装备精良 Well Equipped
//<b>Hero Power</b>Equip a random weapon, if you already have one give it +1 Attack.
//<b>英雄技能</b>随机装备一把武器。如果你已经装备了武器，则使其获得+1攻击力。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}

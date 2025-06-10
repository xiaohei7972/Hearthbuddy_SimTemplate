using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TB_MechWar_Boss1_HeroPower : SimTemplate //* 吵不死你 Hello! Hello! Hello!
//<b>Hero Power</b>Give your lowest attack minion <b>Divine Shield</b> and <b>Taunt</b>.
//<b>英雄技能</b>使你攻击力最低的随从获得<b>圣盾</b>和<b>嘲讽</b>。 
	{
		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}

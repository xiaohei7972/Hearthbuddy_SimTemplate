using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_702 : SimTemplate //* 灰舌杀手 Ashtongue Slayer
	{
		//<b>Battlecry:</b> Give a <b><b>Stealth</b>ed</b> minion +3 Attack and <b>Immune</b> this turn.
		//<b>战吼：</b>在本回合中，使一个<b>潜行</b>的随从获得+3攻击力和<b>免疫</b>。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_STEALTHED_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}

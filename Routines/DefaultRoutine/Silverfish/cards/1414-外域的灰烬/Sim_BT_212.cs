using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_212 : SimTemplate //* 莫克纳萨将狮 Mok'Nathal Lion
	{
		//<b>Rush</b>. <b>Battlecry:</b> Choose a friendly minion. Gain a copy of its <b>Deathrattle</b>.
		//<b>突袭，战吼：</b>选择一个友方随从，获得其<b>亡语</b>的复制。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
	}
}

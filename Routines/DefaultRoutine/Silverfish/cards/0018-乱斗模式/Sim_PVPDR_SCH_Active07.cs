using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_PVPDR_SCH_Active07 : SimTemplate //* 裂解魔杖 Wand of Disintegration
	{
		//<b>Silence</b> and destroy all enemy minions.
		//<b>沉默</b>并消灭所有敌方随从。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}

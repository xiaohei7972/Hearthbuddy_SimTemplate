using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_269 : SimTemplate //* 卑劣的回收者 Wretched Reclaimer
	{
		//[x]<b>Battlecry:</b> Destroy a friendlyminion, then return it to lifewith full Health.
		//<b>战吼：</b>消灭一个友方随从，然后将其复活，并具有所有生命值。
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}

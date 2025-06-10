using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_855 : SimTemplate //* 迪菲亚清道夫 Defias Cleaner
//<b>Battlecry:</b> <b>Silence</b> a minion with <b>Deathrattle</b>.
//<b>战吼：</b><b>沉默</b>一个具有<b>亡语</b>的随从。 
	{
		
        
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null) p.minionGetSilenced(target);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_DEATHRATTLE),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}
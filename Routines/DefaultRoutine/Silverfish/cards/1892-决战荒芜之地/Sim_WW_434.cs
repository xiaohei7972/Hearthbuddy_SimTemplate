
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_WW_434 : SimTemplate // 日斑巨龙
    {
        // 造成6点伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int dmg = 6;
            p.minionGetDamageOrHeal(target, dmg);
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
            };
        }

        
        
    }
}

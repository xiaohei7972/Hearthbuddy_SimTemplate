using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_512 : SimTemplate //* 调皮的噬踝者 Cheaty Anklebiter
//<b>Lifesteal</b><b>Battlecry:</b> Deal 1 damage.
//<b>吸血</b><b>战吼：</b>造成1点伤害。 
    {
        
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int dmg = 1;
            p.minionGetDamageOrHeal(target, dmg);
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
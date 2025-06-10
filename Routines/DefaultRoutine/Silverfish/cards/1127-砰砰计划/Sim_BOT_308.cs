using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_308 : SimTemplate //* 弹簧火箭犬 Spring Rocket
//<b>Battlecry:</b> Deal 2 damage.
//<b>战吼：</b>造成2点伤害。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int dmg = 2;
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
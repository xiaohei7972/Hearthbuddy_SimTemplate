using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_CS2_141 : SimTemplate //* 铁炉堡火枪手 Ironforge Rifleman
	{
		//<b>Battlecry:</b> Deal 1 damage.
		//<b>战吼：</b>造成1点伤害。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int dmg = 1;
            p.minionGetDamageOrHeal(target, dmg);
		}



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
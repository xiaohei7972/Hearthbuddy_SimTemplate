using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_603 : SimTemplate //* 严酷的监工 Cruel Taskmaster
	{
		//<b>Battlecry:</b> Deal 1 damage to a minion and give it +2_Attack.
		//<b>战吼：</b>对一个随从造成1点伤害，并使其获得+2攻击力。
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, 1);
                p.minionGetBuffed(target, 2, 0);
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_847 : SimTemplate //* 火焰使者 Blazecaller
//<b>Battlecry:</b> If you played an_Elemental last turn, deal 5 damage.
//<b>战吼：</b>如果你在上个回合使用过元素牌，则造成5点伤害。 
	{
		

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.anzOwnElementalsLastTurn > 0 && target != null) p.minionGetDamageOrHeal(target, 5);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN),
            };
        }
	}
}
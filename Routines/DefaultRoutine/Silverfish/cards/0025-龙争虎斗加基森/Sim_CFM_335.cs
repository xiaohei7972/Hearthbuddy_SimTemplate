using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_335 : SimTemplate //* 驮运科多兽 Dispatch Kodo
//<b>Battlecry:</b> Deal damage equal to this minion's Attack.
//<b>战吼：</b>造成等同于该随从攻击力的伤害。 
	{
        

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null) p.minionGetDamageOrHeal(target, m.Angr);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
	}
}
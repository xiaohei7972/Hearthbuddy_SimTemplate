using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_067 : SimTemplate //* 猢狲医者 Hozen Healer
//<b>Battlecry</b>: Restore a minion to full Health.
//<b>战吼：</b>为一个随从恢复所有生命值。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null)
            {
                int heal = (m.own) ? p.getMinionHeal(target.maxHp - target.Hp) : p.getEnemyMinionHeal(target.maxHp - target.Hp);
                p.minionGetDamageOrHeal(target, -heal, true);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
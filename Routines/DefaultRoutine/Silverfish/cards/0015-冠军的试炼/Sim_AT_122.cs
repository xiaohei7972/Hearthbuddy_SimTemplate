using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_122 : SimTemplate //* 穿刺者戈莫克 Gormok the Impaler
//<b>Battlecry:</b> If you have at least 4 other minions, deal 4 damage.
//<b>战吼：</b>如果你拥有至少四个其他随从，则造成4点伤害。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null) p.minionGetDamageOrHeal(target, 4);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS, 4),
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_061 : SimTemplate //* 锦鱼人水语者 Jinyu Waterspeaker
//[x]<b>Battlecry:</b> Restore #6 Health.<b>Overload:</b> (1)
//<b>战吼：</b>恢复#6点生命值。<b>过载：</b>（1） 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int heal = (m.own) ? p.getMinionHeal(6) : p.getEnemyMinionHeal(6);

            p.minionGetDamageOrHeal(target, -heal);
            if (m.own) p.ueberladung++;
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
    }
}
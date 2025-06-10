using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NEW1_008 : SimTemplate //* 知识古树 Ancient of Lore
	{
		//<b>Choose One -</b> Draw 2 cards; or Restore #5 Health.
		//<b>抉择：</b>抽两张牌；或者恢复#5点生命值。

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (choice == 2 || (target != null && p.ownFandralStaghelm > 0 && own.own))
            {
                int heal = (own.own) ? p.getMinionHeal(5) : p.getEnemyMinionHeal(5);
                p.minionGetDamageOrHeal(target, -heal);
            }
            
            if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
            {
                p.drawACard(CardDB.cardIDEnum.None, own.own);
                p.drawACard(CardDB.cardIDEnum.None, own.own);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}

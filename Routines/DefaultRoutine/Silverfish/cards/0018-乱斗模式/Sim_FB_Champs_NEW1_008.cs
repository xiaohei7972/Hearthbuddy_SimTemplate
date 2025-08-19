using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 知识古树 Ancient of Lore
    //<b>Choose One -</b> Draw 2 cards; or Restore #5 Health.
    //<b>抉择：</b>抽两张牌；或者恢复#5点生命值。 
    class Sim_FB_Champs_NEW1_008 : SimTemplate
    {
        public override void onCardPlay(Playfield p, Minion own, Minion target, int choice)
        {

            if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
            {
                p.drawACard(CardDB.cardIDEnum.None, own.own);
                p.drawACard(CardDB.cardIDEnum.None, own.own);
            }

            if (choice == 2 || (p.ownFandralStaghelm > 0 && own.own))
            {
                if (target != null)
                {
                    int heal = (own.own) ? p.getMinionHeal(5) : p.getEnemyMinionHeal(5);
                    p.minionGetDamageOrHeal(target, -heal);
                }
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

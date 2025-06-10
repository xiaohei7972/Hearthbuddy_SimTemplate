using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_832p: SimTemplate //* 瘟疫领主 Plague Lord
//[x]<b>Hero Power</b><b>Choose One -</b> +3 Attackthis turn; or Gain 3 Armor.
//<b>英雄技能</b><b>抉择：</b>在本回合中获得+3攻击力；或者获得3点护甲值。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                if (ownplay) p.minionGetTempBuff(p.ownHero, 3, 0);
                else p.minionGetTempBuff(p.enemyHero, 3, 0);
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                if (ownplay) p.minionGetArmor(p.ownHero, 3);
                else p.minionGetArmor(p.enemyHero, 3);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
    }
}
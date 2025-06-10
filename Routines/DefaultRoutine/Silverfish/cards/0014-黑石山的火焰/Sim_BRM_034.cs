using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BRM_034 : SimTemplate //* 黑翼腐蚀者 Blackwing Corruptor
//<b>Battlecry:</b> If you're holding a Dragon, deal 3 damage.
//<b>战吼：</b>如果你的手牌中有龙牌，则造成3点伤害。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null) p.minionGetDamageOrHeal(target, 3);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND),
            };
        }
    }
}
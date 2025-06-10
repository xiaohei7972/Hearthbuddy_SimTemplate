using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_910: SimTemplate //* 鬼灵匪贼 Spectral Pillager
//[x]<b>Combo:</b> Deal damage equalto the number of other cardsyou've played this turn.
//<b>连击：</b>造成伤害，数值等同于在本回合中你使用的其他牌的数量。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (p.cardsPlayedThisTurn > 0)
                {
                    if (target != null) p.minionGetDamageOrHeal(target, p.cardsPlayedThisTurn);
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_FOR_COMBO),
            };
        }
    }
}
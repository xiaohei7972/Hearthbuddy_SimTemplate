using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_827p: SimTemplate //* 死亡暗影 Death's Shadow
//<b>Passive Hero Power</b>During your turn, add a 'Shadow Reflection' to your hand.
//<b>被动英雄技能</b>在你的回合时，将一张“暗影映像”置入你的手牌。 
    {
        

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            
            bool found = false;
            if (turnStartOfOwner)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.nameEN == CardDB.cardNameEN.shadowreflection)
                    {
                        found = true;
                        break;
                    }
                }
            }
            if (!found) p.drawACard(CardDB.cardNameEN.shadowreflection, turnStartOfOwner, true);
        }
    }
}
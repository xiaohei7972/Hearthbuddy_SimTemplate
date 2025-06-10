using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_110 : SimTemplate //* 远古暗影 Ancient Shade
//<b>Battlecry:</b> Shuffle an 'Ancient Curse' into your deck that deals 7 damage to you when drawn.
//<b>战吼：</b>将一张“远古诅咒”牌洗入你的牌库。当你抽到该牌，便会受到7点伤害。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (!p.ownHero.immune)
                {
                    p.ownDeckSize++;

                    if (p.ownHero.Hp < 8) p.evaluatePenality += 7;
                    else if (p.ownHero.Hp < 14) p.evaluatePenality += 4;
                    else if (p.ownHero.Hp < 21) p.evaluatePenality += 2;

                    if (p.ownDeckSize <= 6) p.minionGetDamageOrHeal(p.ownHero, Math.Min(7, p.ownHero.Hp - 1), true);
                    else if (p.ownDeckSize <= 16) p.minionGetDamageOrHeal(p.ownHero, Math.Min(3, p.ownHero.Hp - 1), true);
                    else if (p.ownDeckSize <= 26) p.minionGetDamageOrHeal(p.ownHero, Math.Min(1, p.ownHero.Hp - 1), true);
                }
            }
            else
            {
                p.enemyDeckSize++;
            }
        }
    }
}
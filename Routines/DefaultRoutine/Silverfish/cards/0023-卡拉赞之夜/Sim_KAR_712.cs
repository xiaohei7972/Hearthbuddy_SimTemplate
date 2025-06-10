using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_712 : SimTemplate //* 紫罗兰法师 Violet Illusionist
//During your turn, your hero is <b>Immune</b>.
//在你的回合时，你的英雄会获得<b>免疫</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own) p.ownHero.immune = true;
            else p.enemyHero.immune = true;
        }

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
                if (turnStartOfOwner) p.ownHero.immune = true;
                else p.enemyHero.immune = true;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_101t : SimTemplate //* 白银之手新兵 Silver Hand Recruit
	{
		//
		// FIX 敌方的白银之手新兵自带5费后每回合+2+2, 前期 +1 攻击
		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (!turnStartOfOwner && triggerEffectMinion.own == turnStartOfOwner)
            {
                // 对战奇数骑
                if( p.enemyHeroAblility.card.nameEN == CardDB.cardNameEN.silverhand ){
                    if(p.enemyMaxMana >= 5){
                        p.minionGetBuffed(triggerEffectMinion, 2, 2);
                    }else {
                        p.minionGetBuffed(triggerEffectMinion, 1, 0);
                    }
                }
            }
        }
		
	}
}

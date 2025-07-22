using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_078 : SimTemplate //* 深潜炸弹 Depth Charge
	{
        //At the start of your turn, deal 5 damage to ALL minions.
        //在你的回合开始时，对所有随从造成5点伤害。
        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (triggerEffectMinion.own == turnStartOfOwner)
            {
               
                    p.allMinionsGetDamage(5);
               
            }
        }

    }
}
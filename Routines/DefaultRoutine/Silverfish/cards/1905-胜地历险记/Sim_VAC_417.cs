using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：6
	//Sensory Deprivation
	//感官侵夺
	//Summon a copy of an enemy minion. If you have 20 or less Health, destroy the original.
	//召唤一个敌方随从的一个复制。如果你的生命值小于或等于20点，消灭本体。
	class Sim_VAC_417 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                // 召唤一个敌方随从的复制
                int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(target.handcard.card, pos, ownplay, false);

                // 如果玩家的生命值小于或等于20点，消灭目标敌方随从
                if ((ownplay && p.ownHero.Hp <= 20) || (!ownplay && p.enemyHero.Hp <= 20))
                {
                    p.minionGetDestroyed(target);
                }
            }
        }
    }
}

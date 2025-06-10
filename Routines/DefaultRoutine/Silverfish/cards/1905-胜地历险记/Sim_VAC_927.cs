using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：2 攻击力：2 生命值：2
	//Adrenaline Fiend
	//狂飙邪魔
	//After a friendly Pirate attacks, give your hero+1 Attack this turn.
	//在一个友方海盗攻击后，使你的英雄在本回合中获得+1攻击力。
	class Sim_VAC_927 : SimTemplate
	{
        public override void onMinionGotDmgTrigger(Playfield p, Minion triggerEffectMinion, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            // 如果触发效果的随从是友方并且是海盗
            if (triggerEffectMinion.own && triggerEffectMinion.handcard.card.race == CardDB.Race.PIRATE)
            {
                // 增加英雄的攻击力（仅限本回合）
                p.minionGetTempBuff(p.ownHero, 1, 0);
            }
        }
    }
}

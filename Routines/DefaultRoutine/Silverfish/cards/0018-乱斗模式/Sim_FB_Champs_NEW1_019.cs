using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：3 生命值：2
	//Knife Juggler
	//飞刀杂耍者
	//[x]After you summon aminion, deal 1 damageto a random enemy.
	//在你召唤一个随从后，随机对一个敌人造成1点伤害。
	class Sim_FB_Champs_NEW1_019 : SimTemplate
	{
		public override void onMinionWasSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
            if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own)
            {
                List<Minion> temp = (triggerEffectMinion.own) ? p.enemyMinions : p.ownMinions;

                if (temp.Count >= 1)
                {
                    Minion enemy = null;
                    bool found = false;
                    foreach (Minion m in temp)
                    {
                        if (m.untouchable) continue;
                        enemy = m;
                        found = true;
                        break;
                    }

                    if (found)
                    {
                        p.minionGetDamageOrHeal(enemy, 1);
                    }
                    else
                    {
                        p.minionGetDamageOrHeal(triggerEffectMinion.own ? p.enemyHero : p.ownHero, 1);
                    }

                }
                else
                {
                    p.minionGetDamageOrHeal(triggerEffectMinion.own ? p.enemyHero : p.ownHero, 1);
                }

                // triggerEffectMinion.stealth = false;
            }
        }
		
	}
}

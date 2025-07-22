using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：7 攻击力：5 生命值：8
	//All Terrain Voidhound
	//全地形虚空猎犬
	//Whenever this attacks, give your hero +5 Attack this turn.
	//每当本随从攻击时，使你的英雄在本回合中获得+5攻击力。
	class Sim_VAC_930 : SimTemplate
	{
        public override void onMinionGotDmgTrigger(Playfield p, Minion triggerEffectMinion, int anzOwnMinionsGotDmg, int anzEnemyMinionsGotDmg, int anzOwnHeroGotDmg, int anzEnemyHeroGotDmg)
        {
            // 检查触发效果的随从是否是 "全地形虚空猎犬" 且是己方的随从
            if (triggerEffectMinion.own && triggerEffectMinion.name == CardDB.cardNameEN.allterrainvoidhound)
            {
                // 增加英雄的攻击力（仅限本回合）
                p.minionGetTempBuff(p.ownHero, 5, 0);
            }
        }
    }
}

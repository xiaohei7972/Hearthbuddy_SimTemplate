using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：3 攻击力：4 生命值：3
	//Mecha-Shark
	//机械鲨鱼
	//[x]After you summon a Mech,deal 3 damage randomly_split among all enemies.
	//在你召唤一个机械后，造成3点伤害，随机分配到所有敌人身上。
	class Sim_Story_11_MechaShark : SimTemplate
	{
		public override void onMinionIsSummoned(Playfield p, Minion triggerEffectMinion, Minion summonedMinion)
        {
			// 检查召唤的随从是否是机械
			if (triggerEffectMinion.entitiyID != summonedMinion.entitiyID && triggerEffectMinion.own == summonedMinion.own && RaceUtils.IsRaceOrAll(summonedMinion.handcard.card.race, CardDB.Race.MECHANICAL))
			{
				p.allCharsOfASideGetRandomDamage(!triggerEffectMinion.own, 3);
            }
        }
		
	}
}

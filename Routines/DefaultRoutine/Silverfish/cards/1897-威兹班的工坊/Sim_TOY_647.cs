using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 恶魔猎手 费用：8 攻击力：12 生命值：12
	//Magtheridon, Unreleased
	//玛瑟里顿（未发售版）
	//[x]<b>Dormant</b> for 2 turns.While <b>Dormant</b>, deal 3damage to all enemies atthe end of your turn.
	//<b>休眠</b>2回合。<b>休眠</b>状态下，在你的回合结束时，对所有敌人造成3点伤害。
	class Sim_TOY_647 : SimTemplate
	{
        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            // 只有在随从处于休眠状态并且是其所有者的回合结束时触发效果
            if (m.silenced == false && m.dormant > 0 && turnEndOfOwner == m.own)
            {
                // 对所有敌人造成3点伤害
                foreach (Minion enemy in p.enemyMinions)
                {
                    p.minionGetDamageOrHeal(enemy, 3);
                }
                p.minionGetDamageOrHeal(p.enemyHero, 3);
            }
        }


    }
}

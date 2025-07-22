using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：4 攻击力：2 生命值：4
	//Darkthorn Quilter
	//黑棘针线师
	//[x]At the end of your turn,deal this minion's Attackdamage randomly split___among enemies.
	//在你的回合结束时，造成等同于本随从攻击力的伤害，随机分配到所有敌人身上。
	class Sim_TOY_824 : SimTemplate
	{

        public override void onTurnEndsTrigger(Playfield p, Minion m, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == m.own)
            {
                // 计算随从的攻击力
                int damage = m.Angr;

                // 对所有敌人随机分配伤害
                p.allCharsOfASideGetRandomDamage(!m.own, damage);
            }
        }

    }
}

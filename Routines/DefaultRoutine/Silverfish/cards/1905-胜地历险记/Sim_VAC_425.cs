using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 巫妖王 费用：4
	//Horizon's Edge
	//大地之末号
	//[x]Deal 3 damagerandomly split among allenemies. After a friendlyminion dies, reopen this.
	//造成3点伤害，随机分配到所有敌人身上。在一个友方随从死亡后，重新开启本地标。
	class Sim_VAC_425 : SimTemplate
	{
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            if(triggerMinion.handcard.card.CooldownTurn == 0) p.allCharsOfASideGetRandomDamage(false, 3);
        }
    }
}

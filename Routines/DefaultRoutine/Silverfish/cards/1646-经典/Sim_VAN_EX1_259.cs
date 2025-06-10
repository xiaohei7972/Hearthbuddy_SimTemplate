using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_259 : SimTemplate //* 闪电风暴 Lightning Storm
	{
		//Deal $2-$3 damage to all_enemy minions. <b>Overload:</b> (2)
		//对所有敌方随从造成$2到$3点伤害，<b>过载：</b>（2）
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
            if (ownplay) p.ueberladung += 2;
        }

    }
}

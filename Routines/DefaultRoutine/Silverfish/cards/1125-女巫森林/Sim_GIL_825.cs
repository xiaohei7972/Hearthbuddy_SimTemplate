using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_825 : SimTemplate //* 高弗雷勋爵 Lord Godfrey
//[x]<b>Battlecry:</b> Deal 2 damage toall other minions. If any die,repeat this <b>Battlecry</b>.
//<b>战吼：</b>对所有其他随从造成2点伤害。如果有随从死亡，则重复此<b>战吼</b>效果。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			int dmg = (m.own) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            int count = p.tempTrigger.ownMinionsDied + p.tempTrigger.enemyMinionsDied;
            int nextcount = 0;
            bool repeat;
            do
            {
                repeat = false;
                p.allMinionsGetDamage(dmg);
                nextcount = p.tempTrigger.ownMinionsDied + p.tempTrigger.enemyMinionsDied;
                if (nextcount > count) repeat = true;
                count = nextcount;
                if (count == (p.ownMinions.Count + p.enemyMinions.Count)) break;
            }
            while (repeat);
        }
    }
}
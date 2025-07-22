using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_801 : SimTemplate //* 筑巢双头鹏 Nesting Roc
//<b>Battlecry:</b> If you control at_least 2 other minions, gain <b>Taunt</b>.
//<b>战吼：</b>如果你控制至少两个其他随从，便获得<b>嘲讽</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int num = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;
			if (num > 1)
            {
                own.taunt = true;
                if (own.own) p.anzOwnTaunt++;
                else p.anzEnemyTaunt++;
            }
        }
    }
}
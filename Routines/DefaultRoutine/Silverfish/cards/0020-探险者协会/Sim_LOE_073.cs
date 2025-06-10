using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_073 : SimTemplate //* 石化魔暴龙 Fossilized Devilsaur
//<b>Battlecry:</b> If you control a Beast, gain <b>Taunt</b>.
//<b>战吼：</b>如果你控制一个野兽，便获得<b>嘲讽</b>。 
	{
		
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PET)
                {
					own.taunt = true;
                    if (own.own) p.anzOwnTaunt++;
                    else p.anzEnemyTaunt++;
                    break;
                }
            }
        }
    }
}
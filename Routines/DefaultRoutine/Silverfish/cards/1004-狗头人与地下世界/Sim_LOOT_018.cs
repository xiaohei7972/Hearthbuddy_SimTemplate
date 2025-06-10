using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_018 : SimTemplate //* 铁钩掠夺者 Hooked Reaver
//<b>Battlecry:</b> If you have 15 or_less Health, gain +3/+3_and <b>Taunt</b>.
//<b>战吼：</b>如果你的生命值小于或等于15点，则获得+3/+3和<b>嘲讽</b>。 
	{
		
	
        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int heroHealth = m.own ? p.ownHero.Hp : p.enemyHero.Hp;
			if(heroHealth <= 15) p.minionGetBuffed(m, 3, 3);
			m.taunt = true;
			p.anzOwnTaunt++;
        }
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_504 : SimTemplate //* 女巫哈加莎 Hagatha the Witch
//<b>Battlecry:</b> Deal 3 damage to all minions.
//<b>战吼：</b>对所有随从造成3点伤害。 
	{
		
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.GIL_504h, ownplay); 
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;
			
            p.allMinionsGetDamage(3);
        }
	}
}
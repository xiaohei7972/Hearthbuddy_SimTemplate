using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_522 : SimTemplate //* 疾疫使者 Wartbringer
//<b>Battlecry:</b> If you played 2_spells this turn, deal 2_damage.
//<b>战吼：</b>如果你在本回合施放了两个法术，则造成2点伤害。 
	{
        

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.minionGetDamageOrHeal(target, 2);
		}
	}
}
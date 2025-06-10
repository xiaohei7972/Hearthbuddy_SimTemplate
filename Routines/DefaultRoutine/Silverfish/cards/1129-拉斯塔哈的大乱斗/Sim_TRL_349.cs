using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_349 : SimTemplate //* 血顶战略家 Bloodscalp Strategist
//<b>Battlecry:</b> If you have a weapon equipped, <b>Discover</b> a spell.
//<b>战吼：</b>如果你装备着武器，<b>发现</b>一张法术牌。 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                if (p.ownWeapon.Durability >= 1)
                {
                    p.drawACard(CardDB.cardNameEN.frostbolt,own.own, true);
                }
            }
            else
            {
                if (p.enemyWeapon.Durability >= 1)
                {
                    p.drawACard(CardDB.cardNameEN.frostbolt,own.own, true);
                }
            }
		}

	}
}
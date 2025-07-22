using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_561 : SimTemplate //* 黑樟林树精 Blackwald Pixie
//<b>Battlecry:</b> Refresh your Hero Power.
//<b>战吼：</b>复原你的英雄技能。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
			{
				p.anzUsedOwnHeroPower = 0;
				p.ownAbilityReady = true;
			}
			else
			{
				p.anzUsedEnemyHeroPower = 0;
				p.enemyAbilityReady = true;
			}
		}
	}
}
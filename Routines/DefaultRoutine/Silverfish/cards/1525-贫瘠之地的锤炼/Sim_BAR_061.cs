using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_061 : SimTemplate //* 棘齿城私掠者 Ratchet Privateer
	{
		//<b>Battlecry:</b> Give your weapon +1 Attack.
		//<b>战吼：</b>使你的武器获得+1攻击力。
	    public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (p.ownWeapon.Durability >= 1)
                {
                    p.ownWeapon.Angr += 1;
                    p.minionGetBuffed(p.ownHero, 1, 0);
                    p.ownHero.updateReadyness();
                }
                
            }
            else
            {
                if (p.enemyWeapon.Durability >= 1)
                {
                    p.enemyWeapon.Angr += 1;
                    p.minionGetBuffed(p.enemyHero, 1, 0);
                }
                
            }
        }	
		
	}
}

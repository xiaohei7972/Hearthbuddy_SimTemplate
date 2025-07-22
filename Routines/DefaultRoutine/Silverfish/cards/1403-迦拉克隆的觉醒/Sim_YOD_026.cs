using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOD_026 : SimTemplate //* 邪魔仆从 Fiendish Servant
	{
		//[x]<b>Deathrattle:</b> Give thisminion's Attack to a randomfriendly minion.
		//<b>亡语：</b>随机使一个友方随从获得该随从的攻击力。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            int attack = m.Angr;
            Minion target = (m.own) ? p.searchRandomMinion(p.ownMinions, searchmode.searchLowestAttack) : p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestAttack);
            if (target != null) p.minionGetBuffed(target, attack, 0);
        }		
		
	}
}

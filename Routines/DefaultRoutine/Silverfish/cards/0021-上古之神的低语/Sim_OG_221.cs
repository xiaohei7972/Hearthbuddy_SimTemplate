using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_OG_221 : SimTemplate //* 无私的英雄 Selfless Hero
//<b>Deathrattle:</b> Give a random friendly minion <b>Divine Shield</b>.
//<b>亡语：</b>随机使一个友方随从获得<b>圣盾</b>。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
			Minion target = (m.own) ? p.searchRandomMinion(p.ownMinions, searchmode.searchLowestAttack) : p.searchRandomMinion(p.enemyMinions, searchmode.searchLowestAttack);
			if (target != null) target.divineshild = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_691 : SimTemplate //* 青玉游荡者 Jade Swarmer
//<b>Stealth</b><b>Deathrattle:</b> Summon a{1} {0} <b>Jade Golem</b>.@<b>Stealth</b><b>Deathrattle:</b> Summon a <b>Jade Golem</b>.
//<b>潜行，亡语：</b>召唤一个{0}的<b>青玉魔像</b>。@<b>潜行，亡语：</b>召唤一个<b>青玉魔像</b>。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(p.getNextJadeGolem(m.own), m.zonepos - 1, m.own);
        }
    }
}
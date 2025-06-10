using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_902 : SimTemplate //* 艾雅·黑掌 Aya Blackpaw
//<b>Battlecry and Deathrattle:</b> Summon a{1} {0} <b>Jade Golem</b>. @ <b>Battlecry and Deathrattle:</b> Summon a <b>Jade Golem</b>.
//<b>战吼，亡语：</b>召唤一个{0}的<b>青玉魔像</b>。@<b>战吼，亡语：</b>召唤一个<b>青玉魔像</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.callKid(p.getNextJadeGolem(m.own), m.zonepos, m.own);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(p.getNextJadeGolem(m.own), m.zonepos - 1, m.own);
        }
    }
}
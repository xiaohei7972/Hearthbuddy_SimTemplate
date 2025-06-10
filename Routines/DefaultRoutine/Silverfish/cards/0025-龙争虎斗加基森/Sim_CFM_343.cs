using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_343 : SimTemplate //* 青玉巨兽 Jade Behemoth
//[x]<b>Taunt</b><b>Battlecry:</b> Summon a{1}{0} <b>Jade Golem</b>.@[x]<b>Taunt</b><b>Battlecry:</b> Summon a<b>Jade Golem</b>.
//<b>嘲讽，战吼：</b>召唤一个{0}的<b>青玉魔像</b>。@<b>嘲讽，战吼：</b>召唤一个<b>青玉魔像</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.callKid(p.getNextJadeGolem(m.own), m.zonepos, m.own);
        }
    }
}
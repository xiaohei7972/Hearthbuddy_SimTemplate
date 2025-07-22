using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_715 : SimTemplate //* 青玉之灵 Jade Spirit
//<b>Battlecry:</b> Summon a{1} {0} <b>Jade_Golem</b>.@<b>Battlecry:</b> Summon a <b>Jade_Golem</b>.
//<b>战吼：</b>召唤一个{0}的<b>青玉魔像</b>。@<b>战吼：</b>召唤一个<b>青玉魔像</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.callKid(p.getNextJadeGolem(m.own), m.zonepos, m.own);
        }
	}
}
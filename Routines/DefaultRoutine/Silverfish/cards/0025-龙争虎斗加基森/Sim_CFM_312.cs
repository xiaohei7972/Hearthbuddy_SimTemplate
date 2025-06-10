using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_312 : SimTemplate //* 青玉酋长 Jade Chieftain
//<b>Battlecry:</b> Summon a{1} {0} <b>Jade Golem</b>. Give it <b>Taunt</b>. @<b>Battlecry:</b> Summon a <b>Jade Golem</b>. Give it <b>Taunt</b>.
//<b>战吼：</b>召唤一个{0}的<b>青玉魔像</b>，使其获得<b>嘲讽</b>。@<b>战吼：</b>召唤一个<b>青玉魔像</b>，使其获得<b>嘲讽</b>。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.callKid(p.getNextJadeGolem(m.own), m.zonepos, m.own);
            Minion mnn = m.own ? p.ownMinions[m.zonepos] : p.enemyMinions[m.zonepos];
            if (mnn.playedThisTurn && !mnn.taunt)
            {
                mnn.taunt = true;
                if (mnn.own) p.anzOwnTaunt++;
                else p.anzEnemyTaunt++;
            }
        }
    }
}
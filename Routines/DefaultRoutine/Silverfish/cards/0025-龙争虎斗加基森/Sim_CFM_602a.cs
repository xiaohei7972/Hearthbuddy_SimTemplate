using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_602a : SimTemplate //* 雕琢玉像 Cut from Jade
//Summon a{1} {0} <b>Jade Golem</b>.
//召唤一个{0}的<b>青玉魔像</b>。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(p.getNextJadeGolem(ownplay), pos, ownplay);
        }
    }
}
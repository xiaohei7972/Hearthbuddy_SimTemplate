using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_071 : SimTemplate //* 血帆啸猴 Bloodsail Howler
//[x]<b>Rush</b><b>Battlecry:</b> Gain +1/+1for each other Pirateyou control.
//<b>突袭</b>，<b>战吼：</b>你每控制一个其他海盗，便获得+1/+1。 
	{
        

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetRush(own); 
			List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if ((TAG_RACE)m.handcard.card.race == TAG_RACE.PIRATE)
                {
                    int buff = (own.own) ? p.ownMinions.Count - 1 : p.enemyMinions.Count - 1;
					p.minionGetBuffed(own, buff, buff);
					break;
                }
            }
        }
    }
}
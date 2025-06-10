using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_085 : SimTemplate //* 精神控制技师 Mind Control Tech
//[x]<b>Battlecry:</b> If your opponenthas 4 or more minions, take control of one at random.
//<b>战吼：</b>如果你的对手拥有4个或者更多随从，随机获得其中一个的控制权。 
	{
        

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                if (p.enemyMinions.Count >= 4)
                {
                    List<Minion> temp = new List<Minion>(p.enemyMinions);
                    temp.Sort((a, b) => a.Angr.CompareTo(b.Angr));
                    Minion targett;
                    targett = temp[0];
                    if (targett.taunt && temp.Count >= 2 && !temp[1].taunt) targett = temp[1];
                    p.minionGetControlled(targett, true, false);

                }
            }
            else
            {
                if (p.ownMinions.Count >= 4)
                {
                    List<Minion> temp = new List<Minion>(p.ownMinions);
                    temp.Sort((a, b) => a.Angr.CompareTo(b.Angr));
                    Minion targett;
                    targett = temp[0];
                    if (targett.taunt && temp.Count >= 2 && !temp[1].taunt) targett = temp[1];
                    p.minionGetControlled(targett, false, false);

                }
            }
		}

	}

}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_280 : SimTemplate //* 沙赫柯特工兵 Sahket Sapper
//<b>Deathrattle:</b> Return a _random enemy minion to_ your_opponent's_hand.
//<b>亡语：</b>随机将一个敌方随从移回对手的手牌。 
	{
		public override void onDeathrattle(Playfield p, Minion m)
        {
            List<Minion> temp = new List<Minion>();

            if (m.own)
            {
                List<Minion> temp2 = new List<Minion>(p.ownMinions);
                temp2.Sort((a, b) => -a.Angr.CompareTo(b.Angr));
                temp.AddRange(temp2);
            }
            else
            {
                List<Minion> temp2 = new List<Minion>(p.enemyMinions);
                temp2.Sort((a, b) => a.Angr.CompareTo(b.Angr));
                temp.AddRange(temp2);
            }

            if (temp.Count >= 1)
            {
                if (m.own)
                {
                    Minion target = new Minion();
                    target = temp[0];
                    if (temp.Count >= 2 && target.taunt && temp[1].taunt) target = temp[1];
                    p.minionReturnToHand(target, m.own, 0);
                }
                else
                {
                    Minion target = new Minion();

                    target = temp[0];
                    if (temp.Count >= 2 && !target.taunt && !temp[1].taunt) target = temp[1];
                    p.minionReturnToHand(target, m.own, 0);
                }
            }
        }
	}
}
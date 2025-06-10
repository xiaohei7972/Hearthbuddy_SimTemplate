using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_FP1_020 : SimTemplate //* 复仇 Avenge
//<b>Secret:</b> When one of your minions dies, give a random friendly minion +3/+2.
//<b>奥秘：</b>当你的随从死亡时，随机使一个友方随从获得+3/+2。 
    {
        
        

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            List<Minion> temp = new List<Minion>();


            if (ownplay)
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
                if (ownplay)
                {
                    Minion trgt = temp[0];
                    if (temp.Count >= 2 && trgt.taunt && !temp[1].taunt) trgt = temp[1];
                    p.minionGetBuffed(trgt, 3, 2);
                }
                else
                {

                    Minion trgt = temp[0];
                    if (temp.Count >= 2 && !trgt.taunt && temp[1].taunt) trgt = temp[1];
                    p.minionGetBuffed(trgt, 3, 2);
                }
            }


        }
    }

}
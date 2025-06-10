using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AV_102 : SimTemplate //* 冷饮制冰机 popsicooler
    {
        public override void onDeathrattle(Playfield p, Minion m)
        {
            //<b>亡语：</b>随机<b>冻结</b>两个敌方随从。
            List<Minion> temp2 = (m.own) ? new List<Minion>(p.enemyMinions) : new List<Minion>(p.ownMinions);
            int i = 0;
            int p_ = temp2.Count;
            if (m.own) 
            foreach (Minion enemy in temp2)
            {
                if (i > 2 || p_ == 0) break; //通过两个条件来控制冻结的随从，如果敌方随从数量为0，则会直接跳出循环；如果敌方只有一个随从，循环执行一次后，通过P函数跳出循环；敌方随从数量等于2或大于2则，通过I函数随机冻结两个随从
                p.minionGetFrozen(enemy);
                i++;
                p_--;

            }
            
        }
    }
 }



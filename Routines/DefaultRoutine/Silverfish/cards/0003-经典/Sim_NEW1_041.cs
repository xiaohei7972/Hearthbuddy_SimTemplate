using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NEW1_041 : SimTemplate //* 狂奔科多兽 Stampeding Kodo
	{
		//<b>Battlecry:</b> Destroy a random enemy minion with 2 or less Attack.
		//<b>战吼：</b>随机消灭一个攻击力小于或等于2的敌方随从。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp2 = (own.own) ? new List<Minion>(p.enemyMinions) : new List<Minion>(p.ownMinions);
            temp2.Sort((a, b) => a.Hp.CompareTo(b.Hp));//destroys the weakest
            foreach (Minion enemy in temp2)
            {
                if (enemy.Angr <= 2)
                {
                    p.minionGetDestroyed(enemy);
                    break;
                }
            }
        }
    }
}

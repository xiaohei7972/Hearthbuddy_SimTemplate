using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_082 : SimTemplate //* 疯狂投弹者 Mad Bomber
	{
		//<b>Battlecry:</b> Deal 3 damage randomly split between all other characters.
		//<b>战吼：</b>造成3点伤害，随机分配到所有其他角色身上。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            int anz = 3;
            for (int i = 0; i < anz; i++)
            {
                if (p.ownHero.Hp <= anz)
                {
                    p.minionGetDamageOrHeal(p.ownHero, 1);
                    continue;
                }
                List<Minion> temp = new List<Minion>(p.enemyMinions);
                if (temp.Count == 0)
                {
                    temp.AddRange(p.ownMinions);
                }
                temp.Sort((a, b) => a.Hp.CompareTo(b.Hp));//destroys the weakest

                foreach (Minion m in temp)
                {
                    if (m.entitiyID == own.entitiyID) continue;
                    p.minionGetDamageOrHeal(m, 1);
                    break;
                }
                p.minionGetDamageOrHeal(p.enemyHero, 1);
            }
		}
	}
}
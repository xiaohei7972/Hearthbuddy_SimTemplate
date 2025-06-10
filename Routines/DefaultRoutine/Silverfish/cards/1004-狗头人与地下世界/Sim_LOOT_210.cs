using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_210 : SimTemplate //* 叛变 Sudden Betrayal
//<b>Secret:</b> When a minion attacks your hero, instead it attacks one of_its neighbors.
//<b>奥秘：</b>当一个随从攻击你的英雄时，改为该随从攻击与其相邻的一个随从。
    {
		
		
		
        public override void onSecretPlay(Playfield p, bool ownplay, Minion attacker, Minion target, out int number)
        {
            number = 0;
            Minion newTarget = null;
            if (ownplay)
            {
                foreach (Minion m in p.enemyMinions)
                {
                    if (target.entitiyID != m.entitiyID && attacker.entitiyID != m.entitiyID)
                    {
                        newTarget = m;
                    }
                }

                if (newTarget == null)
                {
                    foreach (Minion m in p.ownMinions)
                    {
                        if (target.entitiyID != m.entitiyID && attacker.entitiyID != m.entitiyID)
                        {
                            newTarget = m;
                        }
                    }
                }

                if (newTarget == null)
                {
                    newTarget = p.enemyHero;
                }
            }

            else
            {
                foreach (Minion m in p.ownMinions)
                {
                    if (target.entitiyID != m.entitiyID && attacker.entitiyID != m.entitiyID)
                    {
                        newTarget = m;
                    }
                }

                if (newTarget == null)
                {
                    foreach (Minion m in p.enemyMinions)
                    {
                        if (target.entitiyID != m.entitiyID && attacker.entitiyID != m.entitiyID)
                        {
                            newTarget = m;
                        }
                    }
                }

                if (newTarget == null)
                {
                    newTarget = p.ownHero;
                }
            }


            if (newTarget != null)
            {
                number = newTarget.entitiyID;
            }
        }

    }

}

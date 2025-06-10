using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_533 : SimTemplate //* 误导 Misdirection
	{
		//<b>Secret:</b> When an enemy attacks your hero, instead it attacks another random character.
		//<b>奥秘：</b>当一个敌人攻击你的英雄时，改为该敌人随机攻击另一个角色
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

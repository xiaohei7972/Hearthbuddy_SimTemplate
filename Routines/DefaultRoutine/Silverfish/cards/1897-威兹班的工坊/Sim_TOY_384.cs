using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：2
	//Purifying Power
	//净化之力
	//<b>Silence</b> all friendly minions, then give them +1/+2.
	//<b>沉默</b>所有友方随从，然后使其获得+1/+2。
	class Sim_TOY_384 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 遍历所有己方随从
            foreach (Minion m in p.ownMinions)
            {
                // 沉默随从
                p.minionGetSilenced(m);

                // 给予随从 +1/+2 的增益
                p.minionGetBuffed(m, 1, 2);
            }
        }
    }
}

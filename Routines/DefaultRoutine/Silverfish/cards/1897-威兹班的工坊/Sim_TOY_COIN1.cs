using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：0
	//The Coin
	//幸运币
	//Gain 1 Mana Crystal this turn only.
	//在本回合中，获得一个法力水晶。
	class Sim_TOY_COIN1 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 本回合增加一个临时的法力水晶
            if (ownplay)
            {
                p.mana++;
            }
            else
            {
                p.enemyMaxMana++;
            }
        }

    }
}

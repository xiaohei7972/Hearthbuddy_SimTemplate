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
	class Sim_VAC_COIN2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 在本回合中，获得一个法力水晶
            if (ownplay)
            {
                p.mana = Math.Min(p.ownMaxMana, p.mana + 1);
            }
            else
            {
                p.mana = Math.Min(p.ownMaxMana, p.mana + 1);
            }
        }
    }
}

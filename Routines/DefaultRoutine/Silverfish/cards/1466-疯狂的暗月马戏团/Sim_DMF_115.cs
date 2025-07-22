using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_115 : SimTemplate //* 怨灵捣蛋鬼 Revenant Rascal
	{
        //<b>Battlecry:</b> Destroy a Mana Crystal for both players.
        //<b>战吼：</b>摧毁双方玩家的各一个法力水晶。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                p.ownMaxMana--;
                p.enemyMaxMana--;
            }
            else
            {
                p.enemyMaxMana--;
                p.ownMaxMana--;
            }
        }
    }
}

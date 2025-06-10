using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_351 : SimTemplate //* 贪婪的林精 Greedy Sprite
//<b>Deathrattle:</b> Gain an empty Mana Crystal.
//<b>亡语：</b>获得一个空的法力水晶。 
    {
        
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own) p.ownMaxMana = Math.Min(10, p.ownMaxMana + 1);
            else p.enemyMaxMana = Math.Min(10, p.enemyMaxMana + 1);
        }
    }
}
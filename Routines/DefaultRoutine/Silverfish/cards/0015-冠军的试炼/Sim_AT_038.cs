using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AT_038 : SimTemplate //* 达纳苏斯豹骑士 Darnassus Aspirant
//<b>Battlecry:</b> Gain an empty Mana Crystal.<b>Deathrattle:</b> Lose a Mana Crystal.
//<b>战吼：</b>获得一个空的法力水晶。<b>亡语：</b>失去一个法力水晶。 
    {
		
		

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own) p.ownMaxMana = Math.Min(10, p.ownMaxMana + 1);
            else p.enemyMaxMana = Math.Min(10, p.enemyMaxMana + 1);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
			if (m.own) p.ownMaxMana--;
            else p.enemyMaxMana--;
        }
    }
}
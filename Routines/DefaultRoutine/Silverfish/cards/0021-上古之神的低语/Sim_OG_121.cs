using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_121 : SimTemplate //* 古加尔 Cho'gall
//<b>Battlecry:</b> The next spell you cast this turn costs Health instead of Mana.
//<b>战吼：</b>在本回合中，你施放的下一个法术不再消耗法力值，转而消耗生命值。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own) p.nextSpellThisTurnCostHealth = true;
        }
    }
}
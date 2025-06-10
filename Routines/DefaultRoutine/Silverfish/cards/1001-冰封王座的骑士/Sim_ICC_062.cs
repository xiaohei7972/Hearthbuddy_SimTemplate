using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_062: SimTemplate //* 熔甲卫士 Mountainfire Armor
//<b>Deathrattle:</b> If it's your opponent's turn,gain 6 Armor.
//<b>亡语：</b>如果此时是你对手的回合，则获得6点护甲值。 
    {
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (!p.isOwnTurn) p.minionGetArmor(m.own ? p.ownHero : p.enemyHero, 6);
        }
    }
}
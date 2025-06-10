using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_280 : SimTemplate //* 克苏恩 C'Thun
//<b>Battlecry:</b> Deal damage equal to this minion's Attack randomly split among all enemies.
//<b>战吼：</b>造成等同于该随从攻击力的伤害，随机分配到所有敌人身上。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int times = p.anzOgOwnCThunAngrBonus + 6 - own.Angr;
            if (times < 1) times = own.Angr;
            else times += own.Angr;
            p.allCharsOfASideGetRandomDamage(!own.own, times);
            p.allMinionOfASideGetDamage(!own.own, 1);
        }
    }
}
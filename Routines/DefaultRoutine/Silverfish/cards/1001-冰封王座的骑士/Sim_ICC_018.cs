using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_018: SimTemplate //* 幻影海盗 Phantom Freebooter
//<b>Battlecry:</b> Gain stats equal to your weapon's.
//<b>战吼：</b>获得等同于你的武器属性的属性值。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            //p.minionGetBuffed(own, 1, 1);
            if (own.own)
            {
                own.Angr += p.ownWeapon.Angr;
                own.Hp += p.ownWeapon.Durability;
                own.maxHp += p.ownWeapon.Durability;
            }
            else
            {
                own.Angr += p.enemyWeapon.Angr;
                own.Hp += p.enemyWeapon.Durability;
                own.maxHp += p.enemyWeapon.Durability;
            }
        }
    }
}

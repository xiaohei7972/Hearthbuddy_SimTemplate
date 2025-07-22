using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_828: SimTemplate //* 死亡猎手雷克萨 Deathstalker Rexxar
//[x]<b>Battlecry:</b> Deal 2 damageto all enemy minions.
//<b>战吼：</b>对所有敌方随从造成2点伤害。 
    {
        
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.ICC_828p, ownplay); 
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;

            p.allMinionOfASideGetDamage(!ownplay, 2);
        }
    }
}
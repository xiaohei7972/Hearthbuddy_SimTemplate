using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_837 : SimTemplate //* 放马过来 Bring It On!
//Gain 10 Armor. Reduce the Cost of minions in your opponent's hand by (2).
//获得10点护甲值。使你对手的手牌中所有随从牌的法力值消耗减少（2）点。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 10);
        }
    }
}
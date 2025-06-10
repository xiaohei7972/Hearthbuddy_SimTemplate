using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_827: SimTemplate //* 虚空之影瓦莉拉 Valeera the Hollow
//<b>Battlecry:</b> Gain <b>Stealth</b> until your next turn.
//<b>战吼：</b>获得<b>潜行</b>直到你的下个回合。 
    {
        
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.ICC_827p, ownplay); 
            if (ownplay)
            {
                p.ownHero.armor += 5;
                p.ownHero.stealth = true;
                p.ownHero.conceal = true;
            }
            else
            {
                p.enemyHero.armor += 5;
                p.enemyHero.stealth = true;
                p.enemyHero.conceal = true;
            }
        }
    }
}
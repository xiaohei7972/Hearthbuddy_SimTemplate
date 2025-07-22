using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_727 : SimTemplate //* 冒险号角 Call to Adventure
//Draw the lowest Cost minion from your deck. Give it +2/+2.
//从你的牌库中抽取法力值消耗最低的随从牌，使其获得+2/+2。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.lepergnome, ownplay, true);
            p.owncards[p.owncards.Count - 2].addattack++;
            p.owncards[p.owncards.Count - 2].addHp++;
        }
    }
}
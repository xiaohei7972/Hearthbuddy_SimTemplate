using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_118 : SimTemplate //* 弃暗投明 Renounce Darkness
//Replace your Hero Power and Warlock cards with another class's. The cards cost (1) less.
//将你的英雄技能和术士卡牌替换成其它职业的。这些牌的法力值消耗减少（1）点。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                foreach (Handmanager.Handcard hc in p.owncards) hc.manacost--;
            }
        }
    }
}
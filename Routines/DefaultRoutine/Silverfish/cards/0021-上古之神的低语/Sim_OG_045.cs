using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_OG_045 : SimTemplate //* 寄生感染 Infest
//Give your minions "<b>Deathrattle:</b> Add a random Beast to your hand."
//使你的所有随从获得“<b>亡语：</b>随机将一张野兽牌置入你的手牌”。 
    {
        

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;

            foreach (Minion m in temp)
            {
                m.infest++;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_027: SimTemplate //* 白骨幼龙 Bone Drake
//<b>Deathrattle:</b> Add a random Dragon to your hand.
//<b>亡语：</b>随机将一张龙牌置入你的手牌。 
    {
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.faeriedragon, m.own, true);
        }
    }
}
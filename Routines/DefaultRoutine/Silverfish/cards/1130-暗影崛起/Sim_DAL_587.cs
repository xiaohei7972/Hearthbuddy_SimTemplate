using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_587: SimTemplate //* 闪光蝴蝶 Shimmerfly
//<b>Deathrattle:</b> Add a random Hunter spell to your hand.
//<b>亡语：</b>随机将一张猎人法术牌置入你的手牌。 
    {
        
        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardNameEN.animalcompanion, m.own, true); 
           
        }
    }
}
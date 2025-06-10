using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_065: SimTemplate //* 白骨大亨 Bone Baron
//<b>Deathrattle:</b> Add two 1/1 Skeletons to your hand.
//<b>亡语：</b>将两张1/1的“骷髅”置入你的手牌。 
    {
        
        
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.ICC_026t, m.own, true); 
            p.drawACard(CardDB.cardIDEnum.ICC_026t, m.own, true);
        }
    }
}
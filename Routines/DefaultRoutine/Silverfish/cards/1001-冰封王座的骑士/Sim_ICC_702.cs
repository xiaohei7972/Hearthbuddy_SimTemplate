using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_702: SimTemplate //* 孱弱的掘墓者 Shallow Gravedigger
//<b>Deathrattle:</b> Add a random <b>Deathrattle</b> minion to your_hand.
//<b>亡语：</b>随机将一个具有<b>亡语</b>的随从置入你的手牌。 
    {
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own, true);
        }
    }
}
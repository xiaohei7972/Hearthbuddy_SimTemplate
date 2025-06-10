using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_854: SimTemplate //* 阿尔福斯 Arfus
//<b>Deathrattle:</b> Add a random <b>Death Knight</b> card to your_hand.
//<b>亡语：</b>随机将一张<b>死亡骑士</b>牌置入你的手牌。 
    {
        

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own, true);
        }
    }
}
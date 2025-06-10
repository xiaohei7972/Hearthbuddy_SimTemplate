using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_082: SimTemplate //* 寒冰克隆 Frozen Clone
//<b>Secret:</b> After your opponent plays a minion, add two copies of it to_your hand.
//<b>奥秘：</b>在你的对手使用一张随从牌后，将两张该随从的复制置入你的手牌。 
    {
        

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_244 : SimTemplate //* 掠食本能 Predatory Instincts
//[x]Draw a Beast from yourdeck. Double its Health.
//从你的牌库中抽一张野兽牌。将其生命值翻倍。
    {

        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
        }

    }
}

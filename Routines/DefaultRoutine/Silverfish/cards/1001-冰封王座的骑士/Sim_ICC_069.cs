using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_069: SimTemplate //* 鬼影巫师 Ghastly Conjurer
//<b>Battlecry:</b> Add a 'Mirror Image' spell to your hand.
//<b>战吼：</b>将一张“镜像”法术牌置入你的手牌。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.mirrorimage, own.own, true);
        }
    }
}
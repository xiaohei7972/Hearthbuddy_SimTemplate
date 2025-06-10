using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS3_008 : SimTemplate //* 血帆桨手 Bloodsail Deckhand
	{
        //[x]<b>Battlecry:</b> The nextweapon you play costs(1) less.
        //<b>战吼：</b>你的下一张武器牌的法力值消耗减少（1）点。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach(Handmanager.Handcard hc in p.owncards)
            {
                if(hc.card.type == CardDB.cardtype.WEAPON)
                {
                    hc.manacost--;
                    p.evaluatePenality -= 5;
                }
            }
        }

    }
}

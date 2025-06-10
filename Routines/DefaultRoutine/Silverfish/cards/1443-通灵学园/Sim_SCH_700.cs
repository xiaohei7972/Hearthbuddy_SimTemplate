using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_700 : SimTemplate //* 精魂狱卒 Spirit Jailer
	{
        //<b>Battlecry:</b> Shuffle 2 Soul Fragments into your deck.
        //<b>战吼：</b>将两张灵魂残片洗入你的牌库。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                p.AnzSoulFragments += 2;
                p.ownDeckSize += 2;
            }
            else
            {
                p.enemyDeckSize += 2;
            }
        }
    }
}

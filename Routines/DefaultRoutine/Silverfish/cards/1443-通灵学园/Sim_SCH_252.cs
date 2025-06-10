using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_252 : SimTemplate //* 切髓之刃 Marrowslicer
	{
        //<b>Battlecry:</b> Shuffle 2 Soul Fragments into your deck.
        //<b>战吼：</b>将两张灵魂残片洗入你的牌库。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
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

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_003t : SimTemplate //* 幸运之魂囤积者 Luckysoul Hoarder
	{
        //[x]<b>Corrupted</b><b>Battlecry:</b> Shuffle 2 SoulFragments into your deckand draw a card.
        //<b>已腐蚀</b><b>战吼：</b>将两张灵魂残片洗入你的牌库，抽一张牌。
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
            p.drawACard(CardDB.cardIDEnum.None, own.own);
        }
    }
}

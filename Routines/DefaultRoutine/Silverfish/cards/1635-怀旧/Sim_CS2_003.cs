using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS2_003 : SimTemplate //* 心灵视界 Mind Vision
	{
		//Put a copy of a random card in your opponent's hand into your hand.
		//随机复制对手手牌中的一张牌，将其置入你的手牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int anz = (ownplay) ? p.enemyAnzCards : p.owncards.Count;
            if (anz >= 1)
            {
                p.drawACard(CardDB.cardIDEnum.None, ownplay,true);
            }
        }

    }
}

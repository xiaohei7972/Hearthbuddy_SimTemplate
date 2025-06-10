using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_637 : SimTemplate //* 凶猛咆哮 Ferocious Howl
//Draw a card.Gain 1 Armor for each card in your hand.
//抽一张牌。你每有一张手牌，便获得1点护甲值。 
	{



		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 5);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 5);
            }
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_088 : SimTemplate //* 英勇药水 Potion of Heroism
//Give a minion <b>Divine_Shield</b>.Draw a card.
//使一个随从获得<b>圣盾</b>。抽一张牌。 
	{
		
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			target.divineshild = true;
			p.drawACard(CardDB.cardNameEN.unknown, ownplay);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
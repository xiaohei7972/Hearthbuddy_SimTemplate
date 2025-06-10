using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_436 : SimTemplate //* 棱彩透镜 Prismatic Lens
//Draw a minion and a spell from your deck. Swap their Costs.
//从你的牌库中抽一张随从牌和一张法术牌，并使其法力值消耗互换。 
	{
		

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
            p.drawACard(CardDB.cardNameEN.unknown, ownplay);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}
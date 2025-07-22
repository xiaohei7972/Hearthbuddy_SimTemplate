using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：4
	//Sanguine Infestation
	//血虫感染
	//Draw 2 cards.Summon two 0/2 Leeches.
	//抽两张牌。召唤两条0/2的水蛭。
	class Sim_EDR_817 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_810t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;            
            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
		}
		
		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), //确保有位置召唤
            };
        }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：4
	//Panther Mask
	//奔行豹面具
	//Set a minion's stats to5/4 and give it <b>Stealth</b>. Draw 2 cards.
	//将一个随从的属性值变为5/4并使其获得<b>潜行</b>。抽两张牌。
	class Sim_DINO_432 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionSetAngrToX(target, 5);
				p.minionSetLifetoX(target, 4);
				target.stealth = true;
				p.drawACard(CardDB.cardIDEnum.None, ownplay);
				p.drawACard(CardDB.cardIDEnum.None, ownplay);
			}
		}
		public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
			};
        }
		
	}
}

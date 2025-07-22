using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：4 攻击力：4 生命值：4
	//Virmen Sensei
	//兔妖教头
	//<b>Battlecry:</b> Give a friendly Beast +3/+3.
	//<b>战吼：</b>使一个友方野兽获得+3/+3。
	class Sim_WON_300 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{

			// 如果目标是友方野兽
			if (target != null && target.own && (CardDB.Race)target.handcard.card.race == CardDB.Race.PET)
			{
				// 增加3点攻击力和3点生命值
				p.minionGetBuffed(target, 3, 3);
			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标只能是随从
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标只能是友方
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 20), // 目标只能是野兽
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 无目标时也可以使用
            };
		}
	}
}

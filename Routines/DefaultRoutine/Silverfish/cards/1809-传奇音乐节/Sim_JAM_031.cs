using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：3
	//Reverberations
	//回荡混响
	//Summon a copy of a minion. Each one dies after taking damage.
	//召唤一个随从的复制。复制和本体都会在受到伤害后死亡。
	class Sim_JAM_031 : SimTemplate
	{
		
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count; // 获取随从位置
            CardDB.Card copyCard = CardDB.Instance.getCardDataFromID(target.handcard.card.cardIDenum); // 获取复制卡牌
            p.callKid(copyCard, pos, ownplay, true); // 召唤复制	
		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 需要随从目标
			};
		}	

	}
}

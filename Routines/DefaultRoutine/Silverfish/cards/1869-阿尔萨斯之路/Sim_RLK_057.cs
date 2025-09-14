using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：2
	//Dark Transformation
	//黑暗突变
	//Transform an Undead into a 4/5 Undead Monstrosity with <b>Rush</b>.
	//将一个亡灵变形成为一个4/5并具有<b>突袭</b>的亡灵怪物。
	class Sim_RLK_057 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.RLK_057t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				p.minionTransform(target, kid);
			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), //目标只能是友方
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE,11), //目标只能是亡灵
            };
		}
		
	}
}

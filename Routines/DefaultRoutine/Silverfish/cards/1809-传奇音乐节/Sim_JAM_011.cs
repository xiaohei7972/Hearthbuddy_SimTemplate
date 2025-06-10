using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 萨满祭司 费用：6 攻击力：3 耐久度：4
	//Horn of the Windlord
	//风领主的管号
	//[x]<b>Windfury</b>Whenever your heroattacks a minion, setits stats to 3/3.
	//<b>风怒</b>。每当你的英雄攻击随从时，将被攻击随从的属性值变为3/3。
	class Sim_JAM_011 : SimTemplate
	{
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.JAM_011);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

			p.equipWeapon(card, ownplay);
			if (target != null)
			{
				target.Angr = 3;
				target.Hp = 3;
			}

		}

		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要选择一个目标
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 需要选择一个随从目标
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 需要选择一个敌方目标
			};
		}
	}
}

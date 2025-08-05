using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：4
	//Eversong Portal
	//永歌传送门
	//[x]Summon $1 4/4 |4(Lynx, Lynxes)with <b>Rush</b> <i>(improved by<b>Spell Damage</b>)</i>.
	//召唤$1只4/4并具有<b>突袭</b>的山猫<i>（受<b>法术伤害</b>加成影响）</i>。
	class Sim_RLK_819 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TUTR_RLK_063t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			for (int i = 0; i < (ownplay ? p.spellpower + hc.card.spellpowervalue : p.enemyspellpower + hc.card.spellpowervalue); i++)
			{
				p.callKid(kid, pos, ownplay);
			}
		}
		public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
			};
		}
	}
}

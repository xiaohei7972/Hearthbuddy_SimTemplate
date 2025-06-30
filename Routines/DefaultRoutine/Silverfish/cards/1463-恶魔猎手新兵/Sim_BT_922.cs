using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 恶魔猎手 费用：2 攻击力：1 耐久度：0
	//Umberwing
	//棕红之翼
	//<b>Battlecry:</b> Summon two 1/1 Felwings.
	//<b>战吼：</b>召唤两只1/1的邪翼蝠。
	class Sim_BT_922 : SimTemplate
	{
		CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_922);
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BT_922t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(weapon, ownplay);
		}

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, own.own);
			p.callKid(kid, pos, own.own);
        }
		
	}
}

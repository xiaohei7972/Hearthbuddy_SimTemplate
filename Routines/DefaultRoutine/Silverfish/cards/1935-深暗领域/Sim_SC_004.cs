using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//英雄 无效的 费用：8
	//Kerrigan, Queen of Blades
	//刀锋女王凯瑞甘
	//[x]<b>Battlecry:</b> Summon two2/5 Hive Queens. Deal 3damage to all enemies.
	//<b>战吼：</b>召唤两个2/5的巢群虫后。对所有敌人造成3点伤害。
	class Sim_SC_004 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_003);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, own.own);
			p.callKid(kid, pos, own.own);
			p.allCharsOfASideGetDamage(!own.own, 3);

		}

	}
}

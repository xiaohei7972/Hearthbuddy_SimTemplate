using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 德鲁伊 费用：8
	//Hydration Station
	//补水区
	//Resurrect three of your different highest Cost <b>Taunt</b> minions.
	//复活你法力值消耗最高的三个不同的<b>嘲讽</b>随从。
	class Sim_VAC_948 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (p.ownMaxMana == 10)
            {
                int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count; // 位置
                CardDB.Card kid = CardDB.Instance.getCardDataFromID((p.OwnLastDiedMinion == CardDB.cardIDEnum.None) ? CardDB.cardIDEnum.CS2_179 : p.OwnLastDiedMinion); // 卡牌
                p.callKid(kid, posi, ownplay, false); // 召唤
				p.callKid(kid, posi, ownplay);
				p.callKid(kid, posi, ownplay);
				
            }
		}
		
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：2
	//Delicious Cheese
	//美味奶酪
	//Summon three random @-Cost minions. <i>(Upgrades each turn!)</i>
	//随机召唤三个法力值消耗为（@）的随从。<i>（每回合都会升级！）</i>
	class Sim_VAC_955t : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_182);
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_CS2_120);
		CardDB.Card kid3 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_CS2_118);

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.callKid(kid, m.zonepos - 1, m.own);
			p.callKid(kid2, m.zonepos, m.own);
			p.callKid(kid3, m.zonepos + 1, m.own);
        }
		
	}
}

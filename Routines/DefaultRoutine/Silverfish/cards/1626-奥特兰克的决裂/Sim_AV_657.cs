using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_657 : SimTemplate //* 被亵渎的墓园 desecratedgraveyard
	{
		//在你的回合结束时，消灭你的攻击力最低的随从，召唤一个4/4的影魔。持续3回合。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_657t);

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            int temp = 100;
            Minion temp_m = null;
            foreach (Minion m in p.ownMinions)
            {
                if (m.Angr < temp)
                {
                    temp = m.Angr;
                    temp_m = m;
                }
            }
            if (temp_m != null)
            {
                p.minionGetDestroyed(temp_m);
                int pos = p.ownMinions.Count;
                p.callKid(kid, pos, temp_m.own);
            }
        }

	}
}

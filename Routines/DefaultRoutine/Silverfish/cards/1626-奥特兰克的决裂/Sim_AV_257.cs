using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_257 : SimTemplate //* 熊男爵格雷希尔 bearonglashear
	{
		//<b>战吼：</b>在本局对战中你每施放过一个冰霜法术，召唤一个3/4的可以<b>冻结</b>攻击目标的元素。0<i>（召唤0个）</i>
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_257t);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int count = 0;
            if (own.own)
            {
                foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownGraveyard)
                {
                    if (e.Key == CardDB.cardIDEnum.AV_266 || e.Key == CardDB.cardIDEnum.AV_259)
                    {
                        count++;
                    }
                }
            }

            if (7 - p.ownMinions.Count >= count || (p.ownMinions.Count <= count && 7 >= p.ownMinions.Count + count))
            {
                for (int i = 0; i < count; i++)
                {
                    p.callKid(kid, own.zonepos, true);
                }
            }
            else
            {
                for (int i = 0; i < 7 - p.ownMinions.Count; i++)
                {
                    p.callKid(kid, own.zonepos, true);
                }
            }
        }
		
	}
}

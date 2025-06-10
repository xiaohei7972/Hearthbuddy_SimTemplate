using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_258pt : SimTemplate //* 大地祈咒 earthinvocation
	{
		//<b>英雄技能</b> 召唤两个2/3并具有<b>嘲讽</b>的元素。每回合切换。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_258t6);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int count = (ownplay)?p.ownMinions.Count :p.enemyMinions.Count;
            if (count < 6)
            {
                p.callKid(kid, count, true);
                p.callKid(kid, count + 1, true);
            }
            else if (6 <= count && count < 7)
            {
                p.callKid(kid, count, true);
            }
            
        }
	}
}
